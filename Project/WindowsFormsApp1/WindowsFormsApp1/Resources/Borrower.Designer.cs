namespace WindowsFormsApp1.Resources
{
    partial class Borrower
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet = new WindowsFormsApp1.libraryDataSet();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SSNTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.SrchBxTxt = new System.Windows.Forms.TextBox();
            this.SrchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBrrwrBtn = new System.Windows.Forms.Button();
            this.ClearSrchBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RtrnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(480, 62);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(150, 26);
            this.NameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SSN";
            // 
            // SSNTxt
            // 
            this.SSNTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNTxt.Location = new System.Drawing.Point(480, 94);
            this.SSNTxt.Name = "SSNTxt";
            this.SSNTxt.Size = new System.Drawing.Size(150, 26);
            this.SSNTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone";
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxt.Location = new System.Drawing.Point(480, 126);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(150, 26);
            this.PhoneTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(480, 158);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(150, 26);
            this.EmailTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // AddressTxt
            // 
            this.AddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.Location = new System.Drawing.Point(480, 190);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(300, 26);
            this.AddressTxt.TabIndex = 10;
            // 
            // SrchBxTxt
            // 
            this.SrchBxTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchBxTxt.Location = new System.Drawing.Point(12, 91);
            this.SrchBxTxt.Name = "SrchBxTxt";
            this.SrchBxTxt.Size = new System.Drawing.Size(150, 26);
            this.SrchBxTxt.TabIndex = 12;
            // 
            // SrchBtn
            // 
            this.SrchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchBtn.Location = new System.Drawing.Point(160, 91);
            this.SrchBtn.Name = "SrchBtn";
            this.SrchBtn.Size = new System.Drawing.Size(75, 26);
            this.SrchBtn.TabIndex = 13;
            this.SrchBtn.Text = "Search";
            this.SrchBtn.UseVisualStyleBackColor = true;
            this.SrchBtn.Click += new System.EventHandler(this.SrchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Borrower Search";
            // 
            // AddBrrwrBtn
            // 
            this.AddBrrwrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBrrwrBtn.Location = new System.Drawing.Point(657, 62);
            this.AddBrrwrBtn.Name = "AddBrrwrBtn";
            this.AddBrrwrBtn.Size = new System.Drawing.Size(93, 42);
            this.AddBrrwrBtn.TabIndex = 15;
            this.AddBrrwrBtn.Text = "Add Borrower";
            this.AddBrrwrBtn.UseVisualStyleBackColor = true;
            this.AddBrrwrBtn.Click += new System.EventHandler(this.AddBrrwrBtn_Click);
            // 
            // ClearSrchBtn
            // 
            this.ClearSrchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSrchBtn.Location = new System.Drawing.Point(241, 91);
            this.ClearSrchBtn.Name = "ClearSrchBtn";
            this.ClearSrchBtn.Size = new System.Drawing.Size(75, 26);
            this.ClearSrchBtn.TabIndex = 16;
            this.ClearSrchBtn.Text = "Clear";
            this.ClearSrchBtn.UseVisualStyleBackColor = true;
            this.ClearSrchBtn.Click += new System.EventHandler(this.ClearSrchBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(657, 110);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 42);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RtrnBtn
            // 
            this.RtrnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtrnBtn.Location = new System.Drawing.Point(654, 17);
            this.RtrnBtn.Name = "RtrnBtn";
            this.RtrnBtn.Size = new System.Drawing.Size(95, 30);
            this.RtrnBtn.TabIndex = 18;
            this.RtrnBtn.Text = "Main Menu";
            this.RtrnBtn.UseVisualStyleBackColor = true;
            this.RtrnBtn.Click += new System.EventHandler(this.RtrnBtn_Click);
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.library_books_00270899;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RtrnBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ClearSrchBtn);
            this.Controls.Add(this.AddBrrwrBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SrchBtn);
            this.Controls.Add(this.SrchBxTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SSNTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SSNTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox SrchBxTxt;
        private System.Windows.Forms.Button SrchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBrrwrBtn;
        private System.Windows.Forms.Button ClearSrchBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RtrnBtn;
    }
}