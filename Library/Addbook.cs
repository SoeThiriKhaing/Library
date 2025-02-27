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

namespace Library
{
    public partial class Addbook : UserControl
    {
        DB con = new DB();
        public Addbook()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == "" || txtBName.Text == "" || txtAName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string insertquery = "insert into Book values('" + txtBId.Text + "','" + txtBName.Text + "','" + txtAName.Text + "')";
                    SqlCommand cmd = new SqlCommand(insertquery, con.GetCon());
                    con.OpenCon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add book Successfully");
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
        public void getStudent()
        {
            string selectQuery = "select * from Student";
            SqlCommand cmd = new SqlCommand(selectQuery, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
        }
        public void getReturn()
        {
            string selectQuery = "select * from RBook";
            SqlCommand cmd = new SqlCommand(selectQuery, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
        }
        public void clear()
        {
            txtAName.Clear();
            txtBId.Clear();
            txtBName.Clear();
        }
        public void getTable()
        {
            string selectQuery = "select * from Book";
            SqlCommand cmd = new SqlCommand(selectQuery, con.GetCon());
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBId.Text=="" || txtBName.Text==""|| txtAName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else { 
            try
            {
                string updatequery = "update Book set BookName='" + txtBName.Text + "',AurthorName='" + txtAName.Text + "' where BId='" + txtBId.Text + "'";
                SqlCommand cmd = new SqlCommand(updatequery, con.GetCon());
                con.OpenCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully");
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
        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBId.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtBName.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtAName.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == "" || txtBName.Text == "" || txtAName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string deletequery = "delete from Book  where BId='" + txtBId.Text + "'";
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
        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            getStudent();
        }

        private void lreturn_Click(object sender, EventArgs e)
        {
            getReturn();
        }
    }
}