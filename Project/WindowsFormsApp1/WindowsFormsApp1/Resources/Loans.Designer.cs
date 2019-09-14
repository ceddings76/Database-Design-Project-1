namespace WindowsFormsApp1.Resources
{
    partial class Loans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SrchLoanBox = new System.Windows.Forms.TextBox();
            this.SrchLoanBtn = new System.Windows.Forms.Button();
            this.CheckInBtn = new System.Windows.Forms.Button();
            this.CheckInGBox = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CardIDTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.DateInTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BorrTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.ShowAllLoanBtn = new System.Windows.Forms.Button();
            this.AllLoanGrpBox = new System.Windows.Forms.GroupBox();
            this.SrchAllTxtBox = new System.Windows.Forms.TextBox();
            this.SrchAllBtn = new System.Windows.Forms.Button();
            this.ClrAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CheckInGBox.SuspendLayout();
            this.AllLoanGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Loan Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 178);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(679, 9);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.ReturnBtn.TabIndex = 2;
            this.ReturnBtn.Text = "Main Menu";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Loan Search";
            // 
            // SrchLoanBox
            // 
            this.SrchLoanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchLoanBox.Location = new System.Drawing.Point(30, 54);
            this.SrchLoanBox.Name = "SrchLoanBox";
            this.SrchLoanBox.Size = new System.Drawing.Size(262, 24);
            this.SrchLoanBox.TabIndex = 4;
            // 
            // SrchLoanBtn
            // 
            this.SrchLoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchLoanBtn.Location = new System.Drawing.Point(298, 54);
            this.SrchLoanBtn.Name = "SrchLoanBtn";
            this.SrchLoanBtn.Size = new System.Drawing.Size(76, 24);
            this.SrchLoanBtn.TabIndex = 5;
            this.SrchLoanBtn.Text = "Search";
            this.SrchLoanBtn.UseVisualStyleBackColor = true;
            this.SrchLoanBtn.Click += new System.EventHandler(this.SrchLoanBtn_Click);
            // 
            // CheckInBtn
            // 
            this.CheckInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInBtn.Location = new System.Drawing.Point(478, 52);
            this.CheckInBtn.Name = "CheckInBtn";
            this.CheckInBtn.Size = new System.Drawing.Size(100, 29);
            this.CheckInBtn.TabIndex = 6;
            this.CheckInBtn.Text = "Check In";
            this.CheckInBtn.UseVisualStyleBackColor = true;
            this.CheckInBtn.Click += new System.EventHandler(this.CheckInBtn_Click);
            // 
            // CheckInGBox
            // 
            this.CheckInGBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckInGBox.Controls.Add(this.ClearBtn);
            this.CheckInGBox.Controls.Add(this.CardIDTxtBox);
            this.CheckInGBox.Controls.Add(this.label5);
            this.CheckInGBox.Controls.Add(this.ExecuteBtn);
            this.CheckInGBox.Controls.Add(this.DateInTxtBox);
            this.CheckInGBox.Controls.Add(this.label6);
            this.CheckInGBox.Controls.Add(this.BorrTxtBox);
            this.CheckInGBox.Controls.Add(this.label4);
            this.CheckInGBox.Controls.Add(this.ISBNTxtBox);
            this.CheckInGBox.Controls.Add(this.label3);
            this.CheckInGBox.Location = new System.Drawing.Point(30, 88);
            this.CheckInGBox.Name = "CheckInGBox";
            this.CheckInGBox.Size = new System.Drawing.Size(409, 155);
            this.CheckInGBox.TabIndex = 7;
            this.CheckInGBox.TabStop = false;
            this.CheckInGBox.Visible = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(276, 60);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(110, 29);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CardIDTxtBox
            // 
            this.CardIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardIDTxtBox.Location = new System.Drawing.Point(106, 54);
            this.CardIDTxtBox.Name = "CardIDTxtBox";
            this.CardIDTxtBox.Size = new System.Drawing.Size(139, 24);
            this.CardIDTxtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Card ID";
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteBtn.Location = new System.Drawing.Point(276, 25);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(110, 29);
            this.ExecuteBtn.TabIndex = 6;
            this.ExecuteBtn.Text = "Check In";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // DateInTxtBox
            // 
            this.DateInTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInTxtBox.Location = new System.Drawing.Point(106, 114);
            this.DateInTxtBox.Name = "DateInTxtBox";
            this.DateInTxtBox.Size = new System.Drawing.Size(139, 24);
            this.DateInTxtBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date In";
            // 
            // BorrTxtBox
            // 
            this.BorrTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrTxtBox.Location = new System.Drawing.Point(106, 84);
            this.BorrTxtBox.Name = "BorrTxtBox";
            this.BorrTxtBox.Size = new System.Drawing.Size(139, 24);
            this.BorrTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Borrower";
            // 
            // ISBNTxtBox
            // 
            this.ISBNTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTxtBox.Location = new System.Drawing.Point(106, 24);
            this.ISBNTxtBox.Name = "ISBNTxtBox";
            this.ISBNTxtBox.Size = new System.Drawing.Size(139, 24);
            this.ISBNTxtBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // ClrBtn
            // 
            this.ClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(380, 54);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(76, 24);
            this.ClrBtn.TabIndex = 8;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // ShowAllLoanBtn
            // 
            this.ShowAllLoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllLoanBtn.Location = new System.Drawing.Point(687, 52);
            this.ShowAllLoanBtn.Name = "ShowAllLoanBtn";
            this.ShowAllLoanBtn.Size = new System.Drawing.Size(101, 53);
            this.ShowAllLoanBtn.TabIndex = 9;
            this.ShowAllLoanBtn.Text = "Show All Loans";
            this.ShowAllLoanBtn.UseVisualStyleBackColor = true;
            this.ShowAllLoanBtn.Click += new System.EventHandler(this.ShowAllLoanBtn_Click);
            // 
            // AllLoanGrpBox
            // 
            this.AllLoanGrpBox.BackColor = System.Drawing.Color.Transparent;
            this.AllLoanGrpBox.Controls.Add(this.ClrAllBtn);
            this.AllLoanGrpBox.Controls.Add(this.SrchAllBtn);
            this.AllLoanGrpBox.Controls.Add(this.SrchAllTxtBox);
            this.AllLoanGrpBox.Location = new System.Drawing.Point(520, 112);
            this.AllLoanGrpBox.Name = "AllLoanGrpBox";
            this.AllLoanGrpBox.Size = new System.Drawing.Size(267, 130);
            this.AllLoanGrpBox.TabIndex = 10;
            this.AllLoanGrpBox.TabStop = false;
            this.AllLoanGrpBox.Visible = false;
            // 
            // SrchAllTxtBox
            // 
            this.SrchAllTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchAllTxtBox.Location = new System.Drawing.Point(23, 17);
            this.SrchAllTxtBox.Name = "SrchAllTxtBox";
            this.SrchAllTxtBox.Size = new System.Drawing.Size(230, 24);
            this.SrchAllTxtBox.TabIndex = 0;
            // 
            // SrchAllBtn
            // 
            this.SrchAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchAllBtn.Location = new System.Drawing.Point(26, 51);
            this.SrchAllBtn.Name = "SrchAllBtn";
            this.SrchAllBtn.Size = new System.Drawing.Size(105, 32);
            this.SrchAllBtn.TabIndex = 1;
            this.SrchAllBtn.Text = "Search All";
            this.SrchAllBtn.UseVisualStyleBackColor = true;
            this.SrchAllBtn.Click += new System.EventHandler(this.SrchAllBtn_Click);
            // 
            // ClrAllBtn
            // 
            this.ClrAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrAllBtn.Location = new System.Drawing.Point(148, 51);
            this.ClrAllBtn.Name = "ClrAllBtn";
            this.ClrAllBtn.Size = new System.Drawing.Size(105, 32);
            this.ClrAllBtn.TabIndex = 2;
            this.ClrAllBtn.Text = "Clear All";
            this.ClrAllBtn.UseVisualStyleBackColor = true;
            this.ClrAllBtn.Click += new System.EventHandler(this.ClrAllBtn_Click);
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.library_books_00270899;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllLoanGrpBox);
            this.Controls.Add(this.ShowAllLoanBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.CheckInGBox);
            this.Controls.Add(this.CheckInBtn);
            this.Controls.Add(this.SrchLoanBtn);
            this.Controls.Add(this.SrchLoanBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Loans";
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.Loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CheckInGBox.ResumeLayout(false);
            this.CheckInGBox.PerformLayout();
            this.AllLoanGrpBox.ResumeLayout(false);
            this.AllLoanGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SrchLoanBox;
        private System.Windows.Forms.Button SrchLoanBtn;
        private System.Windows.Forms.Button CheckInBtn;
        private System.Windows.Forms.GroupBox CheckInGBox;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.TextBox DateInTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BorrTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardIDTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button ShowAllLoanBtn;
        private System.Windows.Forms.GroupBox AllLoanGrpBox;
        private System.Windows.Forms.Button ClrAllBtn;
        private System.Windows.Forms.Button SrchAllBtn;
        private System.Windows.Forms.TextBox SrchAllTxtBox;
    }
}