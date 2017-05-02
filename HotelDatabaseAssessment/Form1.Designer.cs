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
            this.tabPageDG = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageLV = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRentMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageLV.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDG);
            this.tabControl1.Controls.Add(this.tabPageLV);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDG
            // 
            this.tabPageDG.Controls.Add(this.label1);
            this.tabPageDG.Controls.Add(this.dataGridView1);
            this.tabPageDG.Location = new System.Drawing.Point(4, 22);
            this.tabPageDG.Name = "tabPageDG";
            this.tabPageDG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDG.Size = new System.Drawing.Size(834, 246);
            this.tabPageDG.TabIndex = 0;
            this.tabPageDG.Text = "Data Grid";
            this.tabPageDG.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(834, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPageLV
            // 
            this.tabPageLV.Controls.Add(this.label2);
            this.tabPageLV.Controls.Add(this.listView1);
            this.tabPageLV.Location = new System.Drawing.Point(4, 22);
            this.tabPageLV.Name = "tabPageLV";
            this.tabPageLV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLV.Size = new System.Drawing.Size(834, 246);
            this.tabPageLV.TabIndex = 1;
            this.tabPageLV.Text = "List View";
            this.tabPageLV.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(834, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRentMovie
            // 
            this.btnRentMovie.Location = new System.Drawing.Point(19, 296);
            this.btnRentMovie.Name = "btnRentMovie";
            this.btnRentMovie.Size = new System.Drawing.Size(102, 23);
            this.btnRentMovie.TabIndex = 1;
            this.btnRentMovie.Text = "Rent Movie";
            this.btnRentMovie.UseVisualStyleBackColor = true;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Location = new System.Drawing.Point(127, 296);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(102, 23);
            this.btnReturnMovie.TabIndex = 2;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Overview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Overview";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 444);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnRentMovie);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageLV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageLV;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRentMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

