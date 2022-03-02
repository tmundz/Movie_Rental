
namespace Movie_Rental_System
{
    partial class Reports
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TIncome = new System.Windows.Forms.Button();
            this.MRMovie = new System.Windows.Forms.Button();
            this.MACustomers = new System.Windows.Forms.Button();
            this.MPActor = new System.Windows.Forms.Button();
            this.TRentals = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.rental = new System.Windows.Forms.Button();
            this.movies2 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.employee2 = new System.Windows.Forms.Button();
            this.reports2 = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.actors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(258, 71);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 350);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports and Statistics";
            // 
            // SelectMonth
            // 
            this.SelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMonth.Location = new System.Drawing.Point(120, 102);
            this.SelectMonth.Margin = new System.Windows.Forms.Padding(2);
            this.SelectMonth.Name = "SelectMonth";
            this.SelectMonth.Size = new System.Drawing.Size(94, 28);
            this.SelectMonth.TabIndex = 2;
            this.SelectMonth.TextChanged += new System.EventHandler(this.SelectMonth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Month";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display Monthly Reports";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TIncome
            // 
            this.TIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIncome.Location = new System.Drawing.Point(13, 134);
            this.TIncome.Margin = new System.Windows.Forms.Padding(2);
            this.TIncome.Name = "TIncome";
            this.TIncome.Size = new System.Drawing.Size(164, 44);
            this.TIncome.TabIndex = 5;
            this.TIncome.Text = "Total Income";
            this.TIncome.UseVisualStyleBackColor = true;
            // 
            // MRMovie
            // 
            this.MRMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRMovie.Location = new System.Drawing.Point(13, 229);
            this.MRMovie.Margin = new System.Windows.Forms.Padding(2);
            this.MRMovie.Name = "MRMovie";
            this.MRMovie.Size = new System.Drawing.Size(164, 41);
            this.MRMovie.TabIndex = 6;
            this.MRMovie.Text = "Most Rented Movies";
            this.MRMovie.UseVisualStyleBackColor = true;
            // 
            // MACustomers
            // 
            this.MACustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MACustomers.Location = new System.Drawing.Point(13, 275);
            this.MACustomers.Margin = new System.Windows.Forms.Padding(2);
            this.MACustomers.Name = "MACustomers";
            this.MACustomers.Size = new System.Drawing.Size(164, 37);
            this.MACustomers.TabIndex = 7;
            this.MACustomers.Text = "Most Active Customers";
            this.MACustomers.UseVisualStyleBackColor = true;
            // 
            // MPActor
            // 
            this.MPActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPActor.Location = new System.Drawing.Point(13, 317);
            this.MPActor.Margin = new System.Windows.Forms.Padding(2);
            this.MPActor.Name = "MPActor";
            this.MPActor.Size = new System.Drawing.Size(164, 32);
            this.MPActor.TabIndex = 8;
            this.MPActor.Text = "Most Populer Actors";
            this.MPActor.UseVisualStyleBackColor = true;
            this.MPActor.Click += new System.EventHandler(this.button3_Click);
            // 
            // TRentals
            // 
            this.TRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRentals.Location = new System.Drawing.Point(13, 183);
            this.TRentals.Margin = new System.Windows.Forms.Padding(2);
            this.TRentals.Name = "TRentals";
            this.TRentals.Size = new System.Drawing.Size(164, 41);
            this.TRentals.TabIndex = 9;
            this.TRentals.Text = "Total Rentals and Returns";
            this.TRentals.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(139, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(30, 30);
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
            this.ChooseScreen.Location = new System.Drawing.Point(12, 12);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(121, 21);
            this.ChooseScreen.TabIndex = 12;
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(955, 16);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(84, 30);
            this.rental.TabIndex = 39;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // movies2
            // 
            this.movies2.Location = new System.Drawing.Point(775, 16);
            this.movies2.Name = "movies2";
            this.movies2.Size = new System.Drawing.Size(84, 30);
            this.movies2.TabIndex = 33;
            this.movies2.Text = "Movies";
            this.movies2.UseVisualStyleBackColor = true;
            this.movies2.Click += new System.EventHandler(this.movies2_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(865, 16);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(84, 30);
            this.customer.TabIndex = 34;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // employee2
            // 
            this.employee2.Location = new System.Drawing.Point(955, 65);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(84, 30);
            this.employee2.TabIndex = 35;
            this.employee2.Text = "Employee";
            this.employee2.UseVisualStyleBackColor = true;
            this.employee2.Click += new System.EventHandler(this.employee2_Click);
            // 
            // reports2
            // 
            this.reports2.Location = new System.Drawing.Point(865, 65);
            this.reports2.Name = "reports2";
            this.reports2.Size = new System.Drawing.Size(84, 30);
            this.reports2.TabIndex = 36;
            this.reports2.Text = "Reports";
            this.reports2.UseVisualStyleBackColor = true;
            this.reports2.Click += new System.EventHandler(this.button1_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(1045, 65);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(84, 30);
            this.signout.TabIndex = 37;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(775, 65);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(84, 30);
            this.actors.TabIndex = 38;
            this.actors.Text = "Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 466);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.reports2);
            this.Controls.Add(this.employee2);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movies2);
            this.Controls.Add(this.TRentals);
            this.Controls.Add(this.MPActor);
            this.Controls.Add(this.MACustomers);
            this.Controls.Add(this.MRMovie);
            this.Controls.Add(this.TIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMonth);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TIncome;
        private System.Windows.Forms.Button MRMovie;
        private System.Windows.Forms.Button MACustomers;
        private System.Windows.Forms.Button MPActor;
        private System.Windows.Forms.Button TRentals;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Button movies2;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button employee2;
        private System.Windows.Forms.Button reports2;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button actors;
    }
}