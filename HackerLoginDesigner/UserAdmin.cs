using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerLoginDesigner
{
    public partial class UserAdmin : Form
    {
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin Admin = new Admin();


            Admin.Show();


            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogIn Form1 = new UserLogIn();


            Form1.Show();


            this.Hide();
        }
    }
}
