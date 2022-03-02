
namespace Movie_Rental_System
{
    partial class RentalScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RentButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.TextBox();
            this.Rental_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowBestSellers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pickupDate = new System.Windows.Forms.TextBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.movies = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.actors = new System.Windows.Forms.Button();
            this.rental = new System.Windows.Forms.Button();
            this.RentalGrid = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cust_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterIDLabel
            // 
            this.EnterIDLabel.AutoSize = true;
            this.EnterIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterIDLabel.Location = new System.Drawing.Point(13, 149);
            this.EnterIDLabel.Name = "EnterIDLabel";
            this.EnterIDLabel.Size = new System.Drawing.Size(200, 32);
            this.EnterIDLabel.TabIndex = 1;
            this.EnterIDLabel.Text = "Enter Movie ID";
            this.EnterIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie Rental";
            // 
            // RentButton
            // 
            this.RentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.Location = new System.Drawing.Point(125, 479);
            this.RentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentButton.Name = "RentButton";
            this.RentButton.Size = new System.Drawing.Size(87, 47);
            this.RentButton.TabIndex = 3;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = true;
            this.RentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(231, 479);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(87, 47);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDate.Location = new System.Drawing.Point(20, 347);
            this.returnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(300, 34);
            this.returnDate.TabIndex = 5;
            this.returnDate.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Rental_ID
            // 
            this.Rental_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_ID.Location = new System.Drawing.Point(20, 184);
            this.Rental_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rental_ID.Name = "Rental_ID";
            this.Rental_ID.Size = new System.Drawing.Size(300, 34);
            this.Rental_ID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Return Date";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(19, 479);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 47);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ShowBestSellers
            // 
            this.ShowBestSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBestSellers.Location = new System.Drawing.Point(19, 12);
            this.ShowBestSellers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowBestSellers.Name = "ShowBestSellers";
            this.ShowBestSellers.Size = new System.Drawing.Size(221, 47);
            this.ShowBestSellers.TabIndex = 9;
            this.ShowBestSellers.Text = "Show Best Sellers";
            this.ShowBestSellers.UseVisualStyleBackColor = true;
            this.ShowBestSellers.Click += new System.EventHandler(this.ShowBestSellers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pickup Date";
            // 
            // pickupDate
            // 
            this.pickupDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupDate.Location = new System.Drawing.Point(20, 264);
            this.pickupDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickupDate.Name = "pickupDate";
            this.pickupDate.Size = new System.Drawing.Size(300, 34);
            this.pickupDate.TabIndex = 10;
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(1128, 182);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(40, 37);
            this.HelpButton.TabIndex = 11;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ChooseScreen
            // 
            this.ChooseScreen.FormattingEnabled = true;
            this.ChooseScreen.Items.AddRange(new object[] {
            "--Select A Screen--",
            "Movies",
            "Actors",
            "Employees",
            "Customer",
            "Rental",
            "Reports"});
            this.ChooseScreen.Location = new System.Drawing.Point(1007, 149);
            this.ChooseScreen.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(160, 24);
            this.ChooseScreen.TabIndex = 12;
            // 
            // movies
            // 
            this.movies.Location = new System.Drawing.Point(684, 20);
            this.movies.Margin = new System.Windows.Forms.Padding(4);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(112, 37);
            this.movies.TabIndex = 13;
            this.movies.Text = "Movies";
            this.movies.UseVisualStyleBackColor = true;
            this.movies.Click += new System.EventHandler(this.movies_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(804, 20);
            this.customer.Margin = new System.Windows.Forms.Padding(4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(112, 37);
            this.customer.TabIndex = 14;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(924, 78);
            this.employee.Margin = new System.Windows.Forms.Padding(4);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(112, 37);
            this.employee.TabIndex = 15;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(804, 78);
            this.reports.Margin = new System.Windows.Forms.Padding(4);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(112, 37);
            this.reports.TabIndex = 16;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(1041, 78);
            this.signout.Margin = new System.Windows.Forms.Padding(4);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(112, 37);
            this.signout.TabIndex = 17;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(684, 78);
            this.actors.Margin = new System.Windows.Forms.Padding(4);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(112, 37);
            this.actors.TabIndex = 18;
            this.actors.Text = "Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(924, 20);
            this.rental.Margin = new System.Windows.Forms.Padding(4);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(112, 37);
            this.rental.TabIndex = 19;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // RentalGrid
            // 
            this.RentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.MovieID,
            this.MovieName,
            this.AvailableDate});
            this.RentalGrid.Location = new System.Drawing.Point(349, 149);
            this.RentalGrid.Name = "RentalGrid";
            this.RentalGrid.RowHeadersWidth = 51;
            this.RentalGrid.RowTemplate.Height = 24;
            this.RentalGrid.Size = new System.Drawing.Size(567, 377);
            this.RentalGrid.TabIndex = 20;
            // 
            // CID
            // 
            this.CID.HeaderText = "CustomerID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.Width = 125;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.MinimumWidth = 6;
            this.MovieID.Name = "MovieID";
            this.MovieID.Width = 125;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "MovieName";
            this.MovieName.MinimumWidth = 6;
            this.MovieName.Name = "MovieName";
            this.MovieName.Width = 125;
            // 
            // AvailableDate
            // 
            this.AvailableDate.HeaderText = "AvailableDate";
            this.AvailableDate.MinimumWidth = 6;
            this.AvailableDate.Name = "AvailableDate";
            this.AvailableDate.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Customer ID";
            // 
            // cust_ID
            // 
            this.cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_ID.Location = new System.Drawing.Point(22, 427);
            this.cust_ID.Name = "cust_ID";
            this.cust_ID.Size = new System.Drawing.Size(298, 34);
            this.cust_ID.TabIndex = 22;
            // 
            // RentalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 539);
            this.Controls.Add(this.cust_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentalGrid);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pickupDate);
            this.Controls.Add(this.ShowBestSellers);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rental_ID);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterIDLabel);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RentalScreen";
            this.Text = "Rental Screen";
            this.Load += new System.EventHandler(this.RentalScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EnterIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox returnDate;
        private System.Windows.Forms.TextBox Rental_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowBestSellers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pickupDate;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;
        private System.Windows.Forms.Button movies;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button actors;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.DataGridView RentalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cust_ID;
    }
}

