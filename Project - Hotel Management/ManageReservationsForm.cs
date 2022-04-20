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
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text);
            string roomType = typeComboBox.SelectedValue.ToString();
            int roomNO = int.Parse(roomNoTextbox.Text);

            string extraServices;
            if (yesRadioButton.Checked)
            {
                extraServices = "YES";
            }
            else if (NoRadioButton.Checked)
            {
                extraServices = "NO";
            }

            //DateTimePicker control
            DateTime checkIN = this.checkINDate.Value;
            DateTime checkOUT = checkOUTDate.Value;

            string inDate = checkIN.ToShortDateString();
            string outDate = checkOUT.ToShortDateString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {

        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
