
namespace Movie_Rental_System
{
    partial class Employee
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
            this.EID_Input = new System.Windows.Forms.TextBox();
            this.EmployeeTitle = new System.Windows.Forms.Label();
            this.EnterEID = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.EInfo = new System.Windows.Forms.TabPage();
            this.SocialSecurity_Input = new System.Windows.Forms.TextBox();
            this.SSL = new System.Windows.Forms.Label();
            this.Telephone_Input = new System.Windows.Forms.TextBox();
            this.PhoneL = new System.Windows.Forms.Label();
            this.HourlyRate_Input = new System.Windows.Forms.TextBox();
            this.HourlyL = new System.Windows.Forms.Label();
            this.StartDate_Input = new System.Windows.Forms.TextBox();
            this.startdateL = new System.Windows.Forms.Label();
            this.Zip_Input = new System.Windows.Forms.TextBox();
            this.ZipL = new System.Windows.Forms.Label();
            this.State_Input = new System.Windows.Forms.TextBox();
            this.StateL = new System.Windows.Forms.Label();
            this.City_Input = new System.Windows.Forms.TextBox();
            this.CityL = new System.Windows.Forms.Label();
            this.LastName_Input = new System.Windows.Forms.TextBox();
            this.LastNameL = new System.Windows.Forms.Label();
            this.FirstName_Input = new System.Windows.Forms.TextBox();
            this.FirstNameL = new System.Windows.Forms.Label();
            this.EmployeeInfo = new System.Windows.Forms.TabControl();
            this.EmployeesData = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SocialSecurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actors = new System.Windows.Forms.Button();
            this.movies = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.employee2 = new System.Windows.Forms.Button();
            this.rental = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.EInfo.SuspendLayout();
            this.EmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).BeginInit();
            this.SuspendLayout();
            // 
            // EID_Input
            // 
            this.EID_Input.Location = new System.Drawing.Point(1, 194);
            this.EID_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EID_Input.Name = "EID_Input";
            this.EID_Input.Size = new System.Drawing.Size(423, 22);
            this.EID_Input.TabIndex = 0;
            this.EID_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeeTitle
            // 
            this.EmployeeTitle.AutoSize = true;
            this.EmployeeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTitle.Location = new System.Drawing.Point(16, 15);
            this.EmployeeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeTitle.Name = "EmployeeTitle";
            this.EmployeeTitle.Size = new System.Drawing.Size(198, 46);
            this.EmployeeTitle.TabIndex = 1;
            this.EmployeeTitle.Text = "Employee";
            this.EmployeeTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterEID
            // 
            this.EnterEID.AutoSize = true;
            this.EnterEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterEID.Location = new System.Drawing.Point(1, 159);
            this.EnterEID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterEID.Name = "EnterEID";
            this.EnterEID.Size = new System.Drawing.Size(249, 31);
            this.EnterEID.TabIndex = 2;
            this.EnterEID.Text = "Enter Employee ID:";
            this.EnterEID.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(3, 226);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 28);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(111, 226);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(325, 226);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 28);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(219, 226);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // EInfo
            // 
            this.EInfo.Controls.Add(this.SocialSecurity_Input);
            this.EInfo.Controls.Add(this.SSL);
            this.EInfo.Controls.Add(this.Telephone_Input);
            this.EInfo.Controls.Add(this.PhoneL);
            this.EInfo.Controls.Add(this.HourlyRate_Input);
            this.EInfo.Controls.Add(this.HourlyL);
            this.EInfo.Controls.Add(this.StartDate_Input);
            this.EInfo.Controls.Add(this.startdateL);
            this.EInfo.Controls.Add(this.Zip_Input);
            this.EInfo.Controls.Add(this.ZipL);
            this.EInfo.Controls.Add(this.State_Input);
            this.EInfo.Controls.Add(this.StateL);
            this.EInfo.Controls.Add(this.City_Input);
            this.EInfo.Controls.Add(this.CityL);
            this.EInfo.Controls.Add(this.LastName_Input);
            this.EInfo.Controls.Add(this.LastNameL);
            this.EInfo.Controls.Add(this.FirstName_Input);
            this.EInfo.Controls.Add(this.FirstNameL);
            this.EInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EInfo.Location = new System.Drawing.Point(4, 25);
            this.EInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EInfo.Name = "EInfo";
            this.EInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EInfo.Size = new System.Drawing.Size(1039, 258);
            this.EInfo.TabIndex = 1;
            this.EInfo.Text = "Employee Info";
            this.EInfo.UseVisualStyleBackColor = true;
            // 
            // SocialSecurity_Input
            // 
            this.SocialSecurity_Input.Location = new System.Drawing.Point(701, 32);
            this.SocialSecurity_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SocialSecurity_Input.Name = "SocialSecurity_Input";
            this.SocialSecurity_Input.Size = new System.Drawing.Size(156, 30);
            this.SocialSecurity_Input.TabIndex = 22;
            this.SocialSecurity_Input.TextChanged += new System.EventHandler(this.SSText_TextChanged);
            // 
            // SSL
            // 
            this.SSL.AutoSize = true;
            this.SSL.Location = new System.Drawing.Point(696, 4);
            this.SSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SSL.Name = "SSL";
            this.SSL.Size = new System.Drawing.Size(159, 25);
            this.SSL.TabIndex = 21;
            this.SSL.Text = "Social Security#:";
            // 
            // Telephone_Input
            // 
            this.Telephone_Input.Location = new System.Drawing.Point(484, 160);
            this.Telephone_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Telephone_Input.Name = "Telephone_Input";
            this.Telephone_Input.Size = new System.Drawing.Size(132, 30);
            this.Telephone_Input.TabIndex = 20;
            this.Telephone_Input.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // PhoneL
            // 
            this.PhoneL.AutoSize = true;
            this.PhoneL.Location = new System.Drawing.Point(477, 132);
            this.PhoneL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneL.Name = "PhoneL";
            this.PhoneL.Size = new System.Drawing.Size(112, 25);
            this.PhoneL.TabIndex = 19;
            this.PhoneL.Text = "Telephone:";
            // 
            // HourlyRate_Input
            // 
            this.HourlyRate_Input.Location = new System.Drawing.Point(484, 96);
            this.HourlyRate_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HourlyRate_Input.Name = "HourlyRate_Input";
            this.HourlyRate_Input.Size = new System.Drawing.Size(132, 30);
            this.HourlyRate_Input.TabIndex = 18;
            this.HourlyRate_Input.TextChanged += new System.EventHandler(this.Hourlytext_TextChanged);
            // 
            // HourlyL
            // 
            this.HourlyL.AutoSize = true;
            this.HourlyL.Location = new System.Drawing.Point(479, 68);
            this.HourlyL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HourlyL.Name = "HourlyL";
            this.HourlyL.Size = new System.Drawing.Size(114, 25);
            this.HourlyL.TabIndex = 17;
            this.HourlyL.Text = "HourlyRate:";
            // 
            // StartDate_Input
            // 
            this.StartDate_Input.Location = new System.Drawing.Point(484, 32);
            this.StartDate_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDate_Input.Name = "StartDate_Input";
            this.StartDate_Input.Size = new System.Drawing.Size(132, 30);
            this.StartDate_Input.TabIndex = 16;
            this.StartDate_Input.TextChanged += new System.EventHandler(this.StartDateText_TextChanged);
            // 
            // startdateL
            // 
            this.startdateL.AutoSize = true;
            this.startdateL.Location = new System.Drawing.Point(479, 4);
            this.startdateL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startdateL.Name = "startdateL";
            this.startdateL.Size = new System.Drawing.Size(105, 25);
            this.startdateL.TabIndex = 15;
            this.startdateL.Text = "Start Date:";
            // 
            // Zip_Input
            // 
            this.Zip_Input.Location = new System.Drawing.Point(0, 160);
            this.Zip_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Zip_Input.Name = "Zip_Input";
            this.Zip_Input.Size = new System.Drawing.Size(132, 30);
            this.Zip_Input.TabIndex = 14;
            this.Zip_Input.TextChanged += new System.EventHandler(this.ZipText_TextChanged);
            // 
            // ZipL
            // 
            this.ZipL.AutoSize = true;
            this.ZipL.Location = new System.Drawing.Point(4, 132);
            this.ZipL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZipL.Name = "ZipL";
            this.ZipL.Size = new System.Drawing.Size(98, 25);
            this.ZipL.TabIndex = 13;
            this.ZipL.Text = "Zip Code:";
            // 
            // State_Input
            // 
            this.State_Input.Location = new System.Drawing.Point(152, 96);
            this.State_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.State_Input.Name = "State_Input";
            this.State_Input.Size = new System.Drawing.Size(113, 30);
            this.State_Input.TabIndex = 12;
            this.State_Input.TextChanged += new System.EventHandler(this.StateText_TextChanged);
            // 
            // StateL
            // 
            this.StateL.AutoSize = true;
            this.StateL.Location = new System.Drawing.Point(147, 68);
            this.StateL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateL.Name = "StateL";
            this.StateL.Size = new System.Drawing.Size(64, 25);
            this.StateL.TabIndex = 11;
            this.StateL.Text = "State:";
            // 
            // City_Input
            // 
            this.City_Input.Location = new System.Drawing.Point(4, 96);
            this.City_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.City_Input.Name = "City_Input";
            this.City_Input.Size = new System.Drawing.Size(117, 30);
            this.City_Input.TabIndex = 10;
            this.City_Input.TextChanged += new System.EventHandler(this.CityText_TextChanged);
            // 
            // CityL
            // 
            this.CityL.AutoSize = true;
            this.CityL.Location = new System.Drawing.Point(4, 68);
            this.CityL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityL.Name = "CityL";
            this.CityL.Size = new System.Drawing.Size(52, 25);
            this.CityL.TabIndex = 9;
            this.CityL.Text = "City:";
            // 
            // LastName_Input
            // 
            this.LastName_Input.Location = new System.Drawing.Point(152, 32);
            this.LastName_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastName_Input.Name = "LastName_Input";
            this.LastName_Input.Size = new System.Drawing.Size(113, 30);
            this.LastName_Input.TabIndex = 8;
            this.LastName_Input.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // LastNameL
            // 
            this.LastNameL.AutoSize = true;
            this.LastNameL.Location = new System.Drawing.Point(147, 4);
            this.LastNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameL.Name = "LastNameL";
            this.LastNameL.Size = new System.Drawing.Size(112, 25);
            this.LastNameL.TabIndex = 2;
            this.LastNameL.Text = "Last Name:";
            this.LastNameL.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FirstName_Input
            // 
            this.FirstName_Input.Location = new System.Drawing.Point(4, 32);
            this.FirstName_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstName_Input.Name = "FirstName_Input";
            this.FirstName_Input.Size = new System.Drawing.Size(117, 30);
            this.FirstName_Input.TabIndex = 1;
            this.FirstName_Input.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // FirstNameL
            // 
            this.FirstNameL.AutoSize = true;
            this.FirstNameL.Location = new System.Drawing.Point(1, 4);
            this.FirstNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameL.Name = "FirstNameL";
            this.FirstNameL.Size = new System.Drawing.Size(112, 25);
            this.FirstNameL.TabIndex = 0;
            this.FirstNameL.Text = "First Name:";
            this.FirstNameL.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Controls.Add(this.EInfo);
            this.EmployeeInfo.Location = new System.Drawing.Point(1, 262);
            this.EmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.SelectedIndex = 0;
            this.EmployeeInfo.Size = new System.Drawing.Size(1047, 287);
            this.EmployeeInfo.TabIndex = 7;
            // 
            // EmployeesData
            // 
            this.EmployeesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.SocialSecurity,
            this.FirstName,
            this.LastName,
            this.City,
            this.State,
            this.Zip,
            this.StartDate,
            this.HourlyRate,
            this.Telephone});
            this.EmployeesData.Location = new System.Drawing.Point(513, 13);
            this.EmployeesData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeesData.Name = "EmployeesData";
            this.EmployeesData.RowHeadersWidth = 51;
            this.EmployeesData.Size = new System.Drawing.Size(535, 267);
            this.EmployeesData.TabIndex = 8;
            this.EmployeesData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EID
            // 
            this.EID.HeaderText = "ID";
            this.EID.MinimumWidth = 6;
            this.EID.Name = "EID";
            this.EID.Width = 125;
            // 
            // SocialSecurity
            // 
            this.SocialSecurity.HeaderText = "Social Secuirty";
            this.SocialSecurity.MinimumWidth = 6;
            this.SocialSecurity.Name = "SocialSecurity";
            this.SocialSecurity.Width = 125;
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
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 125;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip Code";
            this.Zip.MinimumWidth = 6;
            this.Zip.Name = "Zip";
            this.Zip.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // HourlyRate
            // 
            this.HourlyRate.HeaderText = "Hourly Rate";
            this.HourlyRate.MinimumWidth = 6;
            this.HourlyRate.Name = "HourlyRate";
            this.HourlyRate.Width = 125;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(16, 118);
            this.actors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(112, 37);
            this.actors.TabIndex = 24;
            this.actors.Text = "Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            // 
            // movies
            // 
            this.movies.Location = new System.Drawing.Point(16, 60);
            this.movies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(112, 37);
            this.movies.TabIndex = 19;
            this.movies.Text = "Movies";
            this.movies.UseVisualStyleBackColor = true;
            this.movies.Click += new System.EventHandler(this.movies_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(136, 60);
            this.customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(112, 37);
            this.customer.TabIndex = 20;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // employee2
            // 
            this.employee2.Location = new System.Drawing.Point(256, 60);
            this.employee2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employee2.Name = "employee2";
            this.employee2.Size = new System.Drawing.Size(112, 37);
            this.employee2.TabIndex = 26;
            this.employee2.Text = "Employee";
            this.employee2.UseVisualStyleBackColor = true;
            this.employee2.Click += new System.EventHandler(this.employee2_Click);
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(376, 60);
            this.rental.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(112, 37);
            this.rental.TabIndex = 25;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.rental_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(136, 118);
            this.reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(112, 37);
            this.reports.TabIndex = 22;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(256, 118);
            this.signout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(112, 37);
            this.signout.TabIndex = 23;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(403, 5);
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
            this.ChooseScreen.Location = new System.Drawing.Point(233, 15);
            this.ChooseScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(160, 24);
            this.ChooseScreen.TabIndex = 12;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.employee2);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.movies);
            this.Controls.Add(this.EmployeesData);
            this.Controls.Add(this.EmployeeInfo);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.EnterEID);
            this.Controls.Add(this.EmployeeTitle);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.EID_Input);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.EInfo.ResumeLayout(false);
            this.EInfo.PerformLayout();
            this.EmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EID_Input;
        private System.Windows.Forms.Label EmployeeTitle;
        private System.Windows.Forms.Label EnterEID;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TabPage EInfo;
        private System.Windows.Forms.Label FirstNameL;
        private System.Windows.Forms.TabControl EmployeeInfo;
        private System.Windows.Forms.TextBox FirstName_Input;
        private System.Windows.Forms.Label LastNameL;
        private System.Windows.Forms.TextBox LastName_Input;
        private System.Windows.Forms.TextBox Telephone_Input;
        private System.Windows.Forms.Label PhoneL;
        private System.Windows.Forms.TextBox HourlyRate_Input;
        private System.Windows.Forms.Label HourlyL;
        private System.Windows.Forms.TextBox StartDate_Input;
        private System.Windows.Forms.Label startdateL;
        private System.Windows.Forms.TextBox Zip_Input;
        private System.Windows.Forms.Label ZipL;
        private System.Windows.Forms.TextBox State_Input;
        private System.Windows.Forms.Label StateL;
        private System.Windows.Forms.TextBox City_Input;
        private System.Windows.Forms.Label CityL;
        private System.Windows.Forms.DataGridView EmployeesData;
        private System.Windows.Forms.TextBox SocialSecurity_Input;
        private System.Windows.Forms.Label SSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SocialSecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourlyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.Button employee2;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Button actors;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button movies;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;

    }
}