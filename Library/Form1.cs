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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tPwd.Text == String.Empty || tName.Text == String.Empty)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (tName.Text == "" || tName.Text != "ucsmtla")
                {
                    MessageBox.Show("Please Enter UserName");
                }
                else
                {
                    if (tPwd.Text == "" || tPwd.Text != "123456")
                    {
                        MessageBox.Show("Please Enter Password");

                    }
                    else
                    {
                        if (tName.Text == "ucsmtla" && tPwd.Text == "123456")
                        {
                            Book book = new Book();
                            book.Show();
                            this.Hide();
                        }

                    }


                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
