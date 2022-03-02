
namespace Movie_Rental_System
{
    partial class customer
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
            this.EnterCID = new System.Windows.Forms.Label();
            this.CID_Input = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.CInfo = new System.Windows.Forms.TabControl();
            this.CInfotab = new System.Windows.Forms.TabPage();
            this.AccT_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telephone_Input = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Rating_Input = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.Label();
            this.AccDate_Input = new System.Windows.Forms.TextBox();
            this.AccCreation = new System.Windows.Forms.Label();
            this.CC_Input = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.Label();
            this.Acc_Input = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.Label();
            this.Email_Input = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Zip_Input = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.State_Input = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.City_Input = new System.Windows.Forms.TextBox();
            this.CIty = new System.Windows.Forms.Label();
            this.LastName_Input = new System.Windows.Forms.TextBox();
            this.LastN = new System.Windows.Forms.Label();
            this.FirstName_Input = new System.Windows.Forms.TextBox();
            this.FirstN = new System.Windows.Forms.Label();
            this.CustomerTitle = new System.Windows.Forms.Label();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACC_Creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movies = new System.Windows.Forms.Button();
            this.rental = new System.Windows.Forms.Button();
            this.signout = new System.Windows.Forms.Button();
            this.customer2 = new System.Windows.Forms.Button();
            this.actors = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChooseScreen = new System.Windows.Forms.ComboBox();
            this.RentsGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedMovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CInfo.SuspendLayout();
            this.CInfotab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterCID
            // 
            this.EnterCID.AutoSize = true;
            this.EnterCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCID.Location = new System.Drawing.Point(7, 140);
            this.EnterCID.Name = "EnterCID";
            this.EnterCID.Size = new System.Drawing.Size(199, 26);
            this.EnterCID.TabIndex = 1;
            this.EnterCID.Text = "Enter Customer ID:";
            // 
            // CID_Input
            // 
            this.CID_Input.Location = new System.Drawing.Point(12, 169);
            this.CID_Input.Name = "CID_Input";
            this.CID_Input.Size = new System.Drawing.Size(318, 20);
            this.CID_Input.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 195);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(93, 195);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(174, 195);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(255, 195);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // CInfo
            // 
            this.CInfo.Controls.Add(this.CInfotab);
            this.CInfo.Location = new System.Drawing.Point(12, 224);
            this.CInfo.Name = "CInfo";
            this.CInfo.SelectedIndex = 0;
            this.CInfo.Size = new System.Drawing.Size(503, 213);
            this.CInfo.TabIndex = 7;
            this.CInfo.SelectedIndexChanged += new System.EventHandler(this.CInfo_SelectedIndexChanged);
            // 
            // CInfotab
            // 
            this.CInfotab.Controls.Add(this.AccT_Input);
            this.CInfotab.Controls.Add(this.label1);
            this.CInfotab.Controls.Add(this.Telephone_Input);
            this.CInfotab.Controls.Add(this.Phone);
            this.CInfotab.Controls.Add(this.Rating_Input);
            this.CInfotab.Controls.Add(this.Rating);
            this.CInfotab.Controls.Add(this.AccDate_Input);
            this.CInfotab.Controls.Add(this.AccCreation);
            this.CInfotab.Controls.Add(this.CC_Input);
            this.CInfotab.Controls.Add(this.CC);
            this.CInfotab.Controls.Add(this.Acc_Input);
            this.CInfotab.Controls.Add(this.Account);
            this.CInfotab.Controls.Add(this.Email_Input);
            this.CInfotab.Controls.Add(this.Email);
            this.CInfotab.Controls.Add(this.Zip_Input);
            this.CInfotab.Controls.Add(this.Zip);
            this.CInfotab.Controls.Add(this.State_Input);
            this.CInfotab.Controls.Add(this.State);
            this.CInfotab.Controls.Add(this.City_Input);
            this.CInfotab.Controls.Add(this.CIty);
            this.CInfotab.Controls.Add(this.LastName_Input);
            this.CInfotab.Controls.Add(this.LastN);
            this.CInfotab.Controls.Add(this.FirstName_Input);
            this.CInfotab.Controls.Add(this.FirstN);
            this.CInfotab.Location = new System.Drawing.Point(4, 22);
            this.CInfotab.Name = "CInfotab";
            this.CInfotab.Padding = new System.Windows.Forms.Padding(2);
            this.CInfotab.Size = new System.Drawing.Size(495, 187);
            this.CInfotab.TabIndex = 1;
            this.CInfotab.Text = "Customer Info";
            this.CInfotab.UseVisualStyleBackColor = true;
            this.CInfotab.Click += new System.EventHandler(this.CInfotab_Click);
            // 
            // AccT_Input
            // 
            this.AccT_Input.Location = new System.Drawing.Point(7, 164);
            this.AccT_Input.Name = "AccT_Input";
            this.AccT_Input.Size = new System.Drawing.Size(82, 20);
            this.AccT_Input.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Account Type:";
            // 
            // Telephone_Input
            // 
            this.Telephone_Input.Location = new System.Drawing.Point(308, 118);
            this.Telephone_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Telephone_Input.Name = "Telephone_Input";
            this.Telephone_Input.Size = new System.Drawing.Size(170, 20);
            this.Telephone_Input.TabIndex = 21;
            this.Telephone_Input.TextChanged += new System.EventHandler(this.Telephone_Input_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(304, 99);
            this.Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(88, 20);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "Telephone:";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // Rating_Input
            // 
            this.Rating_Input.Location = new System.Drawing.Point(307, 72);
            this.Rating_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Rating_Input.Name = "Rating_Input";
            this.Rating_Input.Size = new System.Drawing.Size(171, 20);
            this.Rating_Input.TabIndex = 19;
            this.Rating_Input.TextChanged += new System.EventHandler(this.Rating_Input_TextChanged);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(304, 53);
            this.Rating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(60, 20);
            this.Rating.TabIndex = 18;
            this.Rating.Text = "Rating:";
            this.Rating.Click += new System.EventHandler(this.Rating_Click);
            // 
            // AccDate_Input
            // 
            this.AccDate_Input.Location = new System.Drawing.Point(307, 26);
            this.AccDate_Input.Margin = new System.Windows.Forms.Padding(2);
            this.AccDate_Input.Name = "AccDate_Input";
            this.AccDate_Input.Size = new System.Drawing.Size(171, 20);
            this.AccDate_Input.TabIndex = 17;
            // 
            // AccCreation
            // 
            this.AccCreation.AutoSize = true;
            this.AccCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccCreation.Location = new System.Drawing.Point(304, 7);
            this.AccCreation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccCreation.Name = "AccCreation";
            this.AccCreation.Size = new System.Drawing.Size(175, 20);
            this.AccCreation.TabIndex = 16;
            this.AccCreation.Text = "Account Creation Date:";
            // 
            // CC_Input
            // 
            this.CC_Input.Location = new System.Drawing.Point(194, 118);
            this.CC_Input.Margin = new System.Windows.Forms.Padding(2);
            this.CC_Input.Name = "CC_Input";
            this.CC_Input.Size = new System.Drawing.Size(109, 20);
            this.CC_Input.TabIndex = 15;
            this.CC_Input.TextChanged += new System.EventHandler(this.CC_Input_TextChanged);
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(191, 97);
            this.CC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(102, 20);
            this.CC.TabIndex = 14;
            this.CC.Text = "Credit Card#:";
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // Acc_Input
            // 
            this.Acc_Input.Location = new System.Drawing.Point(194, 72);
            this.Acc_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Acc_Input.Name = "Acc_Input";
            this.Acc_Input.Size = new System.Drawing.Size(109, 20);
            this.Acc_Input.TabIndex = 13;
            this.Acc_Input.TextChanged += new System.EventHandler(this.Acc_Input_TextChanged);
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(191, 53);
            this.Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(81, 20);
            this.Account.TabIndex = 12;
            this.Account.Text = "Account#:";
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Email_Input
            // 
            this.Email_Input.Location = new System.Drawing.Point(194, 26);
            this.Email_Input.Margin = new System.Windows.Forms.Padding(2);
            this.Email_Input.Name = "Email_Input";
            this.Email_Input.Size = new System.Drawing.Size(109, 20);
            this.Email_Input.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(191, 7);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 20);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Zip_Input
            // 
            this.Zip_Input.Location = new System.Drawing.Point(7, 118);
            this.Zip_Input.Name = "Zip_Input";
            this.Zip_Input.Size = new System.Drawing.Size(82, 20);
            this.Zip_Input.TabIndex = 9;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip.Location = new System.Drawing.Point(6, 95);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(80, 20);
            this.Zip.TabIndex = 8;
            this.Zip.Text = "ZIP Code:";
            // 
            // State_Input
            // 
            this.State_Input.Location = new System.Drawing.Point(103, 72);
            this.State_Input.Name = "State_Input";
            this.State_Input.Size = new System.Drawing.Size(86, 20);
            this.State_Input.TabIndex = 7;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(100, 54);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(52, 20);
            this.State.TabIndex = 6;
            this.State.Text = "State:";
            // 
            // City_Input
            // 
            this.City_Input.Location = new System.Drawing.Point(3, 72);
            this.City_Input.Name = "City_Input";
            this.City_Input.Size = new System.Drawing.Size(86, 20);
            this.City_Input.TabIndex = 5;
            // 
            // CIty
            // 
            this.CIty.AutoSize = true;
            this.CIty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIty.Location = new System.Drawing.Point(3, 49);
            this.CIty.Name = "CIty";
            this.CIty.Size = new System.Drawing.Size(39, 20);
            this.CIty.TabIndex = 4;
            this.CIty.Text = "City:";
            // 
            // LastName_Input
            // 
            this.LastName_Input.Location = new System.Drawing.Point(103, 26);
            this.LastName_Input.Name = "LastName_Input";
            this.LastName_Input.Size = new System.Drawing.Size(86, 20);
            this.LastName_Input.TabIndex = 3;
            // 
            // LastN
            // 
            this.LastN.AutoSize = true;
            this.LastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastN.Location = new System.Drawing.Point(99, 3);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(90, 20);
            this.LastN.TabIndex = 2;
            this.LastN.Text = "Last Name:";
            // 
            // FirstName_Input
            // 
            this.FirstName_Input.Location = new System.Drawing.Point(3, 26);
            this.FirstName_Input.Name = "FirstName_Input";
            this.FirstName_Input.Size = new System.Drawing.Size(86, 20);
            this.FirstName_Input.TabIndex = 1;
            // 
            // FirstN
            // 
            this.FirstN.AutoSize = true;
            this.FirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstN.Location = new System.Drawing.Point(3, 3);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(90, 20);
            this.FirstN.TabIndex = 0;
            this.FirstN.Text = "First Name:";
            // 
            // CustomerTitle
            // 
            this.CustomerTitle.AutoSize = true;
            this.CustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTitle.Location = new System.Drawing.Point(5, 12);
            this.CustomerTitle.Name = "CustomerTitle";
            this.CustomerTitle.Size = new System.Drawing.Size(156, 37);
            this.CustomerTitle.TabIndex = 9;
            this.CustomerTitle.Text = "Customer";
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeight = 29;
            this.CustomerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.LastName,
            this.FirstName,
            this.Customer_City,
            this.Customer_State,
            this.Customer_Zip,
            this.Customer_Email,
            this.Account_Num,
            this.AccountType,
            this.ACC_Creation,
            this.Credit_Card,
            this.Customer_Rating,
            this.Telephone});
            this.CustomerGrid.Location = new System.Drawing.Point(465, 53);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.RowHeadersWidth = 51;
            this.CustomerGrid.Size = new System.Drawing.Size(563, 187);
            this.CustomerGrid.TabIndex = 0;
            // 
            // CID
            // 
            this.CID.HeaderText = "CustomerID";
            this.CID.MinimumWidth = 6;
            this.CID.Name = "CID";
            this.CID.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // Customer_City
            // 
            this.Customer_City.HeaderText = "City";
            this.Customer_City.MinimumWidth = 6;
            this.Customer_City.Name = "Customer_City";
            this.Customer_City.Width = 125;
            // 
            // Customer_State
            // 
            this.Customer_State.HeaderText = "State";
            this.Customer_State.MinimumWidth = 6;
            this.Customer_State.Name = "Customer_State";
            this.Customer_State.Width = 125;
            // 
            // Customer_Zip
            // 
            this.Customer_Zip.HeaderText = "Zip Code";
            this.Customer_Zip.MinimumWidth = 6;
            this.Customer_Zip.Name = "Customer_Zip";
            this.Customer_Zip.Width = 125;
            // 
            // Customer_Email
            // 
            this.Customer_Email.HeaderText = "Email";
            this.Customer_Email.MinimumWidth = 6;
            this.Customer_Email.Name = "Customer_Email";
            this.Customer_Email.Width = 125;
            // 
            // Account_Num
            // 
            this.Account_Num.HeaderText = "Account#";
            this.Account_Num.MinimumWidth = 6;
            this.Account_Num.Name = "Account_Num";
            this.Account_Num.Width = 125;
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "Account Type";
            this.AccountType.Name = "AccountType";
            // 
            // ACC_Creation
            // 
            this.ACC_Creation.HeaderText = "ACC_Creation Date";
            this.ACC_Creation.MinimumWidth = 6;
            this.ACC_Creation.Name = "ACC_Creation";
            this.ACC_Creation.Width = 125;
            // 
            // Credit_Card
            // 
            this.Credit_Card.HeaderText = "Credit Card";
            this.Credit_Card.MinimumWidth = 6;
            this.Credit_Card.Name = "Credit_Card";
            this.Credit_Card.Width = 125;
            // 
            // Customer_Rating
            // 
            this.Customer_Rating.HeaderText = "Rating";
            this.Customer_Rating.MinimumWidth = 6;
            this.Customer_Rating.Name = "Customer_Rating";
            this.Customer_Rating.Width = 125;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Phone#";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // movies
            // 
            this.movies.Location = new System.Drawing.Point(91, 53);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(84, 30);
            this.movies.TabIndex = 15;
            this.movies.Text = "Movies";
            this.movies.UseVisualStyleBackColor = true;
            this.movies.Click += new System.EventHandler(this.button1_Click);
            // 
            // rental
            // 
            this.rental.Location = new System.Drawing.Point(361, 53);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(84, 30);
            this.rental.TabIndex = 16;
            this.rental.Text = "Rental";
            this.rental.UseVisualStyleBackColor = true;
            this.rental.Click += new System.EventHandler(this.button2_Click);
            // 
            // signout
            // 
            this.signout.Location = new System.Drawing.Point(271, 108);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(84, 30);
            this.signout.TabIndex = 17;
            this.signout.Text = "Sign out";
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // customer2
            // 
            this.customer2.Location = new System.Drawing.Point(181, 53);
            this.customer2.Name = "customer2";
            this.customer2.Size = new System.Drawing.Size(84, 30);
            this.customer2.TabIndex = 18;
            this.customer2.Text = "Customer";
            this.customer2.UseVisualStyleBackColor = true;
            this.customer2.Click += new System.EventHandler(this.customer2_Click);
            // 
            // actors
            // 
            this.actors.Location = new System.Drawing.Point(91, 108);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(84, 30);
            this.actors.TabIndex = 19;
            this.actors.Text = "Actors";
            this.actors.UseVisualStyleBackColor = true;
            this.actors.Click += new System.EventHandler(this.actors_Click);
            // 
            // reports
            // 
            this.reports.Location = new System.Drawing.Point(181, 108);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(84, 30);
            this.reports.TabIndex = 20;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(271, 53);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(84, 30);
            this.employee.TabIndex = 21;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(989, 10);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(39, 38);
            this.HelpButton.TabIndex = 11;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ChooseScreen
            // 
            this.ChooseScreen.Items.AddRange(new object[] {
            "--Select A Screen--",
            "Movies",
            "Actors",
            "Employees",
            "Customer",
            "Rental",
            "Reports"});
            this.ChooseScreen.Location = new System.Drawing.Point(864, 12);
            this.ChooseScreen.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseScreen.Name = "ChooseScreen";
            this.ChooseScreen.Size = new System.Drawing.Size(121, 21);
            this.ChooseScreen.TabIndex = 0;
            this.ChooseScreen.SelectedIndexChanged += new System.EventHandler(this.ChooseScreen_SelectedIndexChanged);
            // 
            // RentsGridView
            // 
            this.RentsGridView.ColumnHeadersHeight = 29;
            this.RentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderDate,
            this.PickUpDate,
            this.ReturnDate,
            this.rentedMovieName});
            this.RentsGridView.Location = new System.Drawing.Point(521, 279);
            this.RentsGridView.Name = "RentsGridView";
            this.RentsGridView.Size = new System.Drawing.Size(507, 154);
            this.RentsGridView.TabIndex = 0;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 125;
            // 
            // PickUpDate
            // 
            this.PickUpDate.HeaderText = "Pick Up Date";
            this.PickUpDate.MinimumWidth = 6;
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Width = 125;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Width = 125;
            // 
            // rentedMovieName
            // 
            this.rentedMovieName.HeaderText = "Movie Name";
            this.rentedMovieName.MinimumWidth = 6;
            this.rentedMovieName.Name = "rentedMovieName";
            this.rentedMovieName.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(459, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "View Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(515, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "View Orders";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RentsGridView);
            this.Controls.Add(this.ChooseScreen);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.actors);
            this.Controls.Add(this.customer2);
            this.Controls.Add(this.signout);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.movies);
            this.Controls.Add(this.CustomerTitle);
            this.Controls.Add(this.CInfo);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CID_Input);
            this.Controls.Add(this.EnterCID);
            this.Name = "customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.CInfo.ResumeLayout(false);
            this.CInfotab.ResumeLayout(false);
            this.CInfotab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label EnterCID;
        private System.Windows.Forms.TextBox CID_Input;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TabControl CInfo;
        private System.Windows.Forms.TabPage CInfotab;
        private System.Windows.Forms.Label FirstN;
        private System.Windows.Forms.TextBox FirstName_Input;
        private System.Windows.Forms.TextBox LastName_Input;
        private System.Windows.Forms.Label LastN;
        private System.Windows.Forms.Label CIty;
        private System.Windows.Forms.TextBox City_Input;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Zip_Input;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.TextBox State_Input;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox Email_Input;
        private System.Windows.Forms.TextBox Telephone_Input;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox Rating_Input;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox AccDate_Input;
        private System.Windows.Forms.Label AccCreation;
        private System.Windows.Forms.TextBox CC_Input;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.TextBox Acc_Input;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CustomerTitle;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox ChooseScreen;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Button movies;
        private System.Windows.Forms.Button rental;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.Button customer2;
        private System.Windows.Forms.Button actors;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.DataGridView RentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickup;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentedMovieName;
        private System.Windows.Forms.TextBox AccT_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACC_Creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}