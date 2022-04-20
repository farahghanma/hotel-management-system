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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm clients = new ManageClientsForm();
            clients.ShowDialog();
        }

        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationsForm reserve = new ManageReservationsForm();
            reserve.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm rooms = new ManageRoomsForm();
            rooms.ShowDialog();
        }

        private void tODOListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDoList todoList = new ToDoList();
            todoList.ShowDialog();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics Obj;
            Obj = this.CreateGraphics();

            Pen Pen = new Pen(System.Drawing.Color.Black, 5);

            Pen.Color = System.Drawing.Color.Beige;
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Rectangle myRectangle = new Rectangle(190, 70, 300, 250);
            Obj.DrawRectangle(Pen, myRectangle);

            Font Font = new System.Drawing.Font("MS Reference Sans Serif", 15, FontStyle.Regular);
            Brush Brush = new SolidBrush(System.Drawing.Color.RosyBrown);
            Obj.DrawString("Welcome To The Hotel", Font, Brush, 225, 80);

            Image Image = Image.FromFile(@"C:\Users\Farah Ghanma\source\repos\Project - Hotel Management\Project - Hotel Management\Resources\pic (1).png");
            Obj.DrawImage(Image, 210, 130, 250, 150);
        }

    }
}
