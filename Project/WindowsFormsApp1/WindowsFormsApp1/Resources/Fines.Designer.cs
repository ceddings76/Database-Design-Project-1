namespace WindowsFormsApp1.Resources
{
    partial class Fines
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SrchBox = new System.Windows.Forms.TextBox();
            this.SrchFineBtn = new System.Windows.Forms.Button();
            this.PayFineBtn = new System.Windows.Forms.Button();
            this.FinPayBtn = new System.Windows.Forms.Button();
            this.UpdateFineBtn = new System.Windows.Forms.Button();
            this.ShwAllFinesBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RtrnBtn = new System.Windows.Forms.Button();
            this.SrchAllFinesGrp = new System.Windows.Forms.GroupBox();
            this.SrchAllTxtBox = new System.Windows.Forms.TextBox();
            this.ClrAllBtn = new System.Windows.Forms.Button();
            this.SrchAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SrchAllFinesGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fine Management";
            // 
            // SrchBox
            // 
            this.SrchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchBox.Location = new System.Drawing.Point(31, 72);
            this.SrchBox.Name = "SrchBox";
            this.SrchBox.Size = new System.Drawing.Size(180, 24);
            this.SrchBox.TabIndex = 2;
            // 
            // SrchFineBtn
            // 
            this.SrchFineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchFineBtn.Location = new System.Drawing.Point(210, 69);
            this.SrchFineBtn.Name = "SrchFineBtn";
            this.SrchFineBtn.Size = new System.Drawing.Size(85, 30);
            this.SrchFineBtn.TabIndex = 3;
            this.SrchFineBtn.Text = "Search";
            this.SrchFineBtn.UseVisualStyleBackColor = true;
            this.SrchFineBtn.Click += new System.EventHandler(this.SrchFineBtn_Click);
            // 
            // PayFineBtn
            // 
            this.PayFineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayFineBtn.Location = new System.Drawing.Point(31, 102);
            this.PayFineBtn.Name = "PayFineBtn";
            this.PayFineBtn.Size = new System.Drawing.Size(110, 30);
            this.PayFineBtn.TabIndex = 4;
            this.PayFineBtn.Text = "Pay Fine";
            this.PayFineBtn.UseVisualStyleBackColor = true;
            this.PayFineBtn.Click += new System.EventHandler(this.PayFineBtn_Click);
            // 
            // FinPayBtn
            // 
            this.FinPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinPayBtn.Location = new System.Drawing.Point(31, 164);
            this.FinPayBtn.Name = "FinPayBtn";
            this.FinPayBtn.Size = new System.Drawing.Size(110, 30);
            this.FinPayBtn.TabIndex = 3;
            this.FinPayBtn.Text = "Execute";
            this.FinPayBtn.UseVisualStyleBackColor = true;
            this.FinPayBtn.Visible = false;
            this.FinPayBtn.Click += new System.EventHandler(this.FinPayBtn_Click);
            // 
            // UpdateFineBtn
            // 
            this.UpdateFineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFineBtn.Location = new System.Drawing.Point(427, 65);
            this.UpdateFineBtn.Name = "UpdateFineBtn";
            this.UpdateFineBtn.Size = new System.Drawing.Size(117, 39);
            this.UpdateFineBtn.TabIndex = 5;
            this.UpdateFineBtn.Text = "Update Fines";
            this.UpdateFineBtn.UseVisualStyleBackColor = true;
            this.UpdateFineBtn.Click += new System.EventHandler(this.UpdateFineBtn_Click);
            // 
            // ShwAllFinesBtn
            // 
            this.ShwAllFinesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShwAllFinesBtn.Location = new System.Drawing.Point(617, 65);
            this.ShwAllFinesBtn.Name = "ShwAllFinesBtn";
            this.ShwAllFinesBtn.Size = new System.Drawing.Size(117, 52);
            this.ShwAllFinesBtn.TabIndex = 6;
            this.ShwAllFinesBtn.Text = "Show All Fines";
            this.ShwAllFinesBtn.UseVisualStyleBackColor = true;
            this.ShwAllFinesBtn.Click += new System.EventHandler(this.ShwAllFinesBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(311, 69);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(85, 30);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(165, 164);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(110, 30);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RtrnBtn
            // 
            this.RtrnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtrnBtn.Location = new System.Drawing.Point(617, 17);
            this.RtrnBtn.Name = "RtrnBtn";
            this.RtrnBtn.Size = new System.Drawing.Size(97, 23);
            this.RtrnBtn.TabIndex = 9;
            this.RtrnBtn.Text = "Main Menu";
            this.RtrnBtn.UseVisualStyleBackColor = true;
            this.RtrnBtn.Click += new System.EventHandler(this.RtrnBtn_Click);
            // 
            // SrchAllFinesGrp
            // 
            this.SrchAllFinesGrp.BackColor = System.Drawing.Color.Transparent;
            this.SrchAllFinesGrp.Controls.Add(this.ClrAllBtn);
            this.SrchAllFinesGrp.Controls.Add(this.SrchAllBtn);
            this.SrchAllFinesGrp.Controls.Add(this.SrchAllTxtBox);
            this.SrchAllFinesGrp.Location = new System.Drawing.Point(449, 145);
            this.SrchAllFinesGrp.Name = "SrchAllFinesGrp";
            this.SrchAllFinesGrp.Size = new System.Drawing.Size(325, 105);
            this.SrchAllFinesGrp.TabIndex = 10;
            this.SrchAllFinesGrp.TabStop = false;
            this.SrchAllFinesGrp.Visible = false;
            // 
            // SrchAllTxtBox
            // 
            this.SrchAllTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchAllTxtBox.Location = new System.Drawing.Point(20, 16);
            this.SrchAllTxtBox.Name = "SrchAllTxtBox";
            this.SrchAllTxtBox.Size = new System.Drawing.Size(216, 24);
            this.SrchAllTxtBox.TabIndex = 0;
            // 
            // ClrAllBtn
            // 
            this.ClrAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrAllBtn.Location = new System.Drawing.Point(151, 57);
            this.ClrAllBtn.Name = "ClrAllBtn";
            this.ClrAllBtn.Size = new System.Drawing.Size(85, 30);
            this.ClrAllBtn.TabIndex = 9;
            this.ClrAllBtn.Text = "Clear All";
            this.ClrAllBtn.UseVisualStyleBackColor = true;
            this.ClrAllBtn.Click += new System.EventHandler(this.ClrAllBtn_Click);
            // 
            // SrchAllBtn
            // 
            this.SrchAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchAllBtn.Location = new System.Drawing.Point(20, 57);
            this.SrchAllBtn.Name = "SrchAllBtn";
            this.SrchAllBtn.Size = new System.Drawing.Size(104, 30);
            this.SrchAllBtn.TabIndex = 8;
            this.SrchAllBtn.Text = "Search All";
            this.SrchAllBtn.UseVisualStyleBackColor = true;
            this.SrchAllBtn.Click += new System.EventHandler(this.SrchAllBtn_Click);
            // 
            // Fines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.library_books_00270899;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SrchAllFinesGrp);
            this.Controls.Add(this.RtrnBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ShwAllFinesBtn);
            this.Controls.Add(this.UpdateFineBtn);
            this.Controls.Add(this.FinPayBtn);
            this.Controls.Add(this.PayFineBtn);
            this.Controls.Add(this.SrchFineBtn);
            this.Controls.Add(this.SrchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fines";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Fines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SrchAllFinesGrp.ResumeLayout(false);
            this.SrchAllFinesGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SrchBox;
        private System.Windows.Forms.Button SrchFineBtn;
        private System.Windows.Forms.Button PayFineBtn;
        private System.Windows.Forms.Button FinPayBtn;
        private System.Windows.Forms.Button UpdateFineBtn;
        private System.Windows.Forms.Button ShwAllFinesBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RtrnBtn;
        private System.Windows.Forms.GroupBox SrchAllFinesGrp;
        private System.Windows.Forms.Button ClrAllBtn;
        private System.Windows.Forms.Button SrchAllBtn;
        private System.Windows.Forms.TextBox SrchAllTxtBox;
    }
}