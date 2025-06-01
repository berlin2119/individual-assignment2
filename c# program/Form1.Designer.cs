namespace LibrarySystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBorrow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBorowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTIme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUSer = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Location = new System.Drawing.Point(18, 158);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(178, 23);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(18, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Over Due";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(213, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Return";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(213, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageCategoriesToolStripMenuItem,
            this.manageBooksToolStripMenuItem,
            this.manageBorowersToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.userLogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            this.manageCategoriesToolStripMenuItem.Click += new System.EventHandler(this.manageCategoriesToolStripMenuItem_Click);
            // 
            // manageBooksToolStripMenuItem
            // 
            this.manageBooksToolStripMenuItem.Name = "manageBooksToolStripMenuItem";
            this.manageBooksToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.manageBooksToolStripMenuItem.Text = "Manage Books";
            this.manageBooksToolStripMenuItem.Click += new System.EventHandler(this.manageBooksToolStripMenuItem_Click);
            // 
            // manageBorowersToolStripMenuItem
            // 
            this.manageBorowersToolStripMenuItem.Name = "manageBorowersToolStripMenuItem";
            this.manageBorowersToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.manageBorowersToolStripMenuItem.Text = "Manage Borowers";
            this.manageBorowersToolStripMenuItem.Click += new System.EventHandler(this.manageBorowersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.userLogsToolStripMenuItem.Text = "User Logs";
            this.userLogsToolStripMenuItem.Click += new System.EventHandler(this.userLogsToolStripMenuItem_Click);
            // 
            // lblTIme
            // 
            this.lblTIme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTIme.BackColor = System.Drawing.Color.Transparent;
            this.lblTIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIme.ForeColor = System.Drawing.Color.Red;
            this.lblTIme.Location = new System.Drawing.Point(18, 357);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(367, 77);
            this.lblTIme.TabIndex = 12;
            this.lblTIme.Text = "00:00";
            this.lblTIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(18, 446);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(367, 77);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "mm/dd/yyyy";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUSer
            // 
            this.lblUSer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUSer.BackColor = System.Drawing.Color.Transparent;
            this.lblUSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSer.ForeColor = System.Drawing.Color.Black;
            this.lblUSer.Location = new System.Drawing.Point(18, 535);
            this.lblUSer.Name = "lblUSer";
            this.lblUSer.Size = new System.Drawing.Size(367, 77);
            this.lblUSer.TabIndex = 14;
            this.lblUSer.Text = "Janobe Source Code";
            this.lblUSer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(419, 31);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(483, 646);
            this.crystalReportViewer1.TabIndex = 15;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::LibrarySystem.Properties.Resources.unlock;
            this.pictureBox4.Location = new System.Drawing.Point(213, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 125);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 689);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lblUSer);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTIme);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBorowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUSer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
    }
}

