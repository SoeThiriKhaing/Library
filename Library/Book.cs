using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void Book_Load(object sender, EventArgs e)
        {
          

            
        }

      

        private void logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            logout.ForeColor = Color.Red;
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;
        }
        //Addbook ab;
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
          
           var ab = new Addbook() { Dock = DockStyle.Fill };
            panelContainer.Controls.Add(ab);
            ab.BringToFront();
            
        }

        private void addbook1_Load(object sender, EventArgs e)
        {

        }
       
        private void stuLists_Click(object sender, EventArgs e)
        {
           
           var stu = new Student() { Dock = DockStyle.Fill };
            panelContainer.Controls.Add(stu);
            stu.BringToFront();
        }

        private void bookReturn_Click(object sender, EventArgs e)
        {
            var re = new bookReturn() { Dock = DockStyle.Fill };
            panelContainer.Controls.Add(re);
            re.BringToFront();
        }

        private void addbook1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
