using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme2
{
    public partial class Form1 : Form
    {
        string message = "Kayıt Başarıyla Oluşturulmuştur.";
        string sifre = "Şifreleriniz Eşleşmesi Gerekiyor !";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox5 = new TextBox();
            textbox5.Text = "";

        }
        private void cbsifre_CheckedChanged(object sender, EventArgs e)
        {

            //textBox5.UseSystemPasswordChar = !cbsifre.Checked;
            if (cbsifre.Checked)
            {
                string a = textBox5.Text;
                textBox5.PasswordChar = '\0';
                textBox6.PasswordChar = '\0';
            }
            else
            {
                textBox5.PasswordChar = '*';
                textBox6.PasswordChar = '*';
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox3 = new TextBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show(sifre);
            }
            else
            {
                MessageBox.Show(message);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox1 = new TextBox();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox6 = new TextBox();
            textbox6.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox2 = new TextBox();

        }

    }
}
