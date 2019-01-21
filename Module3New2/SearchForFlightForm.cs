using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Module3New2
{
    public partial class SearchForFlightForm : Form
    {
        private FlightDetails flight = new FlightDetails();
        private List<List<FlightDetails>> q = new List<List<FlightDetails>>();
        private List<FlightDetails> qOutbound;
        private List<FlightDetails> qReturn;
        private DateTime outboundDate;
        private DateTime returnDate;

        public SearchForFlightForm()
        {
            InitializeComponent();
        }

        private void SearchForFlightForm_Load(object sender, EventArgs e)
        {
            // Initialize q[0] and q[1]
            q.Add(null);
            q.Add(null);

            dtpReturn.MinDate = dtpOutbound.Value.AddDays(1);
            GetSetAirports();
            GetSetCabin();
        }

        private void GetSetAirports()
        {
            using (var db = new Session3Entities())
            {
                var q = db.Airports.Select(x => x.IATACode).ToList();

                cbFrom.DataSource = q;
                cbTo.BindingContext = new BindingContext();
                cbTo.DataSource = q;
                cbTo.SelectedIndex = 1;
            }

            cbTo.SelectedIndexChanged += checkFromTo;
            cbFrom.SelectedIndexChanged += checkFromTo;
        }

        private void GetSetCabin()
        {
            using (var db = new Session3Entities())
            {
                var q = db.CabinTypes.Select(x => x.Name).ToList();

                cbCabin.DataSource = q;
            }
        }

        private void checkFromTo(object sender, EventArgs e)
        {
            if (cbFrom.Text == cbTo.Text)
            {
                btnApply.Enabled = false;
                MessageBox.Show("You cannot select the same airport");
            }
            else
            {
                btnApply.Enabled = true;
            }
        }

        private void dtpOutbound_ValueChanged(object sender, EventArgs e)
        {
            dtpReturn.MinDate = dtpOutbound.Value.AddDays(1);
        }

        private void rbReturn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReturn.Checked)
            {
                dgvReturn.Enabled = true;
                cbReturn.Enabled = true;
                labelReturn.Enabled = true;
                dtpReturn.Enabled = true;
            }
            else
            {
                dgvReturn.Enabled = false;
                cbReturn.Enabled = false;
                labelReturn.Enabled = false;
                dtpReturn.Enabled = false;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (rbOne.Checked)
            {
                outboundDate = dtpOutbound.Value.Date;
                qOutbound = flight.GetFlightDetails(cbFrom.Text, cbTo.Text, cbCabin.Text, outboundDate);
                if (qOutbound.Count > 0)
                {
                    if (qOutbound.Select(x => x.FlightNumber).Distinct().Count() > 1)
                    {
                        FlightDetails flight = new FlightDetails
                        {
                            From = cbFrom.Text,
                            To = cbTo.Text,
                            Date = qOutbound[0].Date,
                            Time = qOutbound[0].Time,
                            CabinPrice = qOutbound.Sum(x => x.CabinPrice),
                            FlightNumber = string.Join(" - ", qOutbound.Select(x => x.FlightNumber).ToList()),
                            NumberOfStops = qOutbound.Count - 1
                        };

                        qOutbound = new List<FlightDetails> { flight };
                    }
                }
                else
                {
                    MessageBox.Show("No Flights to the destination found (pick either different route, date, or even tick 'One way')");
                }

                q[0] = qOutbound;
                q[1] = null;
                DisplayOutbound();
            }
            else
            {
                outboundDate = dtpOutbound.Value.Date;
                returnDate = dtpReturn.Value.Date;
                qOutbound = flight.GetFlightDetails(cbFrom.Text, cbTo.Text, cbCabin.Text, outboundDate);
                qReturn = flight.GetFlightDetails(cbTo.Text, cbFrom.Text, cbCabin.Text, returnDate);

                if (qOutbound.Count > 0)
                {
                    if (qOutbound.Select(x => x.FlightNumber).Distinct().Count() > 1)
                    {
                        FlightDetails flight = new FlightDetails
                        {
                            From = cbFrom.Text,
                            To = cbTo.Text,
                            Date = qOutbound[0].Date,
                            Time = qOutbound[0].Time,
                            CabinPrice = qOutbound.Sum(x => x.CabinPrice),
                            FlightNumber = string.Join(" - ", qOutbound.Select(x => x.FlightNumber).ToList()),
                            NumberOfStops = qOutbound.Count - 1
                        };

                        qOutbound = new List<FlightDetails> { flight };
                    }
                }
                else
                {
                    MessageBox.Show("No Flights to destination found");
                }

                if (qReturn.Count > 0)
                {
                    if (qReturn.Select(x => x.FlightNumber).Distinct().Count() > 1)
                    {
                        FlightDetails flight = new FlightDetails
                        {
                            From = cbTo.Text,
                            To = cbFrom.Text,
                            Date = qReturn[0].Date,
                            Time = qReturn[0].Time,
                            CabinPrice = qReturn.Sum(x => x.CabinPrice),
                            FlightNumber = string.Join(" - ", qReturn.Select(x => x.FlightNumber).ToList()),
                            NumberOfStops = qReturn.Count - 1
                        };

                        qReturn = new List<FlightDetails> { flight };
                    }
                }
                else
                {
                    MessageBox.Show("No Flights to home found (pick either different route, date, or even tick 'One way')");
                }

                q[0] = qOutbound;
                q[1] = qReturn;
                DisplayOutbound();
                DisplayReturn();
            }
        }

        private void DisplayOutbound()
        {
            dgvOutbound.DataSource = null;
            if (cbOutbound.Checked)
            {
                qOutbound.RemoveAll(x => x.Date != outboundDate);
            }
            else
            {
                qOutbound = q[0].ToList();
            }
            dgvOutbound.DataSource = qOutbound;
        }

        private void DisplayReturn()
        {
            dgvReturn.DataSource = null;
            if (cbReturn.Checked)
            {
                qReturn.RemoveAll(x => x.Date != returnDate);
            }
            else
            {
                qReturn = q[1].ToList();
            }
            dgvReturn.DataSource = qReturn;
        }

        private void cbOutbound_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayOutbound();
            }
            catch
            { }
        }

        private void cbReturn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayReturn();
            }
            catch
            { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOutbound_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (rbOne.Checked)
            {
                if (dgvOutbound.CurrentCell != null)
                {
                    confirmBox.Enabled = true;
                }
                else
                {
                    confirmBox.Enabled = false;
                }
            }
            else
            {
                if (dgvOutbound.CurrentCell != null && dgvReturn.CurrentCell != null)
                {
                    confirmBox.Enabled = true;
                }
                else
                {
                    confirmBox.Enabled = false;
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookingConfirmationForm booking;
            FlightDetails _o;
            FlightDetails _r;

            var outboundCurrent = dgvOutbound.CurrentRow;
            _o = new FlightDetails
            {
                From = outboundCurrent.Cells["From"].Value.ToString(),
                To = outboundCurrent.Cells["To"].Value.ToString(),
                Date = DateTime.ParseExact(outboundCurrent.Cells["Date"].Value.ToString(), @"dd-MMM-yy hh\:mm\:ss", null).Date,
                Time = TimeSpan.ParseExact(outboundCurrent.Cells["Time"].Value.ToString(), @"hh\:mm\:ss", null),
                CabinPrice = int.Parse(outboundCurrent.Cells["CabinPrice"].Value.ToString()),
                FlightNumber = outboundCurrent.Cells["FlightNumber"].Value.ToString(),
                NumberOfStops = int.Parse(outboundCurrent.Cells["NumberOfStops"].Value.ToString())
            };

            if (rbReturn.Checked)
            {
                var returnCurrent = dgvReturn.CurrentRow;
                _r = new FlightDetails
                {
                    From = returnCurrent.Cells["From"].Value.ToString(),
                    To = returnCurrent.Cells["To"].Value.ToString(),
                    Date = DateTime.ParseExact(returnCurrent.Cells["Date"].Value.ToString(), @"dd-MMM-yy hh\:mm\:ss", null).Date,
                    Time = TimeSpan.ParseExact(returnCurrent.Cells["Time"].Value.ToString(), @"hh\:mm\:ss", null),
                    CabinPrice = int.Parse(returnCurrent.Cells["CabinPrice"].Value.ToString()),
                    FlightNumber = returnCurrent.Cells["FlightNumber"].Value.ToString(),
                    NumberOfStops = int.Parse(returnCurrent.Cells["NumberOfStops"].Value.ToString())
                };
                booking = new BookingConfirmationForm(cbCabin.Text, (int)nudPassenger.Value, _o, _r);
            }
            else
            {
                booking = new BookingConfirmationForm(cbCabin.Text, (int)nudPassenger.Value, _o);
            }

            booking.Owner = this;
            booking.ShowDialog();
        }
    }
}