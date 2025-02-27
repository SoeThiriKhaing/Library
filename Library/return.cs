using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
namespace Library
{
    public partial class bookReturn : UserControl
    {
        DB con = new DB();


        public bookReturn()
        {
            InitializeComponent();
        }

        private void return_Load(object sender, EventArgs e)
        {





        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string select = "select * from Student where SId='" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(select, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvReturn.DataSource = dt;



        }

        private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txtBSId.Text = dgvReturn.SelectedRows[0].Cells[0].Value.ToString();
                txtBSName.Text = dgvReturn.SelectedRows[0].Cells[1].Value.ToString();
                txtASName.Text = dgvReturn.SelectedRows[0].Cells[2].Value.ToString();
                txtSId.Text = dgvReturn.SelectedRows[0].Cells[3].Value.ToString();
                txtSname.Text = dgvReturn.SelectedRows[0].Cells[4].Value.ToString();
                txtSphno.Text = dgvReturn.SelectedRows[0].Cells[5].Value.ToString();
                txtYear.Text = dgvReturn.SelectedRows[0].Cells[6].Value.ToString();
                if (dgvReturn.SelectedRows.Count > 0)
                {
                    dateTime.Value = Convert.ToDateTime(dgvReturn.SelectedRows[0].Cells[7].Value);

                }
               
            

            
              }
            
            
        public void getTable()
        {
            string selectquery = "select * from RBook ";
            SqlCommand cmd = new SqlCommand(selectquery, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
           
            dgvRbook.DataSource = dt;

        }
        public void clear()
        {
            txtBSId.Clear();
            txtBSName.Clear();
            txtASName.Clear();
            txtSId.Clear();
            txtSname.Clear();
            txtSphno.Clear();
            txtYear.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var rr = returnDate.Value;
            var date = dateTime.Value;
            var ts = TimeSpan.MaxValue;
            ts = rr - date;

            if (rr < date)
            {
                MessageBox.Show("Are you from past?");
            }
            else
            {
                MessageBox.Show(ts.TotalDays.ToString() + "   days");
            }

            if (txtBSId.Text == "" || txtBSName.Text == "" || txtASName.Text == "" || txtSId.Text == "" || txtSname.Text == "" || txtSphno.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {


                    string insert = "insert into RBook values('" + txtBSId.Text + "','" + txtBSName.Text + "','" + txtASName.Text + "','" + txtSId.Text + "','" + txtSname.Text + "','" + txtSphno.Text + "','" + txtYear.Text + "','" + dateTime.Value + "','" + returnDate.Value + "')";
                    SqlCommand cmd = new SqlCommand(insert, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Successfully");
                    con.CloseCon();
                    getTable();
                    clear();


                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.Message);
                }
            }
        }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBSId.Text == "" || txtBSName.Text == "" || txtASName.Text == "" || txtSId.Text == "" || txtSname.Text == "" || txtSphno.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string deletequery = "delete from RBook  where SId='" + txtSId.Text + "'";
                    SqlCommand cmd = new SqlCommand(deletequery, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully");
                    con.CloseCon();
                    getTable();
                    clear();
                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.Message);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBSId.Text == "" || txtBSName.Text == "" || txtASName.Text == "" || txtSId.Text == "" || txtSname.Text == "" || txtSphno.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string update = "update RBook set BId='" + txtBSId.Text + "',BookName='" + txtBSName.Text + "',AurthorName='" + txtASName.Text + "',StudentName='" + txtSname.Text + "',StudentPhno='" + txtSphno.Text + "',Year='" + txtYear.Text + "',RentDate= '" + dateTime.Value + "',ReturnDate='" + returnDate.Value + "' where SId='" + txtSId.Text + "'";
                    SqlCommand cmd = new SqlCommand(update, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("updated Successfully");
                    con.CloseCon();
                    getTable();
                    clear();
                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.Message);
                }
            }
        }
        private void returnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void dgvRbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBSId.Text = dgvRbook.SelectedRows[0].Cells[0].Value.ToString();
            txtBSName.Text = dgvRbook.SelectedRows[0].Cells[1].Value.ToString();
            txtASName.Text = dgvRbook.SelectedRows[0].Cells[2].Value.ToString();
            txtSId.Text = dgvRbook.SelectedRows[0].Cells[3].Value.ToString();
            txtSname.Text = dgvRbook.SelectedRows[0].Cells[4].Value.ToString();
            txtSphno.Text = dgvRbook.SelectedRows[0].Cells[5].Value.ToString();
            txtYear.Text = dgvRbook.SelectedRows[0].Cells[6].Value.ToString();
            if (dgvRbook.SelectedRows.Count > 0)
            {
                dateTime.Value = Convert.ToDateTime(dgvRbook.SelectedRows[0].Cells[7].Value);

            }
            if (dgvRbook.SelectedRows.Count > 0)
            {
                returnDate.Value = Convert.ToDateTime(dgvRbook.SelectedRows[0].Cells[8].Value);

            }

        }

    }
}
 



