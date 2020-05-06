namespace Connected_Architecture2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Employee_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Designation_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Qualification = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 403);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Employee_ID
            // 
            this.Employee_ID.Location = new System.Drawing.Point(39, 66);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(196, 22);
            this.Employee_ID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "EmployeeID";
            // 
            // Emp_Name
            // 
            this.Emp_Name.Location = new System.Drawing.Point(39, 147);
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Size = new System.Drawing.Size(196, 22);
            this.Emp_Name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "EmpName";
            // 
            // Designation_1
            // 
            this.Designation_1.Location = new System.Drawing.Point(39, 235);
            this.Designation_1.Name = "Designation_1";
            this.Designation_1.Size = new System.Drawing.Size(196, 22);
            this.Designation_1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Designation";
            // 
            // Qualification
            // 
            this.Qualification.Location = new System.Drawing.Point(39, 316);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(196, 22);
            this.Qualification.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Qualification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "JoiningDate";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(327, 110);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(124, 23);
            this.Insert.TabIndex = 20;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(327, 196);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(124, 23);
            this.Update.TabIndex = 21;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(327, 278);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(124, 23);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(327, 356);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(124, 23);
            this.Search.TabIndex = 23;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 380);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Qualification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Designation_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emp_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_ID);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Employee_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Designation_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qualification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

