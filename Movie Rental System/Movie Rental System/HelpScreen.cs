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
    public partial class HelpScreen : Form
    {
        public static String cString;
        public static String header1;
        public static String header2;
        public static String header3;
        public static String header4;
        public static String textbox1;
        public static String textbox2;
        public static String textbox3;
        public static String textbox4;

        public HelpScreen(String current_string)
        {
            cString = current_string;
            //
            //  Put what screen is currently here
            // 
            //
            if (cString == "Movies")
            {
                header1 = "Movie ID: ";
                textbox1 = "Movie ID is a number that is assigned to a movie internally.  You use this number \nto search for a movie in the database.";
                header2 = "Adding/Editing:";
                textbox2 = "To add and edit a movie, fill all input with their approproate values.  Numbers must \nbe put into ID, Number of Copies, Fee and Rating.  Anything can be typed into \nname and Type.";
                header3 = "Removing:";
                textbox3 = "To remove a movie from the database, enter it's ID number into the ID box and \npress remove.";
                header4 = "Searching:";
                textbox4 = "To search for a movie, enter it's ID number and press search.";
            }
            else if (cString == "Actors")
            {
                header1 = "Actor ID: ";
                textbox1 = "Actor ID is a number that is assigned to an actor internally.  You use this number \nto search for an actor in the database.";
                header2 = "Adding/Editing:";
                textbox2 = "To add and edit an actor, fill all input with their approproate values.  Numbers \nmust be put into ID, Age and Rating.  Anything can be typed into First Name, Last \nName and Gender.";
                header3 = "Removing:";
                textbox3 = "To remove an actor from the database, enter their ID number into the ID box and \npress remove.";
                header4 = "Searching:";
                textbox4 = "To search for an actor, enter their ID number and press search.";
            }
            else if (cString == "Employees")
            {
                header1 = "Actor ID: ";
                textbox1 = "Actor ID is a number that is assigned to an actor internally.  You use this \nnumber to search for an actor in the database.";
                header2 = "Adding/Editing:";
                textbox2 = "To add and edit an actor, fill all input with their approproate values.  \nNumbers must be put into ID, Age and Rating.  Anything can be typed into First \nName, Last Name and Gender.";
                header3 = "Removing:";
                textbox3 = "To remove an actor from the database, enter their ID number into the ID box \nand press remove.";
                header4 = "Searching:";
                textbox4 = "To search for an actor, enter their ID number and press search.";
            }
            else if (cString == "Customer")
            {
                header1 = "Customer ID: ";
                textbox1 = "Customer ID is a number that is assigned to a customer internally.  You \nuse this number to search for a customer in the database.";
                header2 = "Adding/Editing:";
                textbox2 = "To add and edit a customer, fill all input with their approproate values.  \nNumbers must be put into ID, Account Number, Credit Card Number, Telephone \nand Rating.  Anything can be typed into First Name, Last Name, City, State, \nZip Code, Account Creation and Email.";
                header3 = "Removing:";
                textbox3 = "To remove a customer from the database, enter their ID number into the ID \nbox and press remove.";
                header4 = "Searching:";
                textbox4 = "To search for a customer, enter their ID number and press search.";
            }
            else if (cString == "Rental")
            {
                header1 = "Show Best Sellers: ";
                textbox1 = "This button will show the best selling movies in the table.";
                header2 = "Search:";
                textbox2 = "After entering in desired info in the appropriate boxes, pressing search will \nattempt to find the movie or actor in the database.";
                header3 = "Rent:";
                textbox3 = "Will rent out the typed in movie.";
                header4 = "Return:";
                textbox4 = "Will show the movie as returned.";
            }
            else if (cString == "Reports")
            {
                header1 = "Reports and Statistics: ";
                textbox1 = "This page will display different reports and statistics for the business.";
                header2 = "Enter Month:";
                textbox2 = "The month entered here will be the month that the reports and statistics \nare shown for.";
                header3 = "Other Buttons:";
                textbox3 = "Total Income shows the total income for the month. Total Rentals shows the \nrentals for the month. Most Rented Movies will show the most rented \nmovies for the month.  Most active customers will show the most active \ncustomers of the month.  Most Popular Actors will show the actors who \nappear in most of the rented movies for the month.";
                header4 = "";
                textbox4 = "";
            }
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
