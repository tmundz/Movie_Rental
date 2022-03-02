using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class Reports : Form
    {
        public static String current_screen;
        public Reports()
        {
            InitializeComponent();

            ChooseScreen.Text = "--Select A Screen--";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (ChooseScreen.SelectedItem != null)
            {
                if (ChooseScreen.SelectedItem.ToString() != "--Select A Screen--")
                {
                    current_screen = ChooseScreen.SelectedItem.ToString();
                    HelpScreen help = new HelpScreen(current_screen);
                    help.Show();
                }
            }
        }

        private void movies2_Click(object sender, EventArgs e)
        {
            movieinfo page = new movieinfo();
            page.Show();
            this.Hide();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customer page2 = new customer();
            page2.Show();
            this.Hide();
        }

        private void rental_Click(object sender, EventArgs e)
        {
            RentalScreen page3 = new RentalScreen();
            page3.Show();
            this.Hide();
        }

        private void actors_Click(object sender, EventArgs e)
        {
            actorinfo page4 = new actorinfo();
            page4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports page5 = new Reports();
            page5.Show();
            this.Hide();
        }

        private void employee2_Click(object sender, EventArgs e)
        {
            Employee page6 = new Employee();
            page6.Show();
            this.Hide();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            Customerlogin page7 = new Customerlogin();
            page7.Show();
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
