using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Includes;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public void enabled_menu()
        //{
        //    ts_login.Text = "Logout";
        //    ts_books.Enabled = true;
        //    ts_transaction.Enabled = true;
        //    ts_borrower.Enabled = true;
        //    ts_categories.Enabled = true;
        //    ts_users.Enabled = true;
        //    ts_reports.Enabled = true;
        //    ts_logs.Enabled = true;
        //    ts_login.Image = Properties.Resources.unlock;
        //}

        //public void disabled_menu()
        //{
        //    ts_login.Text = "Login";
        //    ts_books.Enabled = false;
        //    ts_transaction.Enabled = false;
        //    ts_borrower.Enabled = false;
        //    ts_categories.Enabled = false;
        //    ts_users.Enabled = false;
        //    ts_reports.Enabled = false;
        //    ts_logs.Enabled = false;
        //    ts_login.Image = Properties.Resources._lock;
        //}
       SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void reports(string sql, string rptname)
        {
            try
            {
                config.loadReports(sql);
                string reportname, strReportPath;

                reportname = rptname;
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                strReportPath = Application.StartupPath + "\\report\\" + reportname + ".rpt";
                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
                crystalReportViewer1.ShowRefreshButton = false;
                crystalReportViewer1.ShowCloseButton = false;
                crystalReportViewer1.ShowGroupTreeButton = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " No crytal reports installed.");
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //disabled_menu();
            sql = "SELECT `Fullname`, `User_name`, `UserRole`,`LogDate`, `LogMode` FROM `tbllogs` l, `tbluser` u WHERE l.`UserId`=u.`UserId`";
            reports(sql, "LogsReport");
            timer1.Start();
        }

        private void ts_books_Click(object sender, EventArgs e)
        {
        }

        private void ts_BorrowItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ts_returnItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ts_overdueItem_Click(object sender, EventArgs e)
        {
         
        }

        private void ts_borrower_Click(object sender, EventArgs e)
        {
         
        }

        private void ts_categories_Click(object sender, EventArgs e)
        {
           
        }

        private void ts_users_Click(object sender, EventArgs e)
        {
           
        }

        private void ts_reports_Click(object sender, EventArgs e)
        {
           
        }

        private void ts_logs_Click(object sender, EventArgs e)
        {
           
        }

        private void ts_login_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin(this);

            //if (ts_login.Text == "Login")
            //{
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    ts_login.Text = "Login";
            //    disabled_menu();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Today;
            
            lblTIme.Text = time.ToLongTimeString();
            lblDate.Text = time.ToShortDateString();
        }

        private void manageCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCategories();
            frm.ShowDialog();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new frmBooks();
            frm.ShowDialog();
        }

        private void manageBorowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrower();
            frm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReport();
            frm.ShowDialog();
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogs();
            frm.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Form frm = new frmBorrow();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturned();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmOverdue();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frm_login();
            frm.Show();
            this.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.ShowDialog();
        }
 
    }
}
