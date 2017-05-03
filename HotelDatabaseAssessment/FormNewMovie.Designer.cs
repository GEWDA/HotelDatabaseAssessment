namespace HotelDatabaseAssessment
{
    partial class FormNewMovie
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.lblRental_Cost = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.lblPlot = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 124);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(206, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 101);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(12, 32);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(50, 20);
            this.txtRating.TabIndex = 5;
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(12, 9);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(100, 20);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Rating";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(12, 78);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(12, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // txtRental_Cost
            // 
            this.txtRental_Cost.Location = new System.Drawing.Point(118, 78);
            this.txtRental_Cost.Name = "txtRental_Cost";
            this.txtRental_Cost.Size = new System.Drawing.Size(100, 20);
            this.txtRental_Cost.TabIndex = 11;
            // 
            // lblRental_Cost
            // 
            this.lblRental_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental_Cost.Location = new System.Drawing.Point(118, 55);
            this.lblRental_Cost.Name = "lblRental_Cost";
            this.lblRental_Cost.Size = new System.Drawing.Size(100, 20);
            this.lblRental_Cost.TabIndex = 10;
            this.lblRental_Cost.Text = "Cost";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(118, 32);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 13;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(118, 9);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(100, 20);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(12, 170);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(206, 20);
            this.txtPlot.TabIndex = 15;
            // 
            // lblPlot
            // 
            this.lblPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlot.Location = new System.Drawing.Point(12, 147);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(100, 20);
            this.lblPlot.TabIndex = 14;
            this.lblPlot.Text = "Plot";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(118, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubmit.Size = new System.Drawing.Size(100, 22);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormNewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtRental_Cost);
            this.Controls.Add(this.lblRental_Cost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblRating);
            this.Name = "FormNewMovie";
            this.Text = "FormNewMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtRental_Cost;
        private System.Windows.Forms.Label lblRental_Cost;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Button btnSubmit;
    }
}