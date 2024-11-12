using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace HackerLoginDesigner
{
    public partial class SignUp : Form
    {

        private SqlConnection Baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=Hacker; Integrated Security=true");

        public void Hacker_Add()
        {
            Baglanti.Open();
            string register = "Insert Into Kullanicilar (Username, Password, Mail) Values(@Username, @Password, @Mail)";
            SqlCommand add = new SqlCommand(register, Baglanti);
            add.Parameters.AddWithValue("@Username", textBox1.Text);
            add.Parameters.AddWithValue("@Password", textBox2.Text);
            add.Parameters.AddWithValue("@Mail", textBox3.Text);
            add.ExecuteNonQuery();
            Baglanti.Close();
        
        
        
        }

        public SignUp()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var grs = new UserLogIn();
            grs.Show();

            this.Hide();

            Hacker_Add();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
                textBox2.PasswordChar = '*'; // Şifreyi Gizle
          
        }
    }
}
