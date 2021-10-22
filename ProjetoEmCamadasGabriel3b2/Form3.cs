using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEmCamadasGabriel3b2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 cadastroUnidade = new Form5();
            cadastroUnidade.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 cadastroSabor = new Form4();
            cadastroSabor.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 cadastroSabor = new Form1();
            cadastroSabor.Show();
            Hide();
        }
    }
}
