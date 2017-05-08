namespace HotelDatabaseAssessment
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbllblCustID = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.DGMovies = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnRentMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbllblMovieID = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.tabPageRentedMovies = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DGRentedMovies = new System.Windows.Forms.DataGridView();
            this.tabPageCurrentlyRented = new System.Windows.Forms.TabPage();
            this.DGUnreturned = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovies)).BeginInit();
            this.tabPageRentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRentedMovies)).BeginInit();
            this.tabPageCurrentlyRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUnreturned)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomer);
            this.tabControl1.Controls.Add(this.tabPageMovies);
            this.tabControl1.Controls.Add(this.tabPageRentedMovies);
            this.tabControl1.Controls.Add(this.tabPageCurrentlyRented);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.btnUpdateCustomer);
            this.tabPageCustomer.Controls.Add(this.lblPhone);
            this.tabPageCustomer.Controls.Add(this.txtPhone);
            this.tabPageCustomer.Controls.Add(this.lblAddress);
            this.tabPageCustomer.Controls.Add(this.txtAddress);
            this.tabPageCustomer.Controls.Add(this.lblLastName);
            this.tabPageCustomer.Controls.Add(this.txtLastName);
            this.tabPageCustomer.Controls.Add(this.lblFirstName);
            this.tabPageCustomer.Controls.Add(this.lblCustID);
            this.tabPageCustomer.Controls.Add(this.txtFirstName);
            this.tabPageCustomer.Controls.Add(this.lbllblCustID);
            this.tabPageCustomer.Controls.Add(this.btnAddCustomer);
            this.tabPageCustomer.Controls.Add(this.label1);
            this.tabPageCustomer.Controls.Add(this.DGCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(946, 377);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customers";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(808, 250);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateCustomer.TabIndex = 15;
            this.btnUpdateCustomer.Text = "Update Selected Record";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(634, 249);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 23);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(702, 252);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(460, 249);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 23);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(528, 252);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(273, 249);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 23);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(354, 252);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(86, 249);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 23);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustID
            // 
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(47, 249);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(33, 23);
            this.lblCustID.TabIndex = 7;
            this.lblCustID.Text = "*";
            this.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(167, 252);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // lbllblCustID
            // 
            this.lbllblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblCustID.Location = new System.Drawing.Point(8, 249);
            this.lbllblCustID.Name = "lbllblCustID";
            this.lbllblCustID.Size = new System.Drawing.Size(33, 23);
            this.lbllblCustID.TabIndex = 5;
            this.lbllblCustID.Text = "ID:";
            this.lbllblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(8, 348);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(135, 23);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "New Customer...";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Overview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Location = new System.Drawing.Point(0, 31);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.Size = new System.Drawing.Size(946, 215);
            this.DGCustomer.TabIndex = 1;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnyDG_CellClick);
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.btnUpdateMovie);
            this.tabPageMovies.Controls.Add(this.txtGenre);
            this.tabPageMovies.Controls.Add(this.lblGenre);
            this.tabPageMovies.Controls.Add(this.txtPlot);
            this.tabPageMovies.Controls.Add(this.lblPlot);
            this.tabPageMovies.Controls.Add(this.txtCopies);
            this.tabPageMovies.Controls.Add(this.lblCopies);
            this.tabPageMovies.Controls.Add(this.lblRentalCost);
            this.tabPageMovies.Controls.Add(this.btnAddMovie);
            this.tabPageMovies.Controls.Add(this.txtRentalCost);
            this.tabPageMovies.Controls.Add(this.DGMovies);
            this.tabPageMovies.Controls.Add(this.lblYear);
            this.tabPageMovies.Controls.Add(this.label2);
            this.tabPageMovies.Controls.Add(this.txtYear);
            this.tabPageMovies.Controls.Add(this.btnRentMovie);
            this.tabPageMovies.Controls.Add(this.lblTitle);
            this.tabPageMovies.Controls.Add(this.txtRating);
            this.tabPageMovies.Controls.Add(this.txtTitle);
            this.tabPageMovies.Controls.Add(this.lbllblMovieID);
            this.tabPageMovies.Controls.Add(this.lblRating);
            this.tabPageMovies.Controls.Add(this.lblMovieID);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(946, 377);
            this.tabPageMovies.TabIndex = 1;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(729, 250);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateMovie.TabIndex = 16;
            this.btnUpdateMovie.Text = "Update Selected Record";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(147, 297);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(84, 20);
            this.txtGenre.TabIndex = 29;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(86, 295);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 23);
            this.lblGenre.TabIndex = 30;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(281, 277);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(658, 20);
            this.txtPlot.TabIndex = 27;
            // 
            // lblPlot
            // 
            this.lblPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlot.Location = new System.Drawing.Point(237, 274);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(38, 23);
            this.lblPlot.TabIndex = 28;
            this.lblPlot.Text = "Plot:";
            this.lblPlot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(147, 274);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(84, 20);
            this.txtCopies.TabIndex = 25;
            // 
            // lblCopies
            // 
            this.lblCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.Location = new System.Drawing.Point(86, 272);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(55, 23);
            this.lblCopies.TabIndex = 26;
            this.lblCopies.Text = "Copies:";
            this.lblCopies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCost.Location = new System.Drawing.Point(537, 247);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(80, 23);
            this.lblRentalCost.TabIndex = 24;
            this.lblRentalCost.Text = "Rental Cost:";
            this.lblRentalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(8, 348);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(102, 23);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "New Movie...";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(623, 250);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 20);
            this.txtRentalCost.TabIndex = 23;
            // 
            // DGMovies
            // 
            this.DGMovies.AllowUserToAddRows = false;
            this.DGMovies.AllowUserToDeleteRows = false;
            this.DGMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMovies.Location = new System.Drawing.Point(0, 31);
            this.DGMovies.Name = "DGMovies";
            this.DGMovies.ReadOnly = true;
            this.DGMovies.Size = new System.Drawing.Size(946, 215);
            this.DGMovies.TabIndex = 5;
            this.DGMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnyDG_CellClick);
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(433, 247);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 23);
            this.lblYear.TabIndex = 22;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movies Overview";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(476, 250);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(55, 20);
            this.txtYear.TabIndex = 21;
            // 
            // btnRentMovie
            // 
            this.btnRentMovie.Location = new System.Drawing.Point(116, 348);
            this.btnRentMovie.Name = "btnRentMovie";
            this.btnRentMovie.Size = new System.Drawing.Size(132, 23);
            this.btnRentMovie.TabIndex = 1;
            this.btnRentMovie.Text = "Rent Selected Movie...";
            this.btnRentMovie.UseVisualStyleBackColor = true;
            this.btnRentMovie.Click += new System.EventHandler(this.btnRentMovie_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(237, 249);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 23);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(147, 252);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(84, 20);
            this.txtRating.TabIndex = 16;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(282, 251);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(145, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // lbllblMovieID
            // 
            this.lbllblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblMovieID.Location = new System.Drawing.Point(8, 249);
            this.lbllblMovieID.Name = "lbllblMovieID";
            this.lbllblMovieID.Size = new System.Drawing.Size(33, 23);
            this.lbllblMovieID.TabIndex = 15;
            this.lbllblMovieID.Text = "ID:";
            this.lbllblMovieID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(86, 249);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(55, 23);
            this.lblRating.TabIndex = 18;
            this.lblRating.Text = "Rating:";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovieID
            // 
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(47, 249);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(33, 23);
            this.lblMovieID.TabIndex = 17;
            this.lblMovieID.Text = "*";
            this.lblMovieID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageRentedMovies
            // 
            this.tabPageRentedMovies.Controls.Add(this.label3);
            this.tabPageRentedMovies.Controls.Add(this.DGRentedMovies);
            this.tabPageRentedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentedMovies.Name = "tabPageRentedMovies";
            this.tabPageRentedMovies.Size = new System.Drawing.Size(946, 377);
            this.tabPageRentedMovies.TabIndex = 2;
            this.tabPageRentedMovies.Text = "Sales History";
            this.tabPageRentedMovies.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sales History";
            // 
            // DGRentedMovies
            // 
            this.DGRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRentedMovies.Location = new System.Drawing.Point(0, 31);
            this.DGRentedMovies.Name = "DGRentedMovies";
            this.DGRentedMovies.Size = new System.Drawing.Size(946, 215);
            this.DGRentedMovies.TabIndex = 0;
            this.DGRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnyDG_CellClick);
            // 
            // tabPageCurrentlyRented
            // 
            this.tabPageCurrentlyRented.Controls.Add(this.DGUnreturned);
            this.tabPageCurrentlyRented.Controls.Add(this.label4);
            this.tabPageCurrentlyRented.Controls.Add(this.btnReturnMovie);
            this.tabPageCurrentlyRented.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentlyRented.Name = "tabPageCurrentlyRented";
            this.tabPageCurrentlyRented.Size = new System.Drawing.Size(946, 377);
            this.tabPageCurrentlyRented.TabIndex = 3;
            this.tabPageCurrentlyRented.Text = "Currently Unreturned";
            this.tabPageCurrentlyRented.UseVisualStyleBackColor = true;
            // 
            // DGUnreturned
            // 
            this.DGUnreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUnreturned.Location = new System.Drawing.Point(0, 31);
            this.DGUnreturned.Name = "DGUnreturned";
            this.DGUnreturned.Size = new System.Drawing.Size(946, 215);
            this.DGUnreturned.TabIndex = 5;
            this.DGUnreturned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnyDG_CellClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Currently Unreturned";
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Location = new System.Drawing.Point(8, 348);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(132, 23);
            this.btnReturnMovie.TabIndex = 2;
            this.btnReturnMovie.Text = "Return Selected Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Movie Rentals";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.tabPageMovies.ResumeLayout(false);
            this.tabPageMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovies)).EndInit();
            this.tabPageRentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRentedMovies)).EndInit();
            this.tabPageCurrentlyRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUnreturned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.Button btnRentMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView DGMovies;
        private System.Windows.Forms.TabPage tabPageRentedMovies;
        private System.Windows.Forms.TabPage tabPageCurrentlyRented;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGRentedMovies;
        private System.Windows.Forms.DataGridView DGUnreturned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbllblCustID;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbllblMovieID;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
    }
}

