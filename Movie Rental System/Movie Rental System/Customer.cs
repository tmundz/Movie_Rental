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
    public partial class customer : Form
    {
        public static String current_screen;
        public static int current_ID = RentalScreen.current_ID;
        public static int current_EID = Customerlogin.current_EID;
        public static int acc_num = Customerlogin.account_num;
        public static string lName = Customerlogin.lName;
        public static int check = Customerlogin.member_check;

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public String cTable = "SELECT * FROM Customers";
        public String oTable = "SELECT * FROM Orders, Movies WHERE Orders.MID = Movies.MID";
        public int count = 3;

        public int custID;

        public customer()
        {
            InitializeComponent();
            //This is the connection string for the database
            String connectionString = "Server = DESKTOP-935LH55; Database = MovieRentalDatabase; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString);

            check = Customerlogin.member_check;

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
            if (check == 1)
            {
                update_table(cTable);
                update_Orders(oTable);
            }
            if (check == 2 | check ==3)
            {
                update_table(cTable);
                update_Orders(oTable);
            }

            ChooseScreen.Text = "--Select A Screen--";

            //Hide Stuff
            if (Customerlogin.member_check == 1)
            {
                EnterCID.Hide();
                CID_Input.Hide();
                Search.Hide();
                Add.Hide();
                Delete.Hide();
            }
        }

        private void Add_Click_1(object sender, EventArgs e)

        {
            if (int.TryParse(AccT_Input.Text, out _) & int.TryParse(CID_Input.Text, out _) & int.TryParse(Rating_Input.Text, out _) & int.TryParse(Acc_Input.Text, out _))
            {
                if (!FirstName_Input.Text.Equals("") & !LastName_Input.Text.Equals("") & !FirstName_Input.Text.Equals(""))
                    if (int.Parse(AccT_Input.Text) > 0 && int.Parse(AccT_Input.Text) <= 4)
                    {
                        if (int.Parse(Rating_Input.Text) > 0 && int.Parse(Rating_Input.Text) < 6)
                        {
                            try
                            {

                                myCommand.CommandText = "INSERT INTO Customers (CID, FirstName, LastName, City, State, Zip, Email, Account#, AccountType, Acc_Creation_Date, CreditCard#, Rating, Telephone) VALUES (" + int.Parse(CID_Input.Text) + ",'" +
                                   FirstName_Input.Text + "','" + LastName_Input.Text + "','" + City_Input.Text + "','" + State_Input.Text + "','" + Zip_Input.Text + "','" + Email_Input.Text + "'," + int.Parse(Acc_Input.Text) + "," + int.Parse(AccT_Input.Text) + ",'" + AccDate_Input.Text + "','" + CC_Input.Text + "'," + int.Parse(Rating_Input.Text) + ",'" + Telephone_Input.Text + "')";
                                MessageBox.Show(myCommand.CommandText);

                                myCommand.ExecuteNonQuery();
                            }
                            catch (Exception e2)
                            {
                                MessageBox.Show(e2.ToString(), "Error");
                            }
                            update_table(cTable);
                        }
                        else
                        {
                            MessageBox.Show("Please ensure the rating is between 1 - 5.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a number (1, 2,3,4) for Account type.");
                    }
            }
            else
            {
                MessageBox.Show("Please ensure numbers are entered for Account Type, ID, Rating, and Account Number.", "Error");
            }
        } 
        

        private void Search_Click_1(object sender, EventArgs e)
        {
            if (check != 1)
            {
                String search = "SELECT * FROM Customers";
                myCommand.CommandText = search;
                try
                {
                    myReader = myCommand.ExecuteReader();

                    CustomerGrid.Rows.Clear();
                    RentsGridView.Rows.Clear();
                    while (myReader.Read())
                    {
                        if (int.Parse(myReader["CID"].ToString()) == int.Parse(CID_Input.Text))
                        {
                            CustomerGrid.Rows.Add(myReader["CID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["Email"].ToString(), myReader["Account#"].ToString(), myReader["AccountType"].ToString(), myReader["Acc_Creation_Date"].ToString(), myReader["CreditCard#"].ToString(), myReader["Rating"].ToString(), myReader["Telephone"].ToString());
                        }
                    }
                    myReader.Close();

                    myCommand.CommandText = oTable;
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (int.Parse(myReader["CID"].ToString()) == int.Parse(CID_Input.Text))
                        {
                            RentsGridView.Rows.Add(myReader["OID"].ToString(), myReader["DateTime"].ToString(), myReader["PickupDate"].ToString(), myReader["ReturnDate"].ToString(), myReader["MovieName"].ToString());
                        }
                    }
                    myReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                    myReader.Close();
                    update_table(cTable);
                    update_Orders(oTable);
                }
            }
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string CC = CC_Input.Text;
            String FName = FirstName_Input.Text;
            String LName = LastName_Input.Text;
            string date = AccDate_Input.Text;
            string city = City_Input.Text;
            string state = State_Input.Text;
            string zip = Zip_Input.Text;
            string email = Email_Input.Text;
            string phone = Telephone_Input.Text;
            int Acc = int.Parse(Acc_Input.Text);
            int rate = int.Parse(Rating_Input.Text);
            int type = int.Parse(AccT_Input.Text);

            if (int.Parse(AccT_Input.Text) > 0 && int.Parse(AccT_Input.Text) <= 4)
            {
                try
                {
                    int choice = int.Parse(CID_Input.Text);
                    String update = "UPDATE Customers SET CreditCard# = '" + @CC + "', FirstName = '" + @FName + "', LastName = '" + @LName + "', City = '" + @city + "', State = '" + @State + "', Zip = '" + @zip + "', Account# = '" + @Acc + "', AccountType = '" + @type + "', Acc_Creation_Date = '" + @date + "',  Email = '" + @email + "', Telephone = '" + @phone + "', Rating = '" + @rate + "' WHERE CID ='" + choice + "'";
                    myCommand.CommandText = update;
                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();

                    update_table(cTable);
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
            else {
                MessageBox.Show("Enter a number (1, 2,3,4) for Account type.");
            }
        }

        private void update_table(String cText)
        {
            //cText = command Text
            myCommand.CommandText = cText;
            try
            {
                myReader = myCommand.ExecuteReader();

                CustomerGrid.Rows.Clear();
                while (myReader.Read())
                {
                    if (check == 1)
                    {
                        if (current_ID.ToString().Equals(myReader["CID"].ToString()))
                        {
                            CustomerGrid.Rows.Add(myReader["CID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["Email"].ToString(), myReader["Account#"].ToString(), myReader["AccountType"].ToString(), myReader["Acc_Creation_Date"].ToString(), myReader["CreditCard#"].ToString(), myReader["Rating"].ToString(), myReader["Telephone"].ToString());
                        }
                    }
                    if(check == 2 | check == 3)
                    {
                        CustomerGrid.Rows.Add(myReader["CID"].ToString(), myReader["FirstName"].ToString(), myReader["LastName"].ToString(), myReader["City"].ToString(), myReader["State"].ToString(), myReader["Zip"].ToString(), myReader["Email"].ToString(), myReader["Account#"].ToString(), myReader["AccountType"].ToString(), myReader["Acc_Creation_Date"].ToString(), myReader["CreditCard#"].ToString(), myReader["Rating"].ToString(), myReader["Telephone"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void update_Orders(String oText)
        {
            //oText = command Text
            myCommand.CommandText = oText;
            try
            {
                myReader = myCommand.ExecuteReader();

                RentsGridView.Rows.Clear();
                while (myReader.Read())
                {
                    if (check == 1)
                    {
                        if (current_ID.ToString().Equals(myReader["CID"].ToString()))
                        {
                            RentsGridView.Rows.Add(myReader["OID"].ToString(), myReader["DateTime"].ToString(), myReader["PickupDate"].ToString(), myReader["ReturnDate"].ToString(), myReader["MovieName"].ToString());
                        }
                    }
                    if (check == 2 | check == 3)
                    {
                        RentsGridView.Rows.Add(myReader["OID"].ToString(), myReader["DateTime"].ToString(), myReader["PickupDate"].ToString(), myReader["ReturnDate"].ToString(), myReader["MovieName"].ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int choice = int.Parse(CID_Input.Text);
                String delete = "Delete FROM Customers WHERE CID ='" + choice + "'";
                myCommand.CommandText = delete;

                myCommand.ExecuteNonQuery();

                update_table(cTable);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalScreen page = new RentalScreen();
            page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieinfo page2 = new movieinfo();
            page2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Customerlogin page4 = new Customerlogin();
            page4.Show();
            this.Hide();
        }

        private void customer2_Click(object sender, EventArgs e)
        {
            customer page3 = new customer();
            page3.Show();
            this.Hide();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            int check = Customerlogin.member_check;

            if (check == 1)
            {
                movies.Show();
                customer2.Show();
                employee.Hide();
                reports.Hide();
                actors.Hide();      
            }
            if (check == 2 | check == 3)
            {
                movies.Show();
                customer2.Show();
                employee.Show();
                reports.Show();
                actors.Show();
            }
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employee page4 = new Employee();
            page4.Show();
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

        private void CInfotab_Click(object sender, EventArgs e)
        {

        }

        private void CInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Telephone_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Rating_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rating_Click(object sender, EventArgs e)
        {

        }

        private void CC_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void CC_Click(object sender, EventArgs e)
        {

        }

        private void Acc_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Click(object sender, EventArgs e)
        {

        }

        private void ChooseScreen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
