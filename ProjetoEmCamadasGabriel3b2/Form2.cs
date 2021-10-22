using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEmCamadasGabriel3b2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.email = txt_email.Text;
            Usuario.senha = txt_senha.Text;
            Usuario.Criar();

            MessageBox.Show("Usuario Cadastrado com sucesso!");

           Form1 Login = new Form1();
            Login.Show();
            Hide();
        }
    }
}
