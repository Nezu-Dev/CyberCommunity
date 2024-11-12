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
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Registery Registery = new Registery();
                Registery.Show();
                this.Hide();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ForgotPassword ForgotPassword = new ForgotPassword();


           ForgotPassword.Show();


            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp SignUp = new SignUp();


            SignUp.Show();


            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}