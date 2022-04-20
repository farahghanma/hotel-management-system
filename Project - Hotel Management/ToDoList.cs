using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Hotel_Management
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            todoListBox1.Items.Add(taskstextBox.Text);
            taskstextBox.Text = ""; //this just simply clears textbox for convenience
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (todoListBox1.SelectedIndex != -1)
            {
                todoListBox1.Items.RemoveAt(todoListBox1.SelectedIndex);
            }

            else
            {
                MessageBox.Show("You must select a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            todoListBox1.Items.Clear();
        }

        private void taskstextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
