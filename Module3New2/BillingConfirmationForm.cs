using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Module3New2
{
    public partial class BillingConfirmationForm : Form
    {
        private BookingConfirmationForm booking;

        public BillingConfirmationForm(BookingConfirmationForm _booking)
        {
            InitializeComponent();
            booking = _booking;
        }

        private void BillingConfirmationForm_Load(object sender, EventArgs e)
        {
            int sum = booking.outboundFlight.CabinPrice;
            if (booking.returnFlight != null)
            {
                sum += booking.returnFlight.CabinPrice;
            }

            sum *= booking.passengers.Count;
            labelTotal.Text = $"$ {sum}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string MakeBookingReference(int length)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder str = new StringBuilder();
            using (var random = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    random.GetBytes(buffer);
                    uint num = BitConverter.ToUInt32(buffer, 0);
                    str.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return str.ToString();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Session3Entities())
                {
                    string bookingReference = MakeBookingReference(6);
                    foreach (var p in booking.passengers)
                    {
                        int lastTicketID = db.Tickets.OrderByDescending(x => x.ID).FirstOrDefault().ID;
                        string[] outboundNumbers = booking.outboundFlight.FlightNumber.Split('-');
                        foreach (var item in outboundNumbers)
                        {
                            int sOutboundID = db.Schedules.FirstOrDefault(x => x.FlightNumber == item.Trim()).ID;
                            db.Tickets.Add(new Ticket
                            {
                                ID = lastTicketID + 1,
                                UserID = 1,
                                ScheduleID = sOutboundID,
                                CabinTypeID = db.CabinTypes.FirstOrDefault(x => x.Name == booking.cabinType).ID,
                                Firstname = p.FirstName,
                                Lastname = p.LastName,
                                PassportNumber = p.PassportNumber,
                                PassportCountryID = db.Countries.FirstOrDefault(x => x.Name == p.PassportCountry).ID,
                                BookingReference = bookingReference,
                                Confirmed = true,
                                Phone = p.Phone.Replace(" ", "")
                            });

                            db.SaveChanges();
                        }

                        if (booking.returnFlight != null)
                        {
                            string[] returnNumbers = booking.returnFlight.FlightNumber.Split('-');
                            foreach (var item in returnNumbers)
                            {
                                int sReturnID = db.Schedules.FirstOrDefault(x => x.FlightNumber == item.Trim()).ID;
                                db.Tickets.Add(new Ticket
                                {
                                    ID = lastTicketID + 1,
                                    UserID = 1,
                                    ScheduleID = sReturnID,
                                    CabinTypeID = db.CabinTypes.FirstOrDefault(x => x.Name == booking.cabinType).ID,
                                    Firstname = p.FirstName,
                                    Lastname = p.LastName,
                                    PassportNumber = p.PassportNumber,
                                    PassportCountryID = db.Countries.FirstOrDefault(x => x.Name == p.PassportCountry).ID,
                                    BookingReference = bookingReference,
                                    Confirmed = true,
                                    Phone = p.Phone.Replace(" ", "")
                                });

                                db.SaveChanges();
                            }
                        }
                    }
                }

                MessageBox.Show("Success!");
            }
            catch (DbEntityValidationException ex)
            {
                var error = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var fullError = string.Join("\n", error);
                var exception = $"Error: {fullError}";
                MessageBox.Show(exception);
            }
        }
    }
}