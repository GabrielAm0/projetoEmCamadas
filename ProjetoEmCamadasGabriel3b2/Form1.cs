using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmCamadasGabriel3b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_senha.Text))
            {
                Usuario.email = txt_email.Text;
                Usuario.senha = txt_senha.Text;

                if (Usuario.Login())
                {
                    Form3 main = new Form3();
                    main.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Faz certo fdp");
                }
            }
            else
            {
                MessageBox.Show ("Faz certo fdp");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cadastro = new Form2();
            cadastro.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
