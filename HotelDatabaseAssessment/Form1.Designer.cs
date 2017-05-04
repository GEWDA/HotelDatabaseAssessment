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
            this.label1 = new System.Windows.Forms.Label();
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRentMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.DGMovies = new System.Windows.Forms.DataGridView();
            this.tabPageRentedMovies = new System.Windows.Forms.TabPage();
            this.tabPageCurrentlyRented = new System.Windows.Forms.TabPage();
            this.DGRentedMovies = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGUnreturned = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.tabPageMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovies)).BeginInit();
            this.tabPageRentedMovies.SuspendLayout();
            this.tabPageCurrentlyRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRentedMovies)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(842, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.label1);
            this.tabPageCustomer.Controls.Add(this.DGCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(834, 246);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customers";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
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
            this.DGCustomer.Size = new System.Drawing.Size(834, 215);
            this.DGCustomer.TabIndex = 1;
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Controls.Add(this.DGMovies);
            this.tabPageMovies.Controls.Add(this.label2);
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(834, 246);
            this.tabPageMovies.TabIndex = 1;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
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
            // btnRentMovie
            // 
            this.btnRentMovie.Location = new System.Drawing.Point(19, 296);
            this.btnRentMovie.Name = "btnRentMovie";
            this.btnRentMovie.Size = new System.Drawing.Size(132, 23);
            this.btnRentMovie.TabIndex = 1;
            this.btnRentMovie.Text = "Rent Selected Movie";
            this.btnRentMovie.UseVisualStyleBackColor = true;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Location = new System.Drawing.Point(157, 296);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(102, 23);
            this.btnReturnMovie.TabIndex = 2;
            this.btnReturnMovie.Text = "Return Movie...";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(265, 296);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(102, 23);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "New Movie...";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(373, 296);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(135, 23);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "New Customer...";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // DGMovies
            // 
            this.DGMovies.AllowUserToAddRows = false;
            this.DGMovies.AllowUserToDeleteRows = false;
            this.DGMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMovies.Location = new System.Drawing.Point(0, 31);
            this.DGMovies.Name = "DGMovies";
            this.DGMovies.ReadOnly = true;
            this.DGMovies.Size = new System.Drawing.Size(834, 215);
            this.DGMovies.TabIndex = 5;
            // 
            // tabPageRentedMovies
            // 
            this.tabPageRentedMovies.Controls.Add(this.label3);
            this.tabPageRentedMovies.Controls.Add(this.DGRentedMovies);
            this.tabPageRentedMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentedMovies.Name = "tabPageRentedMovies";
            this.tabPageRentedMovies.Size = new System.Drawing.Size(834, 246);
            this.tabPageRentedMovies.TabIndex = 2;
            this.tabPageRentedMovies.Text = "Sales History";
            this.tabPageRentedMovies.UseVisualStyleBackColor = true;
            // 
            // tabPageCurrentlyRented
            // 
            this.tabPageCurrentlyRented.Controls.Add(this.DGUnreturned);
            this.tabPageCurrentlyRented.Controls.Add(this.label4);
            this.tabPageCurrentlyRented.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentlyRented.Name = "tabPageCurrentlyRented";
            this.tabPageCurrentlyRented.Size = new System.Drawing.Size(834, 246);
            this.tabPageCurrentlyRented.TabIndex = 3;
            this.tabPageCurrentlyRented.Text = "Currently Unreturned";
            this.tabPageCurrentlyRented.UseVisualStyleBackColor = true;
            // 
            // DGRentedMovies
            // 
            this.DGRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRentedMovies.Location = new System.Drawing.Point(0, 31);
            this.DGRentedMovies.Name = "DGRentedMovies";
            this.DGRentedMovies.Size = new System.Drawing.Size(834, 215);
            this.DGRentedMovies.TabIndex = 0;
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Currently Unreturned";
            // 
            // DGUnreturned
            // 
            this.DGUnreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUnreturned.Location = new System.Drawing.Point(0, 31);
            this.DGUnreturned.Name = "DGUnreturned";
            this.DGUnreturned.Size = new System.Drawing.Size(834, 215);
            this.DGUnreturned.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 444);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnRentMovie);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.tabPageMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGMovies)).EndInit();
            this.tabPageRentedMovies.ResumeLayout(false);
            this.tabPageCurrentlyRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRentedMovies)).EndInit();
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
    }
}

