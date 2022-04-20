
namespace Project___Hotel_Management
{
    partial class ManageClientsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.addDBButton = new System.Windows.Forms.Button();
            this.editDBButton = new System.Windows.Forms.Button();
            this.removeDBButton = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addClassButton = new System.Windows.Forms.Button();
            this.exportFileButton = new System.Windows.Forms.Button();
            this.importFileButton = new System.Windows.Forms.Button();
            this.opTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeManageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(88, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(88, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "National ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(90, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(30, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(106, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 64);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manage Clients";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(268, 153);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(252, 26);
            this.IDTextBox.TabIndex = 5;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(268, 272);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(252, 26);
            this.lnameTextBox.TabIndex = 6;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(268, 213);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(252, 26);
            this.fnameTextBox.TabIndex = 7;
            this.fnameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(268, 331);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(252, 26);
            this.mobileTextBox.TabIndex = 8;
            // 
            // addDBButton
            // 
            this.addDBButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addDBButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDBButton.Location = new System.Drawing.Point(36, 542);
            this.addDBButton.Name = "addDBButton";
            this.addDBButton.Size = new System.Drawing.Size(159, 51);
            this.addDBButton.TabIndex = 9;
            this.addDBButton.Text = "Add";
            this.addDBButton.UseVisualStyleBackColor = false;
            this.addDBButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editDBButton
            // 
            this.editDBButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.editDBButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDBButton.Location = new System.Drawing.Point(372, 542);
            this.editDBButton.Name = "editDBButton";
            this.editDBButton.Size = new System.Drawing.Size(167, 51);
            this.editDBButton.TabIndex = 10;
            this.editDBButton.Text = "Edit";
            this.editDBButton.UseVisualStyleBackColor = false;
            this.editDBButton.Click += new System.EventHandler(this.editDBButton_Click);
            // 
            // removeDBButton
            // 
            this.removeDBButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.removeDBButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDBButton.Location = new System.Drawing.Point(201, 542);
            this.removeDBButton.Name = "removeDBButton";
            this.removeDBButton.Size = new System.Drawing.Size(165, 51);
            this.removeDBButton.TabIndex = 11;
            this.removeDBButton.Text = "Remove";
            this.removeDBButton.UseVisualStyleBackColor = false;
            this.removeDBButton.Click += new System.EventHandler(this.removeDBButton_Click);
            // 
            // clearFields
            // 
            this.clearFields.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clearFields.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFields.Location = new System.Drawing.Point(36, 599);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(197, 51);
            this.clearFields.TabIndex = 12;
            this.clearFields.Text = "Clear Fields";
            this.clearFields.UseVisualStyleBackColor = false;
            this.clearFields.Click += new System.EventHandler(this.button4_Click);
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(564, 124);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 62;
            this.clientsDataGridView.RowTemplate.Height = 28;
            this.clientsDataGridView.Size = new System.Drawing.Size(525, 527);
            this.clientsDataGridView.TabIndex = 13;
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(268, 387);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(252, 26);
            this.emailTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(161, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // addClassButton
            // 
            this.addClassButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addClassButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClassButton.Location = new System.Drawing.Point(600, 54);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(147, 51);
            this.addClassButton.TabIndex = 16;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = false;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // exportFileButton
            // 
            this.exportFileButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exportFileButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileButton.Location = new System.Drawing.Point(906, 54);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(147, 51);
            this.exportFileButton.TabIndex = 17;
            this.exportFileButton.Text = "Export File";
            this.exportFileButton.UseVisualStyleBackColor = false;
            this.exportFileButton.Click += new System.EventHandler(this.exportFileButton_Click);
            // 
            // importFileButton
            // 
            this.importFileButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.importFileButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFileButton.Location = new System.Drawing.Point(753, 54);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(147, 51);
            this.importFileButton.TabIndex = 18;
            this.importFileButton.Text = "Import File";
            this.importFileButton.UseVisualStyleBackColor = false;
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // opTextBox
            // 
            this.opTextBox.Location = new System.Drawing.Point(268, 495);
            this.opTextBox.Name = "opTextBox";
            this.opTextBox.Size = new System.Drawing.Size(252, 26);
            this.opTextBox.TabIndex = 20;
            this.opTextBox.TextChanged += new System.EventHandler(this.opTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(88, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 39);
            this.label7.TabIndex = 19;
            this.label7.Text = "INSERT ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeManageClientsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // closeManageClientsToolStripMenuItem
            // 
            this.closeManageClientsToolStripMenuItem.Name = "closeManageClientsToolStripMenuItem";
            this.closeManageClientsToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.closeManageClientsToolStripMenuItem.Text = "Close Manage Clients";
            this.closeManageClientsToolStripMenuItem.Click += new System.EventHandler(this.closeManageClientsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.removeSelectedButton.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedButton.Location = new System.Drawing.Point(239, 599);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(300, 51);
            this.removeSelectedButton.TabIndex = 22;
            this.removeSelectedButton.Text = "Remove Selected Records";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project___Hotel_Management.Properties.Resources.clients1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 677);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.opTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.clearFields);
            this.Controls.Add(this.removeDBButton);
            this.Controls.Add(this.editDBButton);
            this.Controls.Add(this.addDBButton);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageClientsForm";
            this.Text = "Manage Clients";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Button addDBButton;
        private System.Windows.Forms.Button editDBButton;
        private System.Windows.Forms.Button removeDBButton;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button exportFileButton;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.TextBox opTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeManageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button removeSelectedButton;
    }
}