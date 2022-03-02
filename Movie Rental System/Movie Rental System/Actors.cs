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
    public partial class actorinfo : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String uTable = "SELECT * FROM Actors";
        public static String current_screen;

        public actorinfo()
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
            update_table(uTable);

            ChooseScreen.Text = "--Select A Screen--";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Actor_Click(object sender, EventArgs e)

        {
            try
            {
                if (ActorFirstName_Input.Text != "" & ActorLastName_Input.Text != "" & Gender_Input.Text != "" & ActorID_Input.Text != "" & Age_Input.Text != "" & Rating_Input.Text != "")
                {
                    if (int.TryParse(Rating_Input.Text, out _) & int.TryParse(Age_Input.Text, out _))
                    {
                        if (int.Parse(Rating_Input.Text) > 0 && int.Parse(Rating_Input.Text) < 6)
                        {
                            myCommand.CommandText = "INSERT INTO Actors (AID, FirstName, Lastname, Gender, Age, Rating) VALUES (" + int.Parse(ActorID_Input.Text) + ",'" + ActorFirstName_Input.Text + "', '" + ActorLastName_Input.Text +
                            "','" + Gender_Input.Text + "'," + int.Parse(Age_Input.Text) + "," + int.Parse(Rating_Input.Text) + ")";
                            MessageBox.Show(myCommand.CommandText);

                            myCommand.ExecuteNonQuery();

                            if (int.TryParse(MID_Add.Text, out _))
                            {
                                myCommand.CommandText = "INSERT INTO Movies_Appeared (AID, MID) VALUES (" + int.Parse(ActorID_Input.Text) + "," + int.Parse(MID_Add.Text) + ")";
                                MessageBox.Show(myCommand.CommandText);

                                myCommand.ExecuteNonQuery();


                            }
                        }
                        else
                        {
                            MessageBox.Show("Please ensure the rating is between 1 - 5.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure that there are whole numbers for the age and rating.", "Error");
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
            update_table(uTable);
        }

        private void Search_Actor_Click(object sender, EventArgs e)
        {
            String search = "SELECT * FROM Actors";
            myCommand.CommandText = search;
            try
            {
                myReader = myCommand.ExecuteReader();

                Actors.Rows.Clear();
                while (myReader.Read())
                {
                    if (int.Parse(myReader["AID"].ToString()) == int.Parse(ActorID_Input.Text))
                    {
                        Actors.Rows.Add(myReader["AID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["Gender"].ToString(), myReader["Age"].ToString(), myReader["Rating"].ToString());
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

        private void Delete_Actor_Click(object sender, EventArgs e)
        {
            try
            {
                int choice = int.Parse(ActorID_Input.Text);
                String delete = "Delete FROM Actors WHERE [AID] =" + choice;
                myCommand.CommandText = delete;

                myCommand.ExecuteNonQuery();

                update_table(uTable);

                if (int.TryParse(MID_Add.Text, out _))
                {
                    String delete2 = "DELETE FROM Movies_Appeared WHERE [AID] =" + choice;
                    myCommand.CommandText = delete2;

                    myCommand.ExecuteNonQuery();

                    update_table(uTable);


                }
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Edit_Actor_Click(object sender, EventArgs e)
        {
            if (ActorFirstName_Input.Text != "" & ActorLastName_Input.Text != "" & Gender_Input.Text != "" & ActorID_Input.Text != "" & Age_Input.Text != "" & Rating_Input.Text != "")
            {
                if (int.TryParse(Rating_Input.Text, out _) & int.TryParse(Age_Input.Text, out _))
                {
                    String newactorfname = ActorFirstName_Input.Text;
                    String newactorlname = ActorLastName_Input.Text;
                    String newactorGender = Gender_Input.Text;
                    int actorID = int.Parse(ActorID_Input.Text);
                    int newage = int.Parse(Age_Input.Text);
                    int newrating = int.Parse(Rating_Input.Text);
                    int MID = int.Parse(MID_Add.Text);


                    int choice = int.Parse(ActorID_Input.Text);
                    string update = "UPDATE Actors SET FirstName = '" + @newactorfname + "', LastName = '" + @newactorlname + "', Gender = '" + @newactorGender + "', Age = '" + @newage + "', Rating = '" + @newrating + "' where AID = '" + actorID + "'";
                    myCommand.CommandText = update;
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    update_table(uTable);
                    if (int.TryParse(MID_Add.Text, out _))
                    {
                        string Mappear_Update = "UPDATE Movies_Appeared SET AID = " + actorID + ", MID = " + MID;

                        myCommand.CommandText = Mappear_Update;
                        
                        MessageBox.Show(myCommand.CommandText);

                        myCommand.ExecuteNonQuery();
                        update_table(uTable);
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure that there are whole numbers for the age and rating.", "Error");
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

                Actors.Rows.Clear();
                while (myReader.Read())
                {
                    Actors.Rows.Add(myReader["AID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["Gender"].ToString(), myReader["Age"].ToString(), myReader["Rating"].ToString());
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void actorinfo_Load(object sender, EventArgs e)
        {
            int check = Customerlogin.member_check;

            if (check == 1)
            {
                movies2.Show();
                customer.Show();
                employee2.Hide();
                reports.Hide();
                actors2.Hide();
            }
            if (check == 2 | check == 3)
            {
                movies2.Show();
                customer.Show();
                employee2.Show();
                reports.Show();
                actors2.Show();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void employee2_Click(object sender, EventArgs e)
        {
            Employee page3 = new Employee();
            page3.Show();
            this.Hide();
        }

        private void rental_Click(object sender, EventArgs e)
        {
            RentalScreen page4 = new RentalScreen();
            page4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void signout_Click(object sender, EventArgs e)
        {
            Customerlogin page7 = new Customerlogin();
            page7.Show();
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

        private void moviesappeared_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_MID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(MID_Add.Text, out _))
            {
                myCommand.CommandText = "INSERT INTO Movies_Appeared (AID, MID) VALUES (" + int.Parse(ActorID_Input.Text) + "," + int.Parse(MID_Add.Text) + ")";
                MessageBox.Show(myCommand.CommandText);

                myCommand.ExecuteNonQuery();


            }
        }
    }
}
