using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Movie_Rental_System
{
    public partial class movieinfo : Form
    {
        public static int current_ID;
        public static int current_AccType;
        public static int current_EID = Customerlogin.current_EID;
        public static int acc_num = Customerlogin.account_num;
        public static string lName = Customerlogin.lName;
        public static int check = Customerlogin.member_check;

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public String uTable = "SELECT * FROM Movies";
        public static String current_screen;
        public static string getInit = "SELECT mq.CID, c.LastName, c.FirstName, mq.MID, m.MovieName, mq.AvailableDate FROM Customers as c, Movies as M, Movie_Queue as mq " +
            "WHERE c.CID = mq.CID and m.MID = mq.MID";


        public movieinfo()
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
            
            ChooseScreen.Text = "--Select A Screen--";

            /*if (check == 1)
            {
                getId();
                Add_Movie.Hide();
                Delete_Movie.Hide();
                Edit_Movie.Hide();
                update_table(uTable);
                update_Queue(getInit);

            }*/
        }

        private void getId()
        {
            if (check == 1)
            {
                String getCID = "SELECT CID FROM Customers WHERE [Account#] = " + acc_num;
                myCommand.CommandText = getCID;
                current_ID = (int)myCommand.ExecuteScalar();
                //Console.WriteLine(current_ID);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Movie_Click(object sender, EventArgs e)

        {   
            if (check == 1)
            {
                try
                {
                    if (MovieID_Input.Text != "")
                    {
                        string add_queue = "INSERT INTO Movie_Queue (CID, MID) VALUES (" + current_ID + "," + int.Parse(MovieID_Input.Text) + ")";
                        myCommand.CommandText = add_queue;
                        MessageBox.Show(myCommand.CommandText);

                        myCommand.ExecuteNonQuery();
                        update_Queue(getInit);
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            if (check == 2 | check == 3)
            {
                try
                {
                    if (MovieID_Input.Text != "" & MovieName_Input.Text != "" & MovieType_Input.Text != "" & Fee_Input.Text != "" & NumCopys_Input.Text != "" & Rating_Input.Text != "")
                    {
                        if (int.TryParse(Fee_Input.Text, out _) & int.TryParse(NumCopys_Input.Text, out _) & int.TryParse(Rating_Input.Text, out _))
                        {
                            if (int.Parse(Rating_Input.Text) > 0 && int.Parse(Rating_Input.Text) < 6)
                            {
                                myCommand.CommandText = "INSERT INTO Movies (MID, MovieName, MovieType, NumberOfCopies, Rating, DistributionFEE) VALUES (" + int.Parse(MovieID_Input.Text) + ",'" + MovieName_Input.Text +
                                "','" + MovieType_Input.Text + "'," + int.Parse(Fee_Input.Text) + "," + int.Parse(NumCopys_Input.Text) + "," + int.Parse(Rating_Input.Text) + ")";
                                MessageBox.Show(myCommand.CommandText);

                                myCommand.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Please ensure the rating is between 1 - 5.", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please ensure that there are whole numbers for the fee, number of copies and rating.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure all fields have something entered.", "Error");
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            update_table(uTable);
        }

        private void Search_Movie_Click(object sender, EventArgs e)
        {
            String search = "SELECT * FROM Movies";
            myCommand.CommandText = search;
            try
            {
                myReader = myCommand.ExecuteReader();

                Movies.Rows.Clear();
                while (myReader.Read())
                {
                    if (int.Parse(myReader["MID"].ToString()) == int.Parse(MovieID_Input.Text))
                    {
                        Movies.Rows.Add(myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["DistributionFEE"].ToString(), myReader["NumberOfCopies"].ToString(), myReader["Rating"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                //MessageBox.Show(e3.ToString(), "Error");
                myReader.Close();
                update_table(uTable);
            }
        }

        private void Delete_Movie_Click(object sender, EventArgs e)
        {
            try
            {
                int choice = int.Parse(MovieID_Input.Text);
                String delete = "Delete FROM Movies WHERE [MID] =" + choice;
                myCommand.CommandText = delete;

                myCommand.ExecuteNonQuery();

                update_table(uTable);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Edit_Movie_Click(object sender, EventArgs e)
        {
            if (MovieID_Input.Text != "" & MovieName_Input.Text != "" & MovieType_Input.Text != "" & Fee_Input.Text != "" & NumCopys_Input.Text != "" & Rating_Input.Text != "")
            {
                if (int.TryParse(Fee_Input.Text, out _) & int.TryParse(NumCopys_Input.Text, out _) & int.TryParse(Rating_Input.Text, out _))
                {
                    String newmoviename = MovieName_Input.Text;
                    String newmovietype = MovieType_Input.Text;
                    int movieID = int.Parse(MovieID_Input.Text);
                    int newfee = int.Parse(Fee_Input.Text);
                    int newcopy = int.Parse(NumCopys_Input.Text);
                    int newrating = int.Parse(Rating_Input.Text);


                    int choice = int.Parse(MovieID_Input.Text);
                    string update = "UPDATE Movies SET MovieName = '" + @newmoviename + "', MovieType = '" + @newmovietype + "', DistributionFEE = '" + @newfee + "', NumberOfCopies = '" + @newcopy + "', Rating = '" + @newrating + "' where MID = '" + movieID + "'";
                    myCommand.CommandText = update;
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    update_table(uTable);
                }
                else
                {
                    MessageBox.Show("Please ensure that there are whole numbers for the fee, number of copies and rating.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields have something entered.", "Error");
            }
        }
            
        
        private void update_table(String cText)
        {
            //cText = command Text
            myCommand.CommandText = cText;
            try
            {
                myReader = myCommand.ExecuteReader();

                Movies.Rows.Clear();
                while (myReader.Read())
                {
                    Movies.Rows.Add(myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["MovieType"].ToString(), myReader["DistributionFEE"].ToString(), myReader["NumberOfCopies"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        public void update_Queue(String cText)
        {
            //cText = command Text
            myCommand.CommandText = cText;
            Console.WriteLine("Before reader");
            try
            {
                myReader = myCommand.ExecuteReader();

                Movie_Queues.Rows.Clear();
                while (myReader.Read())
                {
                    string customerName = myReader["FirstName"].ToString() + " " + myReader["LastName"].ToString();
                    if (check == 1)
                    {
                        if (current_ID.ToString().Equals(myReader["CID"].ToString()))
                        {
                            Console.WriteLine("Im Here");
                            Movie_Queues.Rows.Add(myReader["CID"].ToString(), customerName, myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["AvailableDate"].ToString());
                        }
                    }
                    if (check == 2)
                    {
                        Movie_Queues.Rows.Add(myReader["CID"].ToString(), customerName, myReader["MID"].ToString(), myReader["MovieName"].ToString(), myReader["AvailableDate"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void movieinfo_Load(object sender, EventArgs e)
        {

            if (check == 1)
            {
                getId();
                movies2.Show();
                customer.Show();
                employee2.Hide();
                reports.Hide();
                actors.Hide();
                Delete_Movie.Hide();
                Edit_Movie.Hide();
                update_table(uTable);
                update_Queue(getInit);

            }
            if (check == 2)
            {
                movies2.Show();
                customer.Show();
                employee2.Show();
                reports.Show();
                actors.Show();
                update_table(uTable);
                update_Queue(getInit);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MovieName_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void MovieID_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee2_Click(object sender, EventArgs e)
        {
            Employee page5 = new Employee();
            page5.Show();
            this.Hide();
        }

        private void movies2_Click(object sender, EventArgs e)
        {
            movieinfo page = new movieinfo();
            page.Show();
            page.Hide();
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

        private void signout_Click(object sender, EventArgs e)
        {
            Customerlogin page = new Customerlogin();
            page.Show();
            this.Hide();
        }

        private void actors_Click(object sender, EventArgs e)
        {
            actorinfo page5 = new actorinfo();
            page5.Show();
            this.Hide();
        }
        private void reports_Click(object sender, EventArgs e)
        {
            Reports page6 = new Reports();
            page6.Show();
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

        private void actorlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}