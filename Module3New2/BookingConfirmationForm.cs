using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Module3New2
{
    public partial class BookingConfirmationForm : Form
    {
        public FlightDetails outboundFlight;
        public FlightDetails returnFlight;
        public string cabinType;
        public int passengerNum;
        public List<Passengers> passengers = new List<Passengers>();
        private int idCount = 0;

        public BookingConfirmationForm(string _cabinType, int _passengerNum, FlightDetails _outboundFlight, FlightDetails _returnFlight = null)
        {
            InitializeComponent();
            outboundFlight = _outboundFlight;
            returnFlight = _returnFlight;
            cabinType = _cabinType;
            passengerNum = _passengerNum;
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {
            if (passengerBox.Enabled)
            {
                if (!int.TryParse(txtPassport.Text, out int r))
                {
                    if (!btnAdd.Enabled)
                    {
                        btnAdd.Enabled = false;
                        MessageBox.Show("Passport number can only include digit number!");
                    }
                }
                else
                {
                    btnAdd.Enabled = true;
                }
            }
        }

        private void mtbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (passengerBox.Enabled)
            {
                if (!int.TryParse(mtbPhone.Text, out int r))
                {
                    if (!btnAdd.Enabled)
                    {
                        btnAdd.Enabled = false;
                        MessageBox.Show("Phone number can only include digit number!");
                    }
                }
                else
                {
                    btnAdd.Enabled = true;
                }
            }
        }

        private void BookingConfirmationForm_Load(object sender, EventArgs e)
        {
            GetSetOutbound();
            if (returnFlight != null)
            {
                GetSetReturn();
            }
            else
            {
                returnBox.Enabled = false;
            }

            GetSetCountry();

            dgvPassenger.DataSource = passengers;
            dtpBirthdate.MaxDate = DateTime.Now;
        }

        private void GetSetOutbound()
        {
            labelFromOutbound.Text = outboundFlight.From;
            labelToOutbound.Text = outboundFlight.To;
            labelDateOutbound.Text = outboundFlight.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            labelCabinOutbound.Text = cabinType;
            labelFlightOutbound.Text = outboundFlight.FlightNumber;
        }

        private void GetSetReturn()
        {
            labelFromReturn.Text = returnFlight.From;
            labelToReturn.Text = returnFlight.To;
            labelDateReturn.Text = returnFlight.Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            labelCabinReturn.Text = cabinType;
            labelFlightReturn.Text = returnFlight.FlightNumber;
        }

        private void GetSetCountry()
        {
            using (var db = new Session3Entities())
            {
                var q = db.Countries.Select(x => x.Name).ToList();
                cbPassport.DataSource = q;
            }
        }

        private bool IsAllFieldsNotEmpty()
        {
            foreach (var control in passengerBox.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        return false;
                    }
                }
                else if (control is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(((MaskedTextBox)control).Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void ClearFields()
        {
            foreach (var control in passengerBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Text = "";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsAllFieldsNotEmpty())
            {
                // Phone number length should be around 6 to 13 number digit
                if (mtbPhone.Text.Length - 2 > 5 && mtbPhone.Text.Length - 2 < 14 && mtbPhone.MaskCompleted)
                {
                    // Passport number length should be around 6 - 9 number digit
                    if (txtPassport.Text.Length > 5 && txtPassport.Text.Length < 10)
                    {
                        idCount++;
                        passengers.Add(new Passengers
                        {
                            ID = idCount,
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Birthdate = dtpBirthdate.Value.Date,
                            PassportNumber = txtPassport.Text,
                            PassportCountry = cbPassport.Text,
                            Phone = mtbPhone.Text
                        });

                        dgvPassenger.DataSource = passengers.ToList();
                        dgvPassenger.Columns["ID"].Visible = false;

                        passengerNum--;
                        if (passengerNum == 0)
                        {
                            passengerBox.Enabled = false;
                            btnConfirm.Enabled = true;
                        }

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("The length of the passport number should be around 6 - 9 number digit!");
                    }
                }
                else
                {
                    MessageBox.Show("The length of the phone number should be around 6 - 13 number digit!");
                }
            }
            else
            {
                MessageBox.Show("Please don't leave any fields empty");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var confirm = new BillingConfirmationForm(this);
            confirm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvPassenger.CurrentRow.Cells["ID"].Value.ToString());
            passengers.RemoveAll(x => x.ID == id);
            dgvPassenger.DataSource = passengers.ToList();
            passengerNum++;
            passengerBox.Enabled = true;
            btnConfirm.Enabled = false;
        }

        private void dgvPassenger_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (passengers.Count != 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }
    }
}