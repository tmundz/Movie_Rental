
namespace Movie_Rental_System
{
    partial class movieinfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridLabel1 = new System.Windows.Forms.Label();
            this.MovieID_Input = new System.Windows.Forms.TextBox();
            this.Search_Movie = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rating_Input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumCopys_Input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Fee_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieType_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieName_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Add_Movie = new System.Windows.Forms.Button();
            this.Delete_Movie = new System.Windows.Forms.Button();
            this.Edit_Movie = new System.Windows.Forms.Button();
            this.Movies = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistributionFEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfCopys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actornamel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actornamef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.actors = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.employee2 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.movies2 = new System.Windows.Forms.Button();
            this.rental = new System.Windows.Forms.Button();
            this.Movie_Queues = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvbDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Queues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(514, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Movie ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GridLabel1
            // 
            this.GridLabel1.AutoSize = true;
            this.GridLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridLabel1.Location = new System.Drawing.Point(468, 399);
            this.GridLabel1.Name = "GridLabel1";
            this.GridLabel1.Size = new System.Drawing.Size(166, 25);
            this.GridLabel1.TabIndex = 32;
            this.GridLabel1.Text = "Movies in Queue:";
            this.GridLabel1.Click += new System.EventHandler(this.label8_Click);
            // 
            // MovieID_Input
            // 
            this.MovieID_Input.Location = new System.Drawing.Point(25, 214);
            this.MovieID_Input.Margin = new System.Windows.Forms.Padding(4);
            this.MovieID_Input.Name = "MovieID_Input";
            this.MovieID_Input.Size = new System.Drawing.Size(344, 22);
            this.MovieID_Input.TabIndex = 3;
            this.MovieID_Input.TextChanged += new System.EventHandler(this.MovieID_Input_TextChanged);
            // 
            // Search_Movie
            // 
            this.Search_Movie.Location = new System.Drawing.Point(25, 277);
            this.Search_Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Movie.Name = "Search_Movie";
            this.Search_Movie.Size = new System.Drawing.Size(100, 28);
            this.Search_Movie.TabIndex = 4;
            this.Search_Movie.Text = "Search";
            this.Search_Movie.UseVisualStyleBackColor = true;
            this.Search_Movie.Click += new System.EventHandler(this.Search_Movie_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Rating_Input);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.NumCopys_Input);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Fee_Input);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.MovieType_Input);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.MovieName_Input);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(360, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Rating_Input
            // 
            this.Rating_Input.Location = new System.Drawing.Point(4, 222);
            this.Rating_Input.Margin = new System.Windows.Forms.Padding(4);
            this.Rating_Input.Name = "Rating_Input";
            this.Rating_Input.Size = new System.Drawing.Size(344, 22);
            this.Rating_Input.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rating:";
            // 
            // NumCopys_Input
            // 
            this.NumCopys_Input.Location = new System.Drawing.Point(4, 160);
            this.NumCopys_Input.Margin = new System.Windows.Forms.Padding(4);
            this.NumCopys_Input.Name = "NumCopys_Input";
            this.NumCopys_Input.Size = new System.Drawing.Size(344, 22);
            this.NumCopys_Input.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Copies:";
            // 
            // Fee_Input
            // 
            this.Fee_Input.Location = new System.Drawing.Point(4, 280);
            this.Fee_Input.Margin = new System.Windows.Forms.Padding(4);
            this.Fee_Input.Name = "Fee_Input";
            this.Fee_Input.Size = new System.Drawing.Size(344, 22);
            this.Fee_Input.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Distribution Fee:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MovieType_Input
            // 
            this.MovieType_Input.Location = new System.Drawing.Point(4, 99);
            this.MovieType_Input.Margin = new System.Windows.Forms.Padding(4);
            this.MovieType_Input.Name = "MovieType_Input";
            this.MovieType_Input.Size = new System.Drawing.Size(344, 22);
            this.MovieType_Input.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movie Type:";
            // 
            // MovieName_Input
            // 
            this.MovieName_Input.Location = new System.Drawing.Point(4, 37);
            this.MovieName_Input.Margin = new System.Windows.Forms.Padding(4);
            this.MovieName_Input.Name = "MovieName_Input";
            this.MovieName_Input.Size = new System.Drawing.Size(344, 22);
            this.MovieName_Input.TabIndex = 6;
            this.MovieName_Input.TextChanged += new System.EventHandler(this.MovieName_Input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Movie Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 337);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 339);
            this.tabControl1.TabIndex = 5;
            // 
            // Add_Movie
            // 
            this.Add_Movie.Location = new System.Drawing.Point(133, 277);
            this.Add_Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Movie.Name = "Add_Movie";
            this.Add_Movie.Size = new System.Drawing.Size(100, 28);
            this.Add_Movie.TabIndex = 7;
            this.Add_Movie.Text = "Add";
            this.Add_Movie.UseVisualStyleBackColor = true;
            this.Add_Movie.Click += new System.EventHandler(this.Add_Movie_Click);
            // 
            // Delete_Movie
            // 
            this.Delete_Movie.Location = new System.Drawing.Point(241, 277);
            this.Delete_Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Movie.Name = "Delete_Movie";
            this.Delete_Movie.Size = new System.Drawing.Size(100, 28);
            this.Delete_Movie.TabIndex = 8;
            this.Delete_Movie.Text = "Delete";
            this.Delete_Movie.UseVisualStyleBackColor = true;
            this.Delete_Movie.Click += new System.EventHandler(this.Delete_Movie_Click);
            // 
            // Edit_Movie
            // 
            this.Edit_Movie.Location = new System.Drawing.Point(349, 277);
            this.Edit_Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Movie.Name = "Edit_Movie";
            this.Edit_Movie.Size = new System.Drawing.Size(100, 28);
            this.Edit_Movie.TabIndex = 9;
            this.Edit_Movie.Text = "Edit";
            this.Edit_Movie.UseVisualStyleBackColor = true;
            this.Edit_Movie.Click += new System.EventHandler(this.Edit_Movie_Click);
            // 
            // Movies
            // 
            this.Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.MovieName,
            this.MovieType,
            this.DistributionFEE,
            this.NumberOfCopys,
            this.Rating,
            this.actornamel,
            this.actornamef});
            this.Movies.Location = new System.Drawing.Point(473, 146);
            this.Movies.Margin = new System.Windows.Forms.Padding(2);
            this.Movies.Name = "Movies";
            this.Movies.RowHeadersWidth = 51;
            this.Movies.RowTemplate.Height = 24;
            this.Movies.Size = new System.Drawing.Size(730, 233);
            this.Movies.TabIndex = 10;
            this.Movies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MID
            // 
            this.MID.HeaderText = "ID";
            this.MID.MinimumWidth = 6;
            this.MID.Name = "MID";
            this.MID.Width = 50;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Movie Name";
            this.MovieName.MinimumWidth = 6;
            this.MovieName.Name = "MovieName";
            this.MovieName.Width = 125;
            // 
            // MovieType
            // 
            this.MovieType.HeaderText = "Movie Type";
            this.MovieType.MinimumWidth = 6;
            this.MovieType.Name = "MovieType";
            this.MovieType.Width = 125;
            // 
            // DistributionFEE
            // 
            this.DistributionFEE.HeaderText = "DistributionFEE";
            this.DistributionFEE.MinimumWidth = 6;
            this.DistributionFEE.Name = "DistributionFEE";
            this.DistributionFEE.Width = 125;
            // 
            // NumberOfCopys
            // 
            this.NumberOfCopys.HeaderText = "NumberOfCopys";
            this.NumberOfCopys.MinimumWidth = 6;
            this.NumberOfCopys.Name = "NumberOfCopys";
            this.NumberOfCopys.Width = 125;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Ratings";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // actornamel
            // 
            this.actornamel.HeaderText = "Actor Last Name";
            this.actornamel.MinimumWidth = 6;
            this.actornamel.Name = "actornamel";
            this.actornamel.Width = 125;
            // 
            // actornamef
            // 
            this.actornamef.HeaderText = "Actor First Name";
            this.actornamef.MinimumWidth = 6;
            this.actornamef.Name = "actornamef";
            this.actornamef.Width = 125;
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(1139, 15);
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
            "Reports",
            "--Select A Screen--",
            "Movies",
            "Actors",
            "Employees",
            "Customer",
            "Rental",
            "Reports"});
            this.ChooseScreen.Location = new System.Drawing.Point(969, 23);
            this.ChooseScreen.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(160, 24);
            this.ChooseScreen.TabIndex = 12;
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(27, 81);
            this.actors.Margin = new System.Windows.Forms.Padding(4);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(112, 37);
            this.actors.TabIndex = 30;
            this.actors.Text = "Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(388, 81);
            this.signout.Margin = new System.Windows.Forms.Padding(4);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(112, 37);
            this.signout.TabIndex = 29;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(147, 81);
            this.reports.Margin = new System.Windows.Forms.Padding(4);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(112, 37);
            this.reports.TabIndex = 28;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // employee2
            // 
            this.employee2.Location = new System.Drawing.Point(268, 81);
            this.employee2.Margin = new System.Windows.Forms.Padding(4);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(112, 37);
            this.employee2.TabIndex = 27;
            this.employee2.Text = "Employee";
            this.employee2.UseVisualStyleBackColor = true;
            this.employee2.Click += new System.EventHandler(this.employee2_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(147, 23);
            this.customer.Margin = new System.Windows.Forms.Padding(4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(112, 37);
            this.customer.TabIndex = 26;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // movies2
            // 
            this.movies2.Location = new System.Drawing.Point(27, 23);
            this.movies2.Margin = new System.Windows.Forms.Padding(4);
            this.movies2.Name = "movies2";
            this.movies2.Size = new System.Drawing.Size(112, 37);
            this.movies2.TabIndex = 25;
            this.movies2.Text = "Movies";
            this.movies2.UseVisualStyleBackColor = true;
            this.movies2.Click += new System.EventHandler(this.movies2_Click);
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(268, 23);
            this.rental.Margin = new System.Windows.Forms.Padding(4);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(112, 37);
            this.rental.TabIndex = 31;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // Movie_Queues
            // 
            this.Movie_Queues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Movie_Queues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.MovieID,
            this.Movie_Name,
            this.AvbDate});
            this.Movie_Queues.Location = new System.Drawing.Point(473, 439);
            this.Movie_Queues.Name = "Movie_Queues";
            this.Movie_Queues.RowHeadersWidth = 51;
            this.Movie_Queues.RowTemplate.Height = 24;
            this.Movie_Queues.Size = new System.Drawing.Size(730, 233);
            this.Movie_Queues.TabIndex = 33;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "Movie ID";
            this.MovieID.MinimumWidth = 6;
            this.MovieID.Name = "MovieID";
            this.MovieID.Width = 125;
            // 
            // Movie_Name
            // 
            this.Movie_Name.HeaderText = "Movie Name";
            this.Movie_Name.MinimumWidth = 6;
            this.Movie_Name.Name = "Movie_Name";
            this.Movie_Name.Width = 125;
            // 
            // AvbDate
            // 
            this.AvbDate.HeaderText = "Available Date";
            this.AvbDate.MinimumWidth = 6;
            this.AvbDate.Name = "AvbDate";
            this.AvbDate.Width = 125;
            // 
            // movieinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 689);
            this.Controls.Add(this.Movie_Queues);
            this.Controls.Add(this.GridLabel1);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.employee2);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movies2);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.Edit_Movie);
            this.Controls.Add(this.Delete_Movie);
            this.Controls.Add(this.Add_Movie);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Search_Movie);
            this.Controls.Add(this.MovieID_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "movieinfo";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.movieinfo_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Movie_Queues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieID_Input;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox Fee_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieType_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MovieName_Input;
        private System.Windows.Forms.TextBox Rating_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumCopys_Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_Movie;
        private System.Windows.Forms.Button Delete_Movie;
        private System.Windows.Forms.Button Edit_Movie;
        private System.Windows.Forms.DataGridView Movies;
        private System.Windows.Forms.Button Search_Movie;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;
        private System.Windows.Forms.Button actors;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button employee2;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button movies2;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistributionFEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfCopys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn actornamel;
        private System.Windows.Forms.DataGridViewTextBoxColumn actornamef;
        private System.Windows.Forms.Label GridLabel1;
        private System.Windows.Forms.DataGridView Movie_Queues;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvbDate;
    }
}
