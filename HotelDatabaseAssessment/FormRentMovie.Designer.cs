namespace HotelDatabaseAssessment
{
    partial class FormRentMovie
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
            this.DGCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCustomer
            // 
            this.DGCustomer.AllowUserToAddRows = false;
            this.DGCustomer.AllowUserToDeleteRows = false;
            this.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCustomer.Location = new System.Drawing.Point(12, 12);
            this.DGCustomer.Name = "DGCustomer";
            this.DGCustomer.ReadOnly = true;
            this.DGCustomer.Size = new System.Drawing.Size(594, 778);
            this.DGCustomer.TabIndex = 2;
            this.DGCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 796);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(135, 23);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "New Customer...";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(153, 796);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(59, 23);
            this.btnRent.TabIndex = 6;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // FormRentMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 831);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.DGCustomer);
            this.Name = "FormRentMovie";
            this.Text = "Select Customer";
            this.Activated += new System.EventHandler(this.FormRentMovie_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DGCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnRent;
    }
}