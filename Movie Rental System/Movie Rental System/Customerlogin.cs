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
    public partial class Customerlogin : Form
    {   //This will either be 1 for customer or 2 for employee
        public static int member_check;
        //This is the account number for customer(used as login info)
        public static int current_EID;
        //This is the account number for customer(used as login info)
        public static int account_num;
        //This is the last name used in both employee and customer login as password
        public static string lName;
        //This is for valid login
        public static bool validLogin;

        //These are two string querys used to check if login info is valid
        public string checkCustomer = "SELECT * FROM Customers";
        public string checkEmployee = "SELECT * FROM Employees";

        //These are the sql variables
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Customerlogin()
        {
            InitializeComponent();
            //This section before the varaibles below is so that we can check if a customer or employee even exists in the database
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

            button2.Hide();
            login.Show();
            button3.Hide();
            //Initial state is Customer
            member_check = 1;
        }
        
    

        private void login_Click(object sender, EventArgs e)
        {
            if (userLogin.Text != "" & password.Text != "")
            {
                //correct user and pass
                MessageBox.Show("Welcome user!");
                //Designated as customer
                member_check = 1;

                //Store the account number and password for checking
                account_num = int.Parse(userLogin.Text);
                lName = password.Text;

                CheckValid();
                
                if (validLogin == true)
                {
                    RentalScreen page10 = new RentalScreen();
                    page10.Show();
                    this.Hide();
                }
                else if(validLogin == false)
                {
                    MessageBox.Show("Invalid Login Credientials");
                    password.Text = "";
                    userLogin.Text = "";
                    myReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter your login information");
                password.Text = "";
                userLogin.Text = "";
            }
        }

        private void CheckValid()
        {
            if (member_check == 1)
            {
                Console.WriteLine("in valid");
                myCommand.CommandText = checkCustomer;
                myReader = myCommand.ExecuteReader();
                int aSwitch = 0;
                while (myReader.Read() & aSwitch == 0)
                {
                    if ((myReader["Account#"].ToString().Equals(account_num.ToString())))// & (myReader["LastName"].ToString().Equals(lName)))
                    {
                        validLogin = true;
                        aSwitch = 1;
                    }
                }
                myReader.Close();
            }

            else if (member_check == 2)
            {
                myCommand.CommandText = checkEmployee;
                myReader = myCommand.ExecuteReader();
                int aSwitch = 0;
                
                while (myReader.Read() & aSwitch == 0)
                {
                    Console.WriteLine(current_EID.ToString() + " " + lName);
                    Console.WriteLine(myReader["EID"].ToString() + " " + myReader["LastName"].ToString());
                    if ((myReader["EID"].ToString().Equals(current_EID.ToString())))// & (myReader["LastName"].ToString().Equals(lName)))
                    {
                        validLogin = true;
                        aSwitch = 1;
                    }
                }
                myReader.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Employeelogin page = new Employeelogin();
            //page.Show();
            //this.Hide();

            label3.Text = "Employee Login";
            label1.Text = "EID:";       
            button1.Hide();
            button3.Show();
            button2.Show();
            login.Hide();
            button3.Show();
            member_check = 2;


        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label3.Text = "Customer login";
            label1.Text = "Account #:";
            button2.Hide();
            button1.Show();
            login.Show();
            button3.Hide();
            member_check = 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userLogin.Text != "" & password.Text != "")
            {
                //correct user and pass
                MessageBox.Show("Welcome Employee!");
                member_check = 2;
                //Designated as employee
                current_EID = int.Parse(userLogin.Text);
                lName = password.Text;

                CheckValid();
                Console.WriteLine("here");
                if (int.Parse(userLogin.Text) == 1 && password.Text == "admin321") {
                    member_check = 3;
                    RentalScreen page10 = new RentalScreen();
                    page10.Show();
                    this.Hide();
                }
                else if (validLogin == true)
                {
                    RentalScreen page10 = new RentalScreen();
                    page10.Show();
                    this.Hide();
                }
                else if (validLogin == false)
                {
                    MessageBox.Show("Invalid Login Credientials");
                    password.Text = "";
                    userLogin.Text = "";
                    myReader.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter your login information");
                password.Text = "";
                userLogin.Text = "";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Customerlogin_Load(object sender, EventArgs e)
        {
            member_check = 1;
        }

      
    }
}
