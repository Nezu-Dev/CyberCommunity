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
    public partial class AdminFirstPage : Form
    {
        public AdminFirstPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonnelReg PersonnelReg = new PersonnelReg();


            PersonnelReg.Show();

            this.Hide();
        }
    }
}
