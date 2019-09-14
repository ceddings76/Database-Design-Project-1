namespace WindowsFormsApp1.Resources
{
    partial class Main_Menu
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
            this.SearchBox1 = new System.Windows.Forms.TextBox();
            this.SearchBookbtn = new System.Windows.Forms.Button();
            this.bookviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new WindowsFormsApp1.libraryDataSet();
            this.book_viewTableAdapter = new WindowsFormsApp1.libraryDataSetTableAdapters.book_viewTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BorrBtn = new System.Windows.Forms.Button();
            this.Loanbtn = new System.Windows.Forms.Button();
            this.CheckOutBtn = new System.Windows.Forms.Button();
            this.CheckOutGrp = new System.Windows.Forms.GroupBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.TitleDispBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBNDispBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CardTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FinesBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CheckOutGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox1
            // 
            this.SearchBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox1.Location = new System.Drawing.Point(12, 45);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Size = new System.Drawing.Size(391, 26);
            this.SearchBox1.TabIndex = 0;
            // 
            // SearchBookbtn
            // 
            this.SearchBookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBookbtn.Location = new System.Drawing.Point(385, 45);
            this.SearchBookbtn.Name = "SearchBookbtn";
            this.SearchBookbtn.Size = new System.Drawing.Size(80, 26);
            this.SearchBookbtn.TabIndex = 2;
            this.SearchBookbtn.Text = "Search";
            this.SearchBookbtn.UseVisualStyleBackColor = true;
            this.SearchBookbtn.Click += new System.EventHandler(this.SearchBookbtn_Click);
            // 
            // bookviewBindingSource
            // 
            this.bookviewBindingSource.DataMember = "book_view";
            this.bookviewBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_viewTableAdapter
            // 
            this.book_viewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 239);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Library Management Database";
            // 
            // BorrBtn
            // 
            this.BorrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrBtn.Location = new System.Drawing.Point(650, 21);
            this.BorrBtn.Name = "BorrBtn";
            this.BorrBtn.Size = new System.Drawing.Size(123, 50);
            this.BorrBtn.TabIndex = 5;
            this.BorrBtn.Text = "Borrower Management";
            this.BorrBtn.UseVisualStyleBackColor = true;
            this.BorrBtn.Click += new System.EventHandler(this.BorrBtn_Click);
            // 
            // Loanbtn
            // 
            this.Loanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loanbtn.Location = new System.Drawing.Point(650, 77);
            this.Loanbtn.Name = "Loanbtn";
            this.Loanbtn.Size = new System.Drawing.Size(123, 49);
            this.Loanbtn.TabIndex = 6;
            this.Loanbtn.Text = "Loan Management";
            this.Loanbtn.UseVisualStyleBackColor = true;
            this.Loanbtn.Click += new System.EventHandler(this.Loanbtn_Click);
            // 
            // CheckOutBtn
            // 
            this.CheckOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBtn.Location = new System.Drawing.Point(471, 45);
            this.CheckOutBtn.Name = "CheckOutBtn";
            this.CheckOutBtn.Size = new System.Drawing.Size(152, 26);
            this.CheckOutBtn.TabIndex = 7;
            this.CheckOutBtn.Text = "Check Out Book";
            this.CheckOutBtn.UseVisualStyleBackColor = true;
            this.CheckOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // CheckOutGrp
            // 
            this.CheckOutGrp.BackColor = System.Drawing.Color.Transparent;
            this.CheckOutGrp.Controls.Add(this.ClrBtn);
            this.CheckOutGrp.Controls.Add(this.DoneBtn);
            this.CheckOutGrp.Controls.Add(this.TitleDispBox);
            this.CheckOutGrp.Controls.Add(this.label4);
            this.CheckOutGrp.Controls.Add(this.ISBNDispBox);
            this.CheckOutGrp.Controls.Add(this.label3);
            this.CheckOutGrp.Controls.Add(this.CardTxtBox);
            this.CheckOutGrp.Controls.Add(this.label2);
            this.CheckOutGrp.Location = new System.Drawing.Point(12, 101);
            this.CheckOutGrp.Name = "CheckOutGrp";
            this.CheckOutGrp.Size = new System.Drawing.Size(632, 92);
            this.CheckOutGrp.TabIndex = 8;
            this.CheckOutGrp.TabStop = false;
            this.CheckOutGrp.Visible = false;
            // 
            // ClrBtn
            // 
            this.ClrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBtn.Location = new System.Drawing.Point(461, 15);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(99, 31);
            this.ClrBtn.TabIndex = 7;
            this.ClrBtn.Text = "Clear/Cancel";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // DoneBtn
            // 
            this.DoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBtn.Location = new System.Drawing.Point(380, 15);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(75, 31);
            this.DoneBtn.TabIndex = 6;
            this.DoneBtn.Text = "Check Out";
            this.DoneBtn.UseVisualStyleBackColor = true;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // TitleDispBox
            // 
            this.TitleDispBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDispBox.Location = new System.Drawing.Point(81, 55);
            this.TitleDispBox.Name = "TitleDispBox";
            this.TitleDispBox.Size = new System.Drawing.Size(343, 24);
            this.TitleDispBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN";
            // 
            // ISBNDispBox
            // 
            this.ISBNDispBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNDispBox.Location = new System.Drawing.Point(265, 25);
            this.ISBNDispBox.Name = "ISBNDispBox";
            this.ISBNDispBox.Size = new System.Drawing.Size(100, 24);
            this.ISBNDispBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // CardTxtBox
            // 
            this.CardTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardTxtBox.Location = new System.Drawing.Point(81, 25);
            this.CardTxtBox.Name = "CardTxtBox";
            this.CardTxtBox.Size = new System.Drawing.Size(100, 24);
            this.CardTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Card ID";
            // 
            // FinesBtn
            // 
            this.FinesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinesBtn.Location = new System.Drawing.Point(650, 133);
            this.FinesBtn.Name = "FinesBtn";
            this.FinesBtn.Size = new System.Drawing.Size(123, 49);
            this.FinesBtn.TabIndex = 10;
            this.FinesBtn.Text = "Fines Management";
            this.FinesBtn.UseVisualStyleBackColor = true;
            this.FinesBtn.Click += new System.EventHandler(this.FinesBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(385, 77);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(80, 26);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.library_books_00270899;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FinesBtn);
            this.Controls.Add(this.CheckOutGrp);
            this.Controls.Add(this.CheckOutBtn);
            this.Controls.Add(this.Loanbtn);
            this.Controls.Add(this.BorrBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBookbtn);
            this.Controls.Add(this.SearchBox1);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CheckOutGrp.ResumeLayout(false);
            this.CheckOutGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookviewBindingSource;
        private libraryDataSetTableAdapters.book_viewTableAdapter book_viewTableAdapter;
        private System.Windows.Forms.Button SearchBookbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorrBtn;
        private System.Windows.Forms.Button Loanbtn;
        private System.Windows.Forms.Button CheckOutBtn;
        private System.Windows.Forms.GroupBox CheckOutGrp;
        private System.Windows.Forms.TextBox TitleDispBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBNDispBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Button FinesBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}