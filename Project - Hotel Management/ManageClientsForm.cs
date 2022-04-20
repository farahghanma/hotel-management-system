using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace Project___Hotel_Management
{

    public partial class ManageClientsForm : Form
    {
        SQLiteConnection clientsSQL;

        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void load_Data()
        {
            string sql = "SELECT * FROM ManageClients order by nationalID desc";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, clientsSQL);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clientsDataGridView.DataSource = ds.Tables[0];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id, mobile;
            string fname, lname, email;

            try
            {
                id = int.Parse(IDTextBox.Text);
                fname = fnameTextBox.Text;
                lname = lnameTextBox.Text;
                mobile = int.Parse(mobileTextBox.Text);
                email = emailTextBox.Text;

                string sql;
                sql = "INSERT INTO ManageClients (nationalID, firstName, lastName, mobile, email) values ('" + id + "', '" + fname + "', '" + lname + "', '" + mobile + "', '" + email + "')";

                SQLiteCommand command = new SQLiteCommand(sql, clientsSQL);
                int insertedRecords = command.ExecuteNonQuery();
                MessageBox.Show("Client was added successfully", "Adding Clients");
            }

            //if value was casted incorrectly 
            //Ex. if parsing failed, FormatException handles that error -> inserting string instead of int for example
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if value is null
            //Ex. attempting to use a null reference
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //deals with different input and output exceptions
            //Ex. when the user inputs improper data into the program
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*EXTRA NOTE: WE CAN USE catch (Exception) TO DEAL WITH ANY TYPE OF EXCEPTION*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            fnameTextBox.Text = "";
            lnameTextBox.Text = "";
            mobileTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            clientsSQL = new SQLiteConnection("Data Source=Hotel-Management.sqlite;Version=3;");
            clientsSQL.Open();

            string sql = "SELECT * FROM ManageClients order by nationalID desc";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, clientsSQL);
            DataSet ds = new DataSet();
            da.Fill(ds);
            clientsDataGridView.DataSource = ds.Tables[0];
            //returns the first table from the table collection in the dataset
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTextBox.Text);
            string fname = fnameTextBox.Text;
            string lname = lnameTextBox.Text;
            int mobile = int.Parse(mobileTextBox.Text);
            string email = emailTextBox.Text;

            //setting the values of the new Client object by using the constructor
            Client newClient = new Client(id, fname, lname, mobile, email);

            //to display properties, I'll be using getters
            string info = $"National ID: {newClient.NationalID}\nFirst and Last Name: {newClient.FirstName} {newClient.LastName}\nMobile: {newClient.Mobile}\nEmail: {newClient.Email}";

            //to change a property, simply call the setter and give it the new value
            newClient.Email = "farah@yahoo.com";

            //showing properties
            MessageBox.Show($"New Clinet Created!\n\nInfo:\n{info}", "New Client Object");

            //this is just extra - adding the class information to the database - using getters to set the values
            string sql;
            sql = "INSERT INTO ManageClients (nationalID, firstName, lastName, mobile, email) values ('" + newClient.NationalID + "', '" + newClient.FirstName + "', '" + newClient.LastName + "', '" + newClient.Mobile + "', '" + newClient.Email + "')";

            SQLiteCommand command = new SQLiteCommand(sql, clientsSQL);
            int insertedRecords = command.ExecuteNonQuery();
            MessageBox.Show("Client was added successfully", "Adding Clients");
        }

        private void editDBButton_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ManageClients SET mobile = '" + mobileTextBox.Text + "' WHERE nationalID = " + opTextBox.Text + ";";
            SQLiteCommand command = new SQLiteCommand(sql, clientsSQL);
            command.ExecuteNonQuery();
            load_Data();

            MessageBox.Show("Mobile Number was updated successfully", "Updating Mobile Number");
            opTextBox.Text = "";
            mobileTextBox.Text = "";
        }

        private void removeDBButton_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ManageClients WHERE nationalID = " + opTextBox.Text + ";";
            SQLiteCommand command = new SQLiteCommand(sql, clientsSQL);
            int affectedRecords = command.ExecuteNonQuery();
            load_Data();

            MessageBox.Show("Client was deleted successfully", "Deleting Clients");
            opTextBox.Text = "";
        }

        private void importFileButton_Click(object sender, EventArgs e)
        {
            //this button reads a file (found in debug file) and adds the records to the database 
            //each 5 rows in the file belong to 1 record 
            //id -> first name -> last name -> mobile -> email
            StreamReader import = new StreamReader("ExportRecords.txt");
            int id;
            int mobile;
            string fname, lname, email;

            while (!import.EndOfStream) //as long as we didn't get to the end of the line -> enter loop
            {
                id = int.Parse(import.ReadLine());
                fname = import.ReadLine();
                lname = import.ReadLine();
                mobile = int.Parse(import.ReadLine());
                email = import.ReadLine();

                //adding information above to database
                string sql;
                sql = "INSERT INTO ManageClients (nationalID, firstName, lastName, mobile, email) values ('" + id + "', '" + fname + "', '" + lname + "', '" + mobile + "', '" + email + "')";

                SQLiteCommand command = new SQLiteCommand(sql, clientsSQL);
                int insertedRecords = command.ExecuteNonQuery();
            }

            MessageBox.Show("File was imported successfully", "Importing File");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void opTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeManageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportFileButton_Click(object sender, EventArgs e)
        {
            var Records = new StreamWriter("Records.txt");

            for (int i = 0; i < clientsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < clientsDataGridView.Columns.Count; j++)
                {
                    Records.Write(" " + clientsDataGridView.Rows[i].Cells[j].Value.ToString() + " | ");
                }
                Records.WriteLine("\n------------------------\n");
            }
            Records.Close();
            MessageBox.Show("Files Exported Successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            //this button deletes SELECTED rows
            //instead of typing the nationalID you want to delete, you select the rows and delete them directly

            foreach (DataGridViewRow row in clientsDataGridView.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() != null)
                {
                    clientsDataGridView.Rows.Remove(row);
                }
            }
        }
    }
}
