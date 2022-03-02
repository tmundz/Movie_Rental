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
    public partial class Employee : Form
    {

        public static int current_ID = RentalScreen.current_ID;
        public static int check = Customerlogin.member_check;
        public static int current_EID = RentalScreen.current_EID;

        public static String current_screen;
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String eTable = "SELECT * FROM Employees";
        public int count = 3;
       

        public Employee()
        {
            Console.WriteLine("hello check = " + check);
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
            update_table(eTable);

            ChooseScreen.Text = "--Select A Screen--";

            if (Customerlogin.member_check == 2)
            {
                EnterEID.Hide();
                EID_Input.Hide();
                Search.Hide();
                Delete.Hide();
                Add.Hide();
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (check == 3)
            {
                try
                {
                    myCommand.CommandText = "INSERT INTO Employees (EID, SocialSecurity#, FirstName, LastName, City, State, Zip, StartDate, HourlyRate, Telephone) VALUES (" + int.Parse(EID_Input.Text) + "," + int.Parse(SocialSecurity_Input.Text) + ",'" +
                       FirstName_Input.Text + "','" + LastName_Input.Text + "','" + City_Input.Text + "','" + State_Input.Text + "','" + Zip_Input.Text + "','" + StartDate_Input.Text + "'," + float.Parse(HourlyRate_Input.Text) + ",'" + Telephone_Input.Text + "')";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
                update_table(eTable);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (check == 3)
            {
                String search = "SELECT * FROM Employees";
                myCommand.CommandText = search;
                try
                {
                    myReader = myCommand.ExecuteReader();

                    EmployeesData.Rows.Clear();
                    while (myReader.Read())
                    {
                        if (int.Parse(myReader["EID"].ToString()) == int.Parse(EID_Input.Text))
                        {
                            EmployeesData.Rows.Add(myReader["EID"].ToString(), myReader["SocialSecurity#"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["StartDate"].ToString(), myReader["HourlyRate"].ToString(), myReader["Telephone"].ToString());
                        }
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                    myReader.Close();
                    update_table(eTable);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int SS = int.Parse(SocialSecurity_Input.Text);
            String FName = FirstName_Input.Text;
            String LName = LastName_Input.Text;
            string date = StartDate_Input.Text;
            string city = City_Input.Text;
            string state = State_Input.Text;
            string zip = Zip_Input.Text;
            float Hourly = int.Parse(HourlyRate_Input.Text);
            string phone = Telephone_Input.Text;
            

            try
            {
                int choice = int.Parse(EID_Input.Text);
                String update = "UPDATE Employees SET SocialSecurity# = '" + @SS + "', FirstName = '" + @FName + "', LastName = '" + @LName + "', City = '" + @city + "', State = '" + @State + "', Zip = '" + @zip + "', StartDate = '" + @date +"', HourlyRate = '" + @Hourly + "', Telephone = '" + @phone + "' WHERE EID ='" + choice + "'";
                myCommand.CommandText = update;
                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();

                update_table(eTable);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == 3)
            {
                try
                {
                    int choice = int.Parse(EID_Input.Text);
                    String delete = "Delete FROM Employees WHERE EID ='" + choice + "'";
                    myCommand.CommandText = delete;

                    myCommand.ExecuteNonQuery();

                    update_table(eTable);
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }
        
private void update_table(String cText)
        {
            
            //cText = command Text
            myCommand.CommandText = cText;
            try
            {
                myReader = myCommand.ExecuteReader();

                EmployeesData.Rows.Clear();

                while (myReader.Read())
                {
                    if (check == 2)
                    {
                        if (current_EID.ToString().Equals(myReader["EID"].ToString()))
                        {
                            EmployeesData.Rows.Add(myReader["EID"].ToString(), myReader["SocialSecurity#"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["StartDate"].ToString(), myReader["HourlyRate"].ToString(), myReader["Telephone"].ToString());
                        }
                    }
                    if (check == 3)
                    {
                        EmployeesData.Rows.Add(myReader["EID"].ToString(), myReader["SocialSecurity#"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["StartDate"].ToString(), myReader["HourlyRate"].ToString(), myReader["Telephone"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
   
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }


        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void StateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZipText_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hourlytext_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeData_SelectedIndexChanged(object sender, EventArgs e)
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
            customer page = new customer();
            page.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void actors_Click(object sender, EventArgs e)
        {
            actorinfo page3 = new actorinfo();
            page3.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            Reports page4 = new Reports();
            page4.Show();
            this.Hide();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            Customerlogin page5 = new Customerlogin();
            page5.Show();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

            int check = Customerlogin.member_check;

            if (check == 1)
            {
                movies.Show();
                customer.Show();
                employee2.Hide();
                reports.Hide();
                actors.Hide();
            }
            if (check == 2)
            {
                movies.Show();
                customer.Show();
                employee2.Show();
                reports.Show();
                actors.Show();
            }
        }

        private void rental_Click(object sender, EventArgs e)
        {
            RentalScreen page6 = new RentalScreen();
            page6.Show();
            this.Hide();
        }

        private void employee2_Click(object sender, EventArgs e)
        {
            Employee page7 = new Employee();
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
    }
}
