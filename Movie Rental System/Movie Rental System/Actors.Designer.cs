

namespace Movie_Rental_System
{
    partial class actorinfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ActorID_Input = new System.Windows.Forms.TextBox();
            this.Search_Actor = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MID_Add = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Rating_Input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Gender_Input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Age_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActorFirstName_Input = new System.Windows.Forms.TextBox();
            this.ActorLastName_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Add_Actor = new System.Windows.Forms.Button();
            this.Delete_Actor = new System.Windows.Forms.Button();
            this.Edit_Actor = new System.Windows.Forms.Button();
            this.Actors = new System.Windows.Forms.DataGridView();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental = new System.Windows.Forms.Button();
            this.actors2 = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.employee2 = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.movies2 = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.actor_grid = new System.Windows.Forms.DataGridView();
            this.Appeared_AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appeared_MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieRentalDatabaseDataSet = new Movie_Rental_System.MovieRentalDatabaseDataSet();
            this.movieRentalDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieRentalDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AppearLabel = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Actors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(556, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Actor ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ActorID_Input
            // 
            this.ActorID_Input.Location = new System.Drawing.Point(25, 214);
            this.ActorID_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActorID_Input.Name = "ActorID_Input";
            this.ActorID_Input.Size = new System.Drawing.Size(344, 22);
            this.ActorID_Input.TabIndex = 3;
            // 
            // Search_Actor
            // 
            this.Search_Actor.Location = new System.Drawing.Point(25, 277);
            this.Search_Actor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_Actor.Name = "Search_Actor";
            this.Search_Actor.Size = new System.Drawing.Size(100, 28);
            this.Search_Actor.TabIndex = 4;
            this.Search_Actor.Text = "Search";
            this.Search_Actor.UseVisualStyleBackColor = true;
            this.Search_Actor.Click += new System.EventHandler(this.Search_Actor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MID_Add);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Rating_Input);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Gender_Input);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Age_Input);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ActorFirstName_Input);
            this.tabPage2.Controls.Add(this.ActorLastName_Input);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(781, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actor Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // MID_Add
            // 
            this.MID_Add.Location = new System.Drawing.Point(399, 48);
            this.MID_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MID_Add.Name = "MID_Add";
            this.MID_Add.Size = new System.Drawing.Size(365, 22);
            this.MID_Add.TabIndex = 16;
            this.MID_Add.TextChanged += new System.EventHandler(this.moviesappeared_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "MID to Add:";
            // 
            // Rating_Input
            // 
            this.Rating_Input.Location = new System.Drawing.Point(4, 233);
            this.Rating_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rating_Input.Name = "Rating_Input";
            this.Rating_Input.Size = new System.Drawing.Size(365, 22);
            this.Rating_Input.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rating:";
            // 
            // Gender_Input
            // 
            this.Gender_Input.Location = new System.Drawing.Point(4, 171);
            this.Gender_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gender_Input.Name = "Gender_Input";
            this.Gender_Input.Size = new System.Drawing.Size(365, 22);
            this.Gender_Input.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gender:";
            // 
            // Age_Input
            // 
            this.Age_Input.Location = new System.Drawing.Point(4, 110);
            this.Age_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Age_Input.Name = "Age_Input";
            this.Age_Input.Size = new System.Drawing.Size(365, 22);
            this.Age_Input.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age:";
            // 
            // ActorFirstName_Input
            // 
            this.ActorFirstName_Input.Location = new System.Drawing.Point(4, 48);
            this.ActorFirstName_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActorFirstName_Input.Name = "ActorFirstName_Input";
            this.ActorFirstName_Input.Size = new System.Drawing.Size(180, 22);
            this.ActorFirstName_Input.TabIndex = 6;
            // 
            // ActorLastName_Input
            // 
            this.ActorLastName_Input.Location = new System.Drawing.Point(189, 48);
            this.ActorLastName_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActorLastName_Input.Name = "ActorLastName_Input";
            this.ActorLastName_Input.Size = new System.Drawing.Size(180, 22);
            this.ActorLastName_Input.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Last Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 337);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 311);
            this.tabControl1.TabIndex = 5;
            // 
            // Add_Actor
            // 
            this.Add_Actor.Location = new System.Drawing.Point(133, 277);
            this.Add_Actor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Actor.Name = "Add_Actor";
            this.Add_Actor.Size = new System.Drawing.Size(100, 28);
            this.Add_Actor.TabIndex = 7;
            this.Add_Actor.Text = "Add";
            this.Add_Actor.UseVisualStyleBackColor = true;
            this.Add_Actor.Click += new System.EventHandler(this.Add_Actor_Click);
            // 
            // Delete_Actor
            // 
            this.Delete_Actor.Location = new System.Drawing.Point(241, 277);
            this.Delete_Actor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_Actor.Name = "Delete_Actor";
            this.Delete_Actor.Size = new System.Drawing.Size(100, 28);
            this.Delete_Actor.TabIndex = 8;
            this.Delete_Actor.Text = "Delete";
            this.Delete_Actor.UseVisualStyleBackColor = true;
            this.Delete_Actor.Click += new System.EventHandler(this.Delete_Actor_Click);
            // 
            // Edit_Actor
            // 
            this.Edit_Actor.Location = new System.Drawing.Point(349, 277);
            this.Edit_Actor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit_Actor.Name = "Edit_Actor";
            this.Edit_Actor.Size = new System.Drawing.Size(100, 28);
            this.Edit_Actor.TabIndex = 9;
            this.Edit_Actor.Text = "Edit";
            this.Edit_Actor.UseVisualStyleBackColor = true;
            this.Edit_Actor.Click += new System.EventHandler(this.Edit_Actor_Click);
            // 
            // Actors
            // 
            this.Actors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Actors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age,
            this.Rating});
            this.Actors.Location = new System.Drawing.Point(555, 123);
            this.Actors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Actors.Name = "Actors";
            this.Actors.RowHeadersWidth = 51;
            this.Actors.RowTemplate.Height = 24;
            this.Actors.Size = new System.Drawing.Size(731, 233);
            this.Actors.TabIndex = 10;
            this.Actors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AID
            // 
            this.AID.HeaderText = "ID";
            this.AID.MinimumWidth = 6;
            this.AID.Name = "AID";
            this.AID.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Ratings";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Width = 125;
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(253, 23);
            this.rental.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(112, 37);
            this.rental.TabIndex = 38;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // actors2
            // 
            this.actors2.Location = new System.Drawing.Point(13, 81);
            this.actors2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actors2.Name = "actors2";
            this.actors2.Size = new System.Drawing.Size(112, 37);
            this.actors2.TabIndex = 37;
            this.actors2.Text = "Actors";
            this.actors2.UseVisualStyleBackColor = true;
            this.actors2.Click += new System.EventHandler(this.button1_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(373, 81);
            this.signout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(112, 37);
            this.signout.TabIndex = 36;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(133, 81);
            this.reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(112, 37);
            this.reports.TabIndex = 35;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // employee2
            // 
            this.employee2.Location = new System.Drawing.Point(253, 81);
            this.employee2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(112, 37);
            this.employee2.TabIndex = 34;
            this.employee2.Text = "Employee";
            this.employee2.UseVisualStyleBackColor = true;
            this.employee2.Click += new System.EventHandler(this.employee2_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(133, 23);
            this.customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(112, 37);
            this.customer.TabIndex = 33;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // movies2
            // 
            this.movies2.Location = new System.Drawing.Point(13, 23);
            this.movies2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movies2.Name = "movies2";
            this.movies2.Size = new System.Drawing.Size(112, 37);
            this.movies2.TabIndex = 32;
            this.movies2.Text = "Movies";
            this.movies2.UseVisualStyleBackColor = true;
            this.movies2.Click += new System.EventHandler(this.movies2_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(1139, 15);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ChooseScreen.Location = new System.Drawing.Point(969, 23);
            this.ChooseScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(160, 24);
            this.ChooseScreen.TabIndex = 12;
            // 
            // actor_grid
            // 
            this.actor_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actor_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appeared_AID,
            this.Appeared_MID,
            this.movie_name});
            this.actor_grid.Location = new System.Drawing.Point(823, 409);
            this.actor_grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actor_grid.Name = "actor_grid";
            this.actor_grid.RowHeadersWidth = 51;
            this.actor_grid.Size = new System.Drawing.Size(463, 232);
            this.actor_grid.TabIndex = 39;
            // 
            // Appeared_AID
            // 
            this.Appeared_AID.HeaderText = "Actor ID";
            this.Appeared_AID.MinimumWidth = 6;
            this.Appeared_AID.Name = "Appeared_AID";
            this.Appeared_AID.Width = 125;
            // 
            // Appeared_MID
            // 
            this.Appeared_MID.HeaderText = "MID";
            this.Appeared_MID.MinimumWidth = 6;
            this.Appeared_MID.Name = "Appeared_MID";
            this.Appeared_MID.Width = 125;
            // 
            // movie_name
            // 
            this.movie_name.HeaderText = "Movie Name";
            this.movie_name.MinimumWidth = 6;
            this.movie_name.Name = "movie_name";
            this.movie_name.Width = 125;
            // 
            // movieRentalDatabaseDataSet
            // 
            this.movieRentalDatabaseDataSet.DataSetName = "MovieRentalDatabaseDataSet";
            this.movieRentalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieRentalDatabaseDataSetBindingSource
            // 
            this.movieRentalDatabaseDataSetBindingSource.DataSource = this.movieRentalDatabaseDataSet;
            this.movieRentalDatabaseDataSetBindingSource.Position = 0;
            // 
            // movieRentalDatabaseDataSetBindingSource1
            // 
            this.movieRentalDatabaseDataSetBindingSource1.DataSource = this.movieRentalDatabaseDataSet;
            this.movieRentalDatabaseDataSetBindingSource1.Position = 0;
            // 
            // AppearLabel
            // 
            this.AppearLabel.AutoSize = true;
            this.AppearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppearLabel.Location = new System.Drawing.Point(821, 377);
            this.AppearLabel.Name = "AppearLabel";
            this.AppearLabel.Size = new System.Drawing.Size(189, 25);
            this.AppearLabel.TabIndex = 40;
            this.AppearLabel.Text = "Movies appeared in:";
            // 
            // actorinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 654);
            this.Controls.Add(this.AppearLabel);
            this.Controls.Add(this.actor_grid);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.actors2);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.employee2);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movies2);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.Edit_Actor);
            this.Controls.Add(this.Delete_Actor);
            this.Controls.Add(this.Add_Actor);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Search_Actor);
            this.Controls.Add(this.ActorID_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "actorinfo";
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.actorinfo_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Actors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieRentalDatabaseDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ActorID_Input;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox Age_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ActorFirstName_Input;
        private System.Windows.Forms.TextBox ActorLastName_Input;
        private System.Windows.Forms.TextBox Rating_Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Gender_Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_Actor;
        private System.Windows.Forms.Button Delete_Actor;
        private System.Windows.Forms.Button Edit_Actor;
        private System.Windows.Forms.DataGridView Actors;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorLastName;
        private System.Windows.Forms.Button Search_Actor;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Button actors2;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button employee2;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button movies2;
        private System.Windows.Forms.TextBox MID_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView actor_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appeared_AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appeared_MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_name;
        private System.Windows.Forms.BindingSource movieRentalDatabaseDataSetBindingSource;
        private MovieRentalDatabaseDataSet movieRentalDatabaseDataSet;
        private System.Windows.Forms.BindingSource movieRentalDatabaseDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.Label AppearLabel;
    }
}
