
namespace Library
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.cross = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookReturn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.logout = new System.Windows.Forms.Label();
            this.stuLists = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.addBook = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.addbook1 = new Library.Addbook();
            this.student1 = new Library.Student();
            this.return1 = new Library.bookReturn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cross
            // 
            this.cross.AutoSize = true;
            this.cross.Dock = System.Windows.Forms.DockStyle.Right;
            this.cross.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross.ForeColor = System.Drawing.Color.Red;
            this.cross.Location = new System.Drawing.Point(882, 0);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(28, 26);
            this.cross.TabIndex = 1;
            this.cross.Text = "X";
            this.cross.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cross);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 110);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"Library Management System\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(791, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 678);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 57);
            this.label8.TabIndex = 9;
            this.label8.Text = "A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 57);
            this.label7.TabIndex = 8;
            this.label7.Text = "L";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 57);
            this.label6.TabIndex = 8;
            this.label6.Text = "T";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 57);
            this.label5.TabIndex = 6;
            this.label5.Text = "M";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 57);
            this.label4.TabIndex = 5;
            this.label4.Text = "S";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil Std", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "U";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Controls.Add(this.bookReturn);
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.stuLists);
            this.panel3.Controls.Add(this.addBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 678);
            this.panel3.TabIndex = 8;
            // 
            // bookReturn
            // 
            this.bookReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookReturn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookReturn.FillColor = System.Drawing.Color.DarkTurquoise;
            this.bookReturn.FillColor2 = System.Drawing.Color.DarkTurquoise;
            this.bookReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bookReturn.ForeColor = System.Drawing.Color.White;
            this.bookReturn.Image = ((System.Drawing.Image)(resources.GetObject("bookReturn.Image")));
            this.bookReturn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookReturn.ImageSize = new System.Drawing.Size(100, 80);
            this.bookReturn.Location = new System.Drawing.Point(0, 420);
            this.bookReturn.Name = "bookReturn";
            this.bookReturn.Size = new System.Drawing.Size(124, 142);
            this.bookReturn.TabIndex = 3;
            this.bookReturn.Text = "Book Return";
            this.bookReturn.Click += new System.EventHandler(this.bookReturn_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(12, 624);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(105, 29);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseEnter += new System.EventHandler(this.logout_MouseEnter);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            // 
            // stuLists
            // 
            this.stuLists.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stuLists.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stuLists.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stuLists.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stuLists.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stuLists.FillColor = System.Drawing.Color.DarkTurquoise;
            this.stuLists.FillColor2 = System.Drawing.Color.DarkTurquoise;
            this.stuLists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.stuLists.ForeColor = System.Drawing.Color.White;
            this.stuLists.Image = ((System.Drawing.Image)(resources.GetObject("stuLists.Image")));
            this.stuLists.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stuLists.ImageSize = new System.Drawing.Size(100, 80);
            this.stuLists.Location = new System.Drawing.Point(0, 205);
            this.stuLists.Name = "stuLists";
            this.stuLists.Size = new System.Drawing.Size(124, 142);
            this.stuLists.TabIndex = 1;
            this.stuLists.Text = "Students";
            this.stuLists.Click += new System.EventHandler(this.stuLists_Click);
            // 
            // addBook
            // 
            this.addBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBook.FillColor = System.Drawing.Color.DarkTurquoise;
            this.addBook.FillColor2 = System.Drawing.Color.DarkTurquoise;
            this.addBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addBook.ForeColor = System.Drawing.Color.White;
            this.addBook.Image = ((System.Drawing.Image)(resources.GetObject("addBook.Image")));
            this.addBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addBook.ImageSize = new System.Drawing.Size(100, 80);
            this.addBook.Location = new System.Drawing.Point(0, 0);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(124, 142);
            this.addBook.TabIndex = 0;
            this.addBook.Text = "Add Book";
            this.addBook.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // gunaAreaDataset1
            // 
            this.gunaAreaDataset1.BorderColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.FillColor = System.Drawing.Color.Empty;
            this.gunaAreaDataset1.Label = "Area1";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.addbook1);
            this.panelContainer.Controls.Add(this.student1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(124, 110);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(667, 678);
            this.panelContainer.TabIndex = 4;
            // 
            // addbook1
            // 
            this.addbook1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbook1.Location = new System.Drawing.Point(0, 0);
            this.addbook1.Name = "addbook1";
            this.addbook1.Size = new System.Drawing.Size(667, 678);
            this.addbook1.TabIndex = 1;
            this.addbook1.Load += new System.EventHandler(this.addbook1_Load_1);
            // 
            // student1
            // 
            this.student1.BackColor = System.Drawing.Color.Aqua;
            this.student1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student1.Location = new System.Drawing.Point(0, 0);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(667, 678);
            this.student1.TabIndex = 0;
            // 
            // return1
            // 
            this.return1.Location = new System.Drawing.Point(0, 0);
            this.return1.Name = "return1";
            this.return1.Size = new System.Drawing.Size(1274, 646);
            this.return1.TabIndex = 0;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(910, 788);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cross;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private System.Windows.Forms.Label logout;
        private Guna.UI2.WinForms.Guna2GradientTileButton stuLists;
        private Guna.UI2.WinForms.Guna2GradientTileButton addBook;
        private Guna.UI2.WinForms.Guna2GradientTileButton bookReturn;
        private System.Windows.Forms.Panel panelContainer;
        private Addbook addbook1;
        private Student student1;
        private bookReturn return1;
    }
}