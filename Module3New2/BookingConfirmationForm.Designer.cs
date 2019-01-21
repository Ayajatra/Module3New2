namespace Module3New2
{
    partial class BookingConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outboundBox = new System.Windows.Forms.GroupBox();
            this.labelFlightOutbound = new System.Windows.Forms.Label();
            this.labelDateOutbound = new System.Windows.Forms.Label();
            this.labelCabinOutbound = new System.Windows.Forms.Label();
            this.labelToOutbound = new System.Windows.Forms.Label();
            this.labelFromOutbound = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cbPassport = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.passengerBox = new System.Windows.Forms.GroupBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnBox = new System.Windows.Forms.GroupBox();
            this.labelFlightReturn = new System.Windows.Forms.Label();
            this.labelDateReturn = new System.Windows.Forms.Label();
            this.labelCabinReturn = new System.Windows.Forms.Label();
            this.labelToReturn = new System.Windows.Forms.Label();
            this.labelFromReturn = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labeCabin = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.outboundBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            this.passengerBox.SuspendLayout();
            this.returnBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outboundBox
            // 
            this.outboundBox.Controls.Add(this.labelFlightOutbound);
            this.outboundBox.Controls.Add(this.labelDateOutbound);
            this.outboundBox.Controls.Add(this.labelCabinOutbound);
            this.outboundBox.Controls.Add(this.labelToOutbound);
            this.outboundBox.Controls.Add(this.labelFromOutbound);
            this.outboundBox.Controls.Add(this.label9);
            this.outboundBox.Controls.Add(this.label7);
            this.outboundBox.Controls.Add(this.label5);
            this.outboundBox.Controls.Add(this.label3);
            this.outboundBox.Controls.Add(this.label1);
            this.outboundBox.Location = new System.Drawing.Point(16, 15);
            this.outboundBox.Margin = new System.Windows.Forms.Padding(4);
            this.outboundBox.Name = "outboundBox";
            this.outboundBox.Padding = new System.Windows.Forms.Padding(4);
            this.outboundBox.Size = new System.Drawing.Size(745, 77);
            this.outboundBox.TabIndex = 0;
            this.outboundBox.TabStop = false;
            this.outboundBox.Text = "Outbound flight details";
            // 
            // labelFlightOutbound
            // 
            this.labelFlightOutbound.AutoSize = true;
            this.labelFlightOutbound.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightOutbound.Location = new System.Drawing.Point(670, 32);
            this.labelFlightOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlightOutbound.Name = "labelFlightOutbound";
            this.labelFlightOutbound.Size = new System.Drawing.Size(56, 17);
            this.labelFlightOutbound.TabIndex = 0;
            this.labelFlightOutbound.Text = "number";
            // 
            // labelDateOutbound
            // 
            this.labelDateOutbound.AutoSize = true;
            this.labelDateOutbound.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOutbound.Location = new System.Drawing.Point(475, 32);
            this.labelDateOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOutbound.Name = "labelDateOutbound";
            this.labelDateOutbound.Size = new System.Drawing.Size(35, 17);
            this.labelDateOutbound.TabIndex = 0;
            this.labelDateOutbound.Text = "date";
            // 
            // labelCabinOutbound
            // 
            this.labelCabinOutbound.AutoSize = true;
            this.labelCabinOutbound.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabinOutbound.Location = new System.Drawing.Point(347, 32);
            this.labelCabinOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCabinOutbound.Name = "labelCabinOutbound";
            this.labelCabinOutbound.Size = new System.Drawing.Size(73, 17);
            this.labelCabinOutbound.TabIndex = 0;
            this.labelCabinOutbound.Text = "cabin type";
            // 
            // labelToOutbound
            // 
            this.labelToOutbound.AutoSize = true;
            this.labelToOutbound.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToOutbound.Location = new System.Drawing.Point(195, 32);
            this.labelToOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToOutbound.Name = "labelToOutbound";
            this.labelToOutbound.Size = new System.Drawing.Size(20, 17);
            this.labelToOutbound.TabIndex = 0;
            this.labelToOutbound.Text = "to";
            // 
            // labelFromOutbound
            // 
            this.labelFromOutbound.AutoSize = true;
            this.labelFromOutbound.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromOutbound.Location = new System.Drawing.Point(68, 32);
            this.labelFromOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFromOutbound.Name = "labelFromOutbound";
            this.labelFromOutbound.Size = new System.Drawing.Size(38, 17);
            this.labelFromOutbound.TabIndex = 0;
            this.labelFromOutbound.Text = "from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Flight Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cabin Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 24);
            this.txtFirstName.TabIndex = 0;
            // 
            // cbPassport
            // 
            this.cbPassport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPassport.FormattingEnabled = true;
            this.cbPassport.Location = new System.Drawing.Point(432, 68);
            this.cbPassport.Margin = new System.Windows.Forms.Padding(4);
            this.cbPassport.Name = "cbPassport";
            this.cbPassport.Size = new System.Drawing.Size(158, 25);
            this.cbPassport.TabIndex = 3;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdate.Location = new System.Drawing.Point(430, 111);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(160, 24);
            this.dtpBirthdate.TabIndex = 4;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Culture = new System.Globalization.CultureInfo("");
            this.mtbPhone.Location = new System.Drawing.Point(430, 146);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mtbPhone.Mask = "+00 00000099999";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(160, 24);
            this.mtbPhone.TabIndex = 5;
            this.mtbPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPhone_MaskInputRejected);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(598, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add passenger";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.Location = new System.Drawing.Point(16, 430);
            this.dgvPassenger.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassenger.Size = new System.Drawing.Size(745, 196);
            this.dgvPassenger.TabIndex = 1;
            this.dgvPassenger.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvPassenger_RowStateChanged);
            // 
            // passengerBox
            // 
            this.passengerBox.Controls.Add(this.dtpBirthdate);
            this.passengerBox.Controls.Add(this.cbPassport);
            this.passengerBox.Controls.Add(this.mtbPhone);
            this.passengerBox.Controls.Add(this.txtPassport);
            this.passengerBox.Controls.Add(this.btnAdd);
            this.passengerBox.Controls.Add(this.label14);
            this.passengerBox.Controls.Add(this.label10);
            this.passengerBox.Controls.Add(this.label6);
            this.passengerBox.Controls.Add(this.txtLastName);
            this.passengerBox.Controls.Add(this.txtFirstName);
            this.passengerBox.Controls.Add(this.label13);
            this.passengerBox.Controls.Add(this.label8);
            this.passengerBox.Controls.Add(this.label4);
            this.passengerBox.Location = new System.Drawing.Point(16, 211);
            this.passengerBox.Margin = new System.Windows.Forms.Padding(4);
            this.passengerBox.Name = "passengerBox";
            this.passengerBox.Padding = new System.Windows.Forms.Padding(4);
            this.passengerBox.Size = new System.Drawing.Size(745, 190);
            this.passengerBox.TabIndex = 0;
            this.passengerBox.TabStop = false;
            this.passengerBox.Text = "Passenger details";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(135, 68);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(132, 24);
            this.txtPassport.TabIndex = 1;
            this.txtPassport.TextChanged += new System.EventHandler(this.txtPassport_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 149);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Passport country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Passport number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(432, 36);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 24);
            this.txtLastName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firstname";
            // 
            // returnBox
            // 
            this.returnBox.Controls.Add(this.labelFlightReturn);
            this.returnBox.Controls.Add(this.labelDateReturn);
            this.returnBox.Controls.Add(this.labelCabinReturn);
            this.returnBox.Controls.Add(this.labelToReturn);
            this.returnBox.Controls.Add(this.labelFromReturn);
            this.returnBox.Controls.Add(this.label11);
            this.returnBox.Controls.Add(this.label12);
            this.returnBox.Controls.Add(this.labeCabin);
            this.returnBox.Controls.Add(this.labelTo);
            this.returnBox.Controls.Add(this.label);
            this.returnBox.Location = new System.Drawing.Point(16, 111);
            this.returnBox.Margin = new System.Windows.Forms.Padding(4);
            this.returnBox.Name = "returnBox";
            this.returnBox.Padding = new System.Windows.Forms.Padding(4);
            this.returnBox.Size = new System.Drawing.Size(745, 77);
            this.returnBox.TabIndex = 0;
            this.returnBox.TabStop = false;
            this.returnBox.Text = "Return flight details";
            // 
            // labelFlightReturn
            // 
            this.labelFlightReturn.AutoSize = true;
            this.labelFlightReturn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlightReturn.Location = new System.Drawing.Point(670, 32);
            this.labelFlightReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFlightReturn.Name = "labelFlightReturn";
            this.labelFlightReturn.Size = new System.Drawing.Size(56, 17);
            this.labelFlightReturn.TabIndex = 0;
            this.labelFlightReturn.Text = "number";
            // 
            // labelDateReturn
            // 
            this.labelDateReturn.AutoSize = true;
            this.labelDateReturn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateReturn.Location = new System.Drawing.Point(475, 32);
            this.labelDateReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateReturn.Name = "labelDateReturn";
            this.labelDateReturn.Size = new System.Drawing.Size(35, 17);
            this.labelDateReturn.TabIndex = 0;
            this.labelDateReturn.Text = "date";
            // 
            // labelCabinReturn
            // 
            this.labelCabinReturn.AutoSize = true;
            this.labelCabinReturn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabinReturn.Location = new System.Drawing.Point(347, 32);
            this.labelCabinReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCabinReturn.Name = "labelCabinReturn";
            this.labelCabinReturn.Size = new System.Drawing.Size(73, 17);
            this.labelCabinReturn.TabIndex = 0;
            this.labelCabinReturn.Text = "cabin type";
            // 
            // labelToReturn
            // 
            this.labelToReturn.AutoSize = true;
            this.labelToReturn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToReturn.Location = new System.Drawing.Point(195, 32);
            this.labelToReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToReturn.Name = "labelToReturn";
            this.labelToReturn.Size = new System.Drawing.Size(20, 17);
            this.labelToReturn.TabIndex = 0;
            this.labelToReturn.Text = "to";
            // 
            // labelFromReturn
            // 
            this.labelFromReturn.AutoSize = true;
            this.labelFromReturn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromReturn.Location = new System.Drawing.Point(68, 32);
            this.labelFromReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFromReturn.Name = "labelFromReturn";
            this.labelFromReturn.Size = new System.Drawing.Size(38, 17);
            this.labelFromReturn.TabIndex = 0;
            this.labelFromReturn.Text = "from";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(574, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Flight Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Date:";
            // 
            // labeCabin
            // 
            this.labeCabin.AutoSize = true;
            this.labeCabin.Location = new System.Drawing.Point(258, 32);
            this.labeCabin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeCabin.Name = "labeCabin";
            this.labeCabin.Size = new System.Drawing.Size(81, 17);
            this.labeCabin.TabIndex = 0;
            this.labeCabin.Text = "Cabin Type:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(161, 32);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(26, 17);
            this.labelTo.TabIndex = 0;
            this.labelTo.Text = "To:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 32);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 17);
            this.label.TabIndex = 0;
            this.label.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Passengers list";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(202, 652);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to search for flights";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(386, 652);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(132, 36);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(593, 634);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(168, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove passenger";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BookingConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 701);
            this.Controls.Add(this.dgvPassenger);
            this.Controls.Add(this.passengerBox);
            this.Controls.Add(this.returnBox);
            this.Controls.Add(this.outboundBox);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingConfirmationForm";
            this.Text = "BookingConfirmationForm";
            this.Load += new System.EventHandler(this.BookingConfirmationForm_Load);
            this.outboundBox.ResumeLayout(false);
            this.outboundBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            this.passengerBox.ResumeLayout(false);
            this.passengerBox.PerformLayout();
            this.returnBox.ResumeLayout(false);
            this.returnBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox outboundBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.ComboBox cbPassport;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox passengerBox;
        private System.Windows.Forms.Label labelFlightOutbound;
        private System.Windows.Forms.Label labelDateOutbound;
        private System.Windows.Forms.Label labelCabinOutbound;
        private System.Windows.Forms.Label labelToOutbound;
        private System.Windows.Forms.Label labelFromOutbound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox returnBox;
        private System.Windows.Forms.Label labelFlightReturn;
        private System.Windows.Forms.Label labelDateReturn;
        private System.Windows.Forms.Label labelCabinReturn;
        private System.Windows.Forms.Label labelToReturn;
        private System.Windows.Forms.Label labelFromReturn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labeCabin;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.DataGridView dgvPassenger;
    }
}