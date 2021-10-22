using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEmCamadasGabriel3b2
{
    public partial class Form5 : Form
    {
        public Form5()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_unidade.Text))
            {
                var unit = new Unidade();
                unit.nomeunidade = txt_unidade.Text;
                unit.Criar();
                dataGridView1.DataSource = unit.Listar();
            }
            else
            {
                MessageBox.Show("Preencha corretamente");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var unit = new Unidade();
            dataGridView1.DataSource = unit.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cadastroSabor = new Form3();
            cadastroSabor.Show();
            Hide();
        }
    }
}

