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
    public partial class Student : UserControl
    {
        DB con = new DB();
        public Student()
        {
            InitializeComponent();
        }

       
        public void getTable()
        {
            string selectquery = "select * from Student";
            SqlCommand cmd = new SqlCommand(selectquery, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvShow.DataSource = dt;

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
        private void Refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBSId.Text == "" || txtBSName.Text == "" || txtASName.Text == "" || txtSId.Text == "" || txtSname.Text == "" || txtSphno.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string insert = "insert into Student values('" + txtBSId.Text + "','" + txtBSName.Text + "','" + txtASName.Text + "','" + txtSId.Text + "','" + txtSname.Text + "','" + txtSphno.Text + "','" + txtYear.Text + "','" + dateTime.Value + "')";
                    SqlCommand cmd = new SqlCommand(insert, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rent Successfully");
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
                    string update = "update Student set BId='" + txtBSId.Text + "',BookName='" + txtBSName.Text + "',AurthorName='" + txtASName.Text + "',StudentName='" + txtSname.Text + "',StudentPhno='" + txtSphno.Text + "',Year='" + txtYear.Text + "',RentDate= '" + dateTime.Value + "' where SId='" + txtSId.Text + "'";
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
                    string deletequery = "delete from Student  where SId='" + txtSId.Text + "'";
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
        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBSId.Text= dgvShow.SelectedRows[0].Cells[0].Value.ToString();
            txtBSName.Text= dgvShow.SelectedRows[0].Cells[1].Value.ToString();
            txtASName.Text = dgvShow.SelectedRows[0].Cells[2].Value.ToString();
            txtSId.Text = dgvShow.SelectedRows[0].Cells[3].Value.ToString();
            txtSname.Text = dgvShow.SelectedRows[0].Cells[4].Value.ToString();
            txtSphno.Text = dgvShow.SelectedRows[0].Cells[5].Value.ToString();
            txtYear.Text = dgvShow.SelectedRows[0].Cells[6].Value.ToString();
            if (dgvShow.SelectedRows.Count > 0)
            {
                dateTime.Value = Convert.ToDateTime(dgvShow.SelectedRows[0].Cells[7].Value);

            }
        }

      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string select = "select * from Book where BId='" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(select, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvSearch.DataSource = dt;
            clear();

        }

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBSId.Text = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
            txtBSName.Text = dgvSearch.SelectedRows[0].Cells[1].Value.ToString();
            txtASName.Text = dgvSearch.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    }
