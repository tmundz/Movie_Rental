using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class RentalScreen : Form
    {
        public static String current_screen;
        public static int current_ID;
        public static int current_AccType;
        public static int current_EID = Customerlogin.current_EID;
        public static int acc_num = Customerlogin.account_num;
        public static int order_count;
        public static int count_copy;
        public static string lName = Customerlogin.lName;
        public static int check = Customerlogin.member_check;

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        //public static string getWithCID = "SELECT c.CID, m.MID, m.MovieName FROM Customers as c, Movies as M, Movie_Queue as mq " +
            //"WHERE c.CID = mq.CID and m.MID = mq.MID and c.CID = " + current_ID ;
        public static string getInit = "SELECT mq.CID, mq.MID, m.MovieName, mq.AvailableDate FROM Movies as M, Movie_Queue as mq " +
            "WHERE m.MID = mq.MID";

        public RentalScreen()
        {
            InitializeComponent();
            //This is the connection string for the database
            String connectionString = "Server = DESKTOP-935LH55; Database = MovieRentalDatabase; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            //Gets the cid then updates the table with thats specific customers movie queue
            if(check == 1)
            {
                label1.Hide();
                cust_ID.Hide();
                getId();
                getAccType();
                getCountOrders();
                update_table(getInit);
                

            }
            //Updates the table with all rentals since this is employee
            if (check == 2 | check == 3)
            {
                label1.Show();
                cust_ID.Show();
                current_ID = acc_num;
                getCountOrders();
                update_table(getInit);
            }

            ChooseScreen.Text = "--Select A Screen--";
        }

        private void RentalScreen_Load(object sender, EventArgs e)
        {

            //IF Customer
            if (check == 1) { 
                movies.Show();             
                customer.Show();
                employee.Hide();
                reports.Hide();
                actors.Hide();
                label1.Hide();
                cust_ID.Hide();
            }
            //If Employee
            if (check == 2 | check ==3)
            {
                movies.Show();
                customer.Show();
                employee.Show();
                reports.Show();
                actors.Show();
                label1.Show();
                cust_ID.Show();
            }
        }
        private void update_table(String cText)
        {
            //cText = command Text
            myCommand.CommandText = cText;
            try
            {
                myReader = myCommand.ExecuteReader();

                RentalGrid.Rows.Clear();
                while (myReader.Read())
                {  
                    if(check == 1)
                    {
                        if (current_ID.ToString().Equals(myReader["CID"].ToString()))
                        {
                            RentalGrid.Rows.Add(myReader["CID"].ToString(), myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["AvailableDate"].ToString());
                        }
                    }
                    if (check == 2 | check == 3)
                    {
                        RentalGrid.Rows.Add(myReader["CID"].ToString(), myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["AvailableDate"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }


        private void getId()
        {
            if(check == 1)
            {
                String getCID = "SELECT CID FROM Customers WHERE [Account#] = " + acc_num;
                myCommand.CommandText = getCID;
                current_ID = (int)myCommand.ExecuteScalar();
                //Console.WriteLine(current_ID);

                
            }
        }

        private void getAccType()
        {
            if (check == 1)
            {
                String getAccType = "SELECT AccountType FROM Customers WHERE [Account#] = " + acc_num;
                myCommand.CommandText = getAccType;
                current_AccType = (int)myCommand.ExecuteScalar();
                //Console.WriteLine(current_AccType);
            }
        }

        private void getCountOrders()
        {
            try
            {
                if (check == 1)
                {
                    String getOCount = "SELECT Count(*) FROM Orders WHERE [CID] = " + current_ID;
                    myCommand.CommandText = getOCount;
                    order_count = (int)myCommand.ExecuteScalar();
                    Console.WriteLine(order_count);
                }
                if (check == 2 | check == 3)
                {
                    String getOCount = "SELECT Count(*) FROM Orders";
                    myCommand.CommandText = getOCount;
                    order_count = (int)myCommand.ExecuteScalar();
                    Console.WriteLine(order_count);
                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void getCountCopy(int MID)
        {
            string getCopy = "SELECT NumberOfCopies FROM Movies WHERE [MID] = " + MID;
            myCommand.CommandText = getCopy;
            count_copy = (int)myCommand.ExecuteScalar();
            Console.WriteLine(count_copy);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            string add_order = "";
            int sub_copy = 0;
            string subtract_MCopy = "";
            if (check == 1)
            {
                try
                {
                    if (Rental_ID.Text != "")
                    {
                        getCountCopy(int.Parse(Rental_ID.Text));
                        if (count_copy != 0)
                        {
                            //Then we subtract a copy from the movies table
                            sub_copy = count_copy - 1;
                            subtract_MCopy = "UPDATE Movies SET NumberOfCopies = " + sub_copy + "WHERE MID = " + int.Parse(Rental_ID.Text);
                            myCommand.CommandText = subtract_MCopy;
                            MessageBox.Show(myCommand.CommandText);
                            myCommand.ExecuteNonQuery();

                            //Now we add the order
                            if (order_count == 0)
                            {
                                add_order = "INSERT INTO orders (OID, DateTime, PickupDate, ReturnDate, MID, EID, CID ) VALUES (" + 1 + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" +
                                    pickupDate.Text + "','" + returnDate.Text + "'," + int.Parse(Rental_ID.Text) + "," + 1 + "," + current_ID + ")";
                            }
                            else
                            {
                                int orderPlus = (order_count + 1);
                                add_order = "INSERT INTO orders (OID, DateTime, PickupDate, ReturnDate, MID, EID, CID ) VALUES (" + orderPlus + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" +
                                    pickupDate.Text + "','" + returnDate.Text + "'," + int.Parse(Rental_ID.Text) + "," + 1 + "," + current_ID + ")";
                            }
                            myCommand.CommandText = add_order;
                            MessageBox.Show(myCommand.CommandText);
                            myCommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            if(check == 2 | check == 3)
            {
                try
                {
                    if (Rental_ID.Text != "")
                    {
                        getCountCopy(int.Parse(Rental_ID.Text));
                        if (count_copy != 0)
                        {
                            //Then we subtract a copy from the movies table
                            sub_copy = count_copy - 1;
                            subtract_MCopy = "UPDATE Movies SET NumberOfCopies = '" + sub_copy + "'WHERE MID = '" + int.Parse(Rental_ID.Text);
                            myCommand.CommandText = subtract_MCopy;
                            MessageBox.Show(myCommand.CommandText);
                            myCommand.ExecuteNonQuery();

                            //Now we add the order
                            if (order_count == 0)
                            {
                                add_order = "INSERT INTO orders (OID, DateTime, PickupDate, ReturnDate, MID, EID, CID ) VALUES (" + 1 + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" +
                                    pickupDate.Text + "','" + returnDate.Text + "'," + int.Parse(Rental_ID.Text) + "," + current_EID + "," + int.Parse(cust_ID.Text) + ")";
                            }
                            else
                            {
                                int orderPlus = (order_count + 1);
                                add_order = "INSERT INTO orders (OID, DateTime, PickupDate, ReturnDate, MID, EID, CID ) VALUES (" + orderPlus + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" +
                                    pickupDate.Text + "','" + returnDate.Text + "'," + int.Parse(Rental_ID.Text) + "," + current_EID + "," + int.Parse(cust_ID.Text) + ")";
                            }
                            myCommand.CommandText = add_order;
                            MessageBox.Show(myCommand.CommandText);
                            myCommand.ExecuteNonQuery();

                        }
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string remove_order = "";
            int add_copy = 0;
            string add_MCopy = "";

            /*try
            {
                //int choice = int.Parse(MovieID_Input.Text);
                String delete = "Delete FROM Movies WHERE [MID] =" + choice;
                myCommand.CommandText = delete;

                myCommand.ExecuteNonQuery();

                update_table(uTable);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }*/
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowBestSellers_Click(object sender, EventArgs e)
        {

        }

        private void test_TextChanged(object sender, EventArgs e)
        {

        }


        private void movies_Click(object sender, EventArgs e)
        {
            movieinfo page2 = new movieinfo();
            page2.Show();
            this.Hide();
            

        }
        private void customer_Click(object sender, EventArgs e)
        {
            customer page3 = new customer();
            page3.Show();
            this.Hide();
        }

        private void rental_Click(object sender, EventArgs e)
        {
            RentalScreen page4 = new RentalScreen();
            page4.Show();
            this.Hide();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            Customerlogin page5 = new Customerlogin();
            page5.Show();
            this.Hide();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employee page6 = new Employee();
            page6.Show();
            this.Hide();

        }

        private void actors_Click(object sender, EventArgs e)
        {
            actorinfo page7 = new actorinfo();
            page7.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            Reports page8 = new Reports();
            page8.Show();
            this.Hide();
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
    }
}
