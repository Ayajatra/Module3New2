namespace Module3New2
{
    partial class SearchForFlightForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpOutbound = new System.Windows.Forms.DateTimePicker();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbReturn = new System.Windows.Forms.RadioButton();
            this.cbCabin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.dgvOutbound = new System.Windows.Forms.DataGridView();
            this.nudPassenger = new System.Windows.Forms.NumericUpDown();
            this.labelOutbound = new System.Windows.Forms.Label();
            this.cbOutbound = new System.Windows.Forms.CheckBox();
            this.labelReturn = new System.Windows.Forms.Label();
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.confirmBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.confirmBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.dtpReturn);
            this.groupBox1.Controls.Add(this.dtpOutbound);
            this.groupBox1.Controls.Add(this.rbOne);
            this.groupBox1.Controls.Add(this.rbReturn);
            this.groupBox1.Controls.Add(this.cbCabin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(755, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(673, 86);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(74, 47);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "dd/MM/yyyy";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(537, 91);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(128, 25);
            this.dtpReturn.TabIndex = 6;
            // 
            // dtpOutbound
            // 
            this.dtpOutbound.CustomFormat = "dd/MM/yyyy";
            this.dtpOutbound.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutbound.Location = new System.Drawing.Point(315, 91);
            this.dtpOutbound.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOutbound.Name = "dtpOutbound";
            this.dtpOutbound.Size = new System.Drawing.Size(128, 25);
            this.dtpOutbound.TabIndex = 5;
            this.dtpOutbound.ValueChanged += new System.EventHandler(this.dtpOutbound_ValueChanged);
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(97, 94);
            this.rbOne.Margin = new System.Windows.Forms.Padding(4);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(91, 23);
            this.rbOne.TabIndex = 4;
            this.rbOne.Text = "One Way";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // rbReturn
            // 
            this.rbReturn.AutoSize = true;
            this.rbReturn.Checked = true;
            this.rbReturn.Location = new System.Drawing.Point(23, 94);
            this.rbReturn.Margin = new System.Windows.Forms.Padding(4);
            this.rbReturn.Name = "rbReturn";
            this.rbReturn.Size = new System.Drawing.Size(66, 23);
            this.rbReturn.TabIndex = 3;
            this.rbReturn.TabStop = true;
            this.rbReturn.Text = "Return";
            this.rbReturn.UseVisualStyleBackColor = true;
            this.rbReturn.CheckedChanged += new System.EventHandler(this.rbReturn_CheckedChanged);
            // 
            // cbCabin
            // 
            this.cbCabin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCabin.FormattingEnabled = true;
            this.cbCabin.Location = new System.Drawing.Point(564, 35);
            this.cbCabin.Margin = new System.Windows.Forms.Padding(4);
            this.cbCabin.Name = "cbCabin";
            this.cbCabin.Size = new System.Drawing.Size(101, 27);
            this.cbCabin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cabin Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Return";
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(295, 35);
            this.cbTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(101, 27);
            this.cbTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Outbound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "To";
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(71, 35);
            this.cbFrom.Margin = new System.Windows.Forms.Padding(4);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(101, 27);
            this.cbFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(220, 18);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(100, 34);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // dgvOutbound
            // 
            this.dgvOutbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutbound.Location = new System.Drawing.Point(13, 194);
            this.dgvOutbound.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOutbound.MultiSelect = false;
            this.dgvOutbound.Name = "dgvOutbound";
            this.dgvOutbound.ReadOnly = true;
            this.dgvOutbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutbound.Size = new System.Drawing.Size(755, 130);
            this.dgvOutbound.TabIndex = 2;
            this.dgvOutbound.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvOutbound_RowStateChanged);
            // 
            // nudPassenger
            // 
            this.nudPassenger.Location = new System.Drawing.Point(29, 23);
            this.nudPassenger.Margin = new System.Windows.Forms.Padding(4);
            this.nudPassenger.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPassenger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassenger.Name = "nudPassenger";
            this.nudPassenger.Size = new System.Drawing.Size(81, 25);
            this.nudPassenger.TabIndex = 0;
            this.nudPassenger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelOutbound
            // 
            this.labelOutbound.AutoSize = true;
            this.labelOutbound.Location = new System.Drawing.Point(13, 171);
            this.labelOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutbound.Name = "labelOutbound";
            this.labelOutbound.Size = new System.Drawing.Size(156, 19);
            this.labelOutbound.TabIndex = 0;
            this.labelOutbound.Text = "Outbound flight details:";
            // 
            // cbOutbound
            // 
            this.cbOutbound.AutoSize = true;
            this.cbOutbound.Location = new System.Drawing.Point(511, 170);
            this.cbOutbound.Name = "cbOutbound";
            this.cbOutbound.Size = new System.Drawing.Size(257, 23);
            this.cbOutbound.TabIndex = 1;
            this.cbOutbound.Text = "Display three days before and after";
            this.cbOutbound.UseVisualStyleBackColor = true;
            this.cbOutbound.CheckedChanged += new System.EventHandler(this.cbOutbound_CheckedChanged);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Location = new System.Drawing.Point(13, 337);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(132, 19);
            this.labelReturn.TabIndex = 0;
            this.labelReturn.Text = "Return flight details:";
            // 
            // dgvReturn
            // 
            this.dgvReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Location = new System.Drawing.Point(13, 366);
            this.dgvReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReturn.MultiSelect = false;
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.ReadOnly = true;
            this.dgvReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturn.Size = new System.Drawing.Size(755, 130);
            this.dgvReturn.TabIndex = 4;
            this.dgvReturn.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvOutbound_RowStateChanged);
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(511, 336);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(257, 23);
            this.cbReturn.TabIndex = 3;
            this.cbReturn.Text = "Display three days before and after";
            this.cbReturn.UseVisualStyleBackColor = true;
            this.cbReturn.CheckedChanged += new System.EventHandler(this.cbReturn_CheckedChanged);
            // 
            // confirmBox
            // 
            this.confirmBox.Controls.Add(this.nudPassenger);
            this.confirmBox.Controls.Add(this.btnBook);
            this.confirmBox.Controls.Add(this.label8);
            this.confirmBox.Enabled = false;
            this.confirmBox.Location = new System.Drawing.Point(226, 503);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(333, 59);
            this.confirmBox.TabIndex = 5;
            this.confirmBox.TabStop = false;
            this.confirmBox.Text = "Confirm booking for";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Passenger";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(566, 521);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SearchForFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbReturn);
            this.Controls.Add(this.cbOutbound);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.dgvOutbound);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelOutbound);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForFlightForm";
            this.Text = "SearchForFlight";
            this.Load += new System.EventHandler(this.SearchForFlightForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.confirmBox.ResumeLayout(false);
            this.confirmBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpOutbound;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.RadioButton rbReturn;
        private System.Windows.Forms.ComboBox cbCabin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.DataGridView dgvOutbound;
        private System.Windows.Forms.NumericUpDown nudPassenger;
        private System.Windows.Forms.Label labelOutbound;
        private System.Windows.Forms.CheckBox cbOutbound;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.GroupBox confirmBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
    }
}

