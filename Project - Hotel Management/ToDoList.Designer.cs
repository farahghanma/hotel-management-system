
namespace Project___Hotel_Management
{
    partial class ToDoList
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
            this.todoListBox1 = new System.Windows.Forms.CheckedListBox();
            this.taskstextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox1
            // 
            this.todoListBox1.FormattingEnabled = true;
            this.todoListBox1.Items.AddRange(new object[] {
            "Check vacancies",
            "Salute customers",
            "Offer towels and juice to lobby customers",
            "Call customers to double check reservations "});
            this.todoListBox1.Location = new System.Drawing.Point(100, 155);
            this.todoListBox1.Name = "todoListBox1";
            this.todoListBox1.Size = new System.Drawing.Size(425, 257);
            this.todoListBox1.TabIndex = 0;
            this.todoListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // taskstextBox
            // 
            this.taskstextBox.Location = new System.Drawing.Point(546, 211);
            this.taskstextBox.Multiline = true;
            this.taskstextBox.Name = "taskstextBox";
            this.taskstextBox.Size = new System.Drawing.Size(406, 179);
            this.taskstextBox.TabIndex = 1;
            this.taskstextBox.TextChanged += new System.EventHandler(this.taskstextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(381, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 64);
            this.label5.TabIndex = 25;
            this.label5.Text = "TO-DO LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(617, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 39);
            this.label2.TabIndex = 26;
            this.label2.Text = "ENTER TASK HERE";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 76);
            this.button3.TabIndex = 29;
            this.button3.Text = "Remove Task";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(392, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 76);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear Tasks";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 76);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project___Hotel_Management.Properties.Resources.to_do;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taskstextBox);
            this.Controls.Add(this.todoListBox1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox todoListBox1;
        private System.Windows.Forms.TextBox taskstextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}