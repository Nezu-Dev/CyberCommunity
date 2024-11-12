using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HackerLoginDesigner
{
    public partial class PersonnelReg : Form
    {
        string ResimYolu;
        public PersonnelReg()
        {
            InitializeComponent();
        }

        private void PersonnelReg_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                ResimYolu = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String  MedeniDurum = radioButton1.Checked ? "Bekar" : "Evli";

            DialogResult MesajSonuc = MessageBox.Show("Personeli Kaydetmek İstiyormusun", "Kayıt Uyarı Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (MesajSonuc == DialogResult.Yes)
            {
                listBox1.Items.Add("Kişisel Bilgileri        : " + "Adı: " + textBox1.Text + " | Soyadı: " + textBox2.Text + " | Doğum Tarihi: " + maskedTextBox1.Text + " | Cinsiyet: " + comboBox1.Text + " | Medeni Durum: " + MedeniDurum);
                listBox1.Items.Add("İletişim Bilgileri       : " + "Telefon: " + maskedTextBox2.Text + " | E-posta: " + textBox4.Text + " | Şehir: " + comboBox2.Text + " | Sosyal Medya Profili: " + textBox5.Text + " | Acil Durum İletişim: " + maskedTextBox3.Text);
                listBox1.Items.Add("İş Bilgileri             : " + "Departman: " + comboBox3.Text + " | Meslek: " + textBox6.Text + " | Deneyim Yılı: " + comboBox4.Text + " | İstediği Maaş: " + textBox3.Text + " | LinkedIn: " + textBox7.Text);
                listBox1.Items.Add("Siber Güvenlik Bilgileri : " + "Uzmanlık Alanları: " + textBox10.Text + " | Programlama Dilleri: " + textBox9.Text + " | Sertifikalar: " + textBox11.Text + " | Linux Bilgisi: " + comboBox5.Text);
                listBox1.Items.Add("Deneyim                  : " + richTextBox1.Text);
                listBox1.Items.Add("Resim Yolu" + ResimYolu);
                MessageBox.Show("Personel Kayıt İşlemi Tamamlandı", "Kayıt Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
