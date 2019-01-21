using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3New2
{
    public class FlightDetails
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string FlightNumber { get; set; }
        public int CabinPrice { get; set; }
        public int NumberOfStops { get; set; }

        // Get all the flight details (migth be slow)
        private List<FlightDetails> GetFlightDetails()
        {
            using (var db = new Session3Entities())
            {
                List<FlightDetails> q = new List<FlightDetails>();
                q = db.Schedules.Select(x => new FlightDetails()
                {
                    From = x.Route.Airport.IATACode,
                    To = x.Route.Airport1.IATACode,
                    Date = x.Date,
                    Time = x.Time,
                    FlightNumber = x.FlightNumber,
                    CabinPrice = (int)x.EconomyPrice,
                    NumberOfStops = 0
                }).ToList();

                return q;
            }
        }

        public List<FlightDetails> GetFlightDetails(string from, string to, string cabinType, DateTime outboundDate, bool firstTime = true, int times = 0)
        {
            // So that stackoverflow exception don't occur
            if (times >= 15)
            {
                return new List<FlightDetails>();
            }
            else
            {
                List<FlightDetails> routes = new List<FlightDetails>();
                List<FlightDetails> routesLists;

                // if outboundDate == DateTime.MinValue it's mean that it's the transit airport
                if (firstTime)
                {
                    routesLists = GetFlightDetails().Where(x =>
                        x.From == from &&
                        x.To == to &&
                        x.To == to &&
                        x.Date <= outboundDate.AddDays(3) &&
                        x.Date >= outboundDate.AddDays(-3)
                    ).ToList();
                }
                else
                {
                    routesLists = GetFlightDetails().Where(x =>
                        x.From == from &&
                        x.To == to &&
                        x.Date >= outboundDate
                    ).ToList();
                }

                if (routesLists.Count == 0)
                {
                    List<FlightDetails> tempDatas;
                    if (outboundDate != DateTime.MinValue)
                    {
                        tempDatas = GetFlightDetails().Where(x =>
                            x.From == from &&
                            x.Date <= outboundDate.AddDays(3) &&
                            x.Date >= outboundDate.AddDays(-3)
                        ).ToList();
                    }
                    else
                    {
                        tempDatas = GetFlightDetails().Where(x =>
                            x.From == from
                        ).ToList();
                    }

                    foreach (var tempData in tempDatas)
                    {
                        routes.Add(tempData);
                        List<FlightDetails> temp2 = GetFlightDetails(tempData.To, to, cabinType, tempData.Date, false, times + 1);
                        if (temp2.Count > 0)
                        {
                            routes.AddRange(temp2);

                            int count = routes.Select(x => x.FlightNumber).Distinct().Count();
                            List<FlightDetails> temp = new List<FlightDetails>();
                            for (int i = 0; i < count; i++)
                            {
                                temp.Add(routes[i]);
                            }

                            routes = temp.ToList();
                            temp = null;

                            switch (cabinType)
                            {
                                case "Business":
                                    for (int i = 0; i < routes.Count; i++)
                                    {
                                        routes[i].CabinPrice = routes[i].CabinPrice * 135 / 100;
                                    }
                                    break;

                                case "First Class":
                                    for (int i = 0; i < routes.Count; i++)
                                    {
                                        routes[i].CabinPrice = routes[i].CabinPrice * 135 / 100 * 130 / 100;
                                    }
                                    break;
                            }

                            return routes;
                        }
                        else
                        {
                            return new List<FlightDetails>();
                        }
                    }
                }

                return routesLists;
            }
        }
    }
}