
namespace Project___Hotel_Management
{
    partial class ManageReservationsForm
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearFields = new System.Windows.Forms.Button();
            this.removeReservation = new System.Windows.Forms.Button();
            this.editReservation = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkOUTDate = new System.Windows.Forms.DateTimePicker();
            this.roomNoTextbox = new System.Windows.Forms.TextBox();
            this.reserveDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.checkINDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Tentative ",
            "Confirmed ",
            "Waiting-List"});
            this.typeComboBox.Location = new System.Drawing.Point(270, 154);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(300, 28);
            this.typeComboBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(57, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 64);
            this.label5.TabIndex = 38;
            this.label5.Text = "Manage Reservations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(270, 102);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(300, 26);
            this.IDTextBox.TabIndex = 37;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Reservation ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(82, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Room Type";
            // 
            // clearFields
            // 
            this.clearFields.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearFields.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFields.Location = new System.Drawing.Point(105, 488);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(453, 51);
            this.clearFields.TabIndex = 32;
            this.clearFields.Text = "Clear Fields";
            this.clearFields.UseVisualStyleBackColor = false;
            // 
            // removeReservation
            // 
            this.removeReservation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.removeReservation.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeReservation.Location = new System.Drawing.Point(258, 431);
            this.removeReservation.Name = "removeReservation";
            this.removeReservation.Size = new System.Drawing.Size(147, 51);
            this.removeReservation.TabIndex = 31;
            this.removeReservation.Text = "Remove";
            this.removeReservation.UseVisualStyleBackColor = false;
            // 
            // editReservation
            // 
            this.editReservation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.editReservation.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReservation.Location = new System.Drawing.Point(411, 431);
            this.editReservation.Name = "editReservation";
            this.editReservation.Size = new System.Drawing.Size(147, 51);
            this.editReservation.TabIndex = 30;
            this.editReservation.Text = "Edit ";
            this.editReservation.UseVisualStyleBackColor = false;
            // 
            // addReservation
            // 
            this.addReservation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addReservation.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservation.Location = new System.Drawing.Point(105, 431);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(147, 51);
            this.addReservation.TabIndex = 29;
            this.addReservation.Text = "Add";
            this.addReservation.UseVisualStyleBackColor = false;
            this.addReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(97, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 39);
            this.label3.TabIndex = 40;
            this.label3.Text = "Room NO.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(116, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 39);
            this.label4.TabIndex = 42;
            this.label4.Text = "Check-IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(84, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 39);
            this.label6.TabIndex = 43;
            this.label6.Text = "Check-OUT";
            // 
            // checkOUTDate
            // 
            this.checkOUTDate.Location = new System.Drawing.Point(270, 366);
            this.checkOUTDate.Name = "checkOUTDate";
            this.checkOUTDate.Size = new System.Drawing.Size(300, 26);
            this.checkOUTDate.TabIndex = 45;
            // 
            // roomNoTextbox
            // 
            this.roomNoTextbox.Location = new System.Drawing.Point(270, 206);
            this.roomNoTextbox.Name = "roomNoTextbox";
            this.roomNoTextbox.Size = new System.Drawing.Size(300, 26);
            this.roomNoTextbox.TabIndex = 46;
            // 
            // reserveDataGridView
            // 
            this.reserveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveDataGridView.Location = new System.Drawing.Point(598, 43);
            this.reserveDataGridView.Name = "reserveDataGridView";
            this.reserveDataGridView.RowHeadersWidth = 62;
            this.reserveDataGridView.RowTemplate.Height = 28;
            this.reserveDataGridView.Size = new System.Drawing.Size(470, 483);
            this.reserveDataGridView.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(42, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 39);
            this.label7.TabIndex = 48;
            this.label7.Text = "Extra Services";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.yesRadioButton);
            this.groupBox1.Controls.Add(this.NoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(270, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 65);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRadioButton.Location = new System.Drawing.Point(6, 22);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(66, 26);
            this.yesRadioButton.TabIndex = 25;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "YES";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRadioButton.Location = new System.Drawing.Point(98, 22);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(61, 26);
            this.NoRadioButton.TabIndex = 26;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "NO";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkINDate
            // 
            this.checkINDate.Location = new System.Drawing.Point(270, 312);
            this.checkINDate.Name = "checkINDate";
            this.checkINDate.Size = new System.Drawing.Size(300, 26);
            this.checkINDate.TabIndex = 27;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project___Hotel_Management.Properties.Resources.reservations;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 559);
            this.Controls.Add(this.checkINDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reserveDataGridView);
            this.Controls.Add(this.roomNoTextbox);
            this.Controls.Add(this.checkOUTDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.removeReservation);
            this.Controls.Add(this.editReservation);
            this.Controls.Add(this.addReservation);
            this.Name = "ManageReservationsForm";
            this.Text = "Manage Reservations";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button removeReservation;
        private System.Windows.Forms.Button editReservation;
        private System.Windows.Forms.Button addReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkOUTDate;
        private System.Windows.Forms.TextBox roomNoTextbox;
        private System.Windows.Forms.DataGridView reserveDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.DateTimePicker checkINDate;
    }
}