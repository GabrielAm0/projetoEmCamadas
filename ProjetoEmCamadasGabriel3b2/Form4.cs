using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEmCamadasGabriel3b2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saborSorvete = new Sabor();
            saborSorvete.tipo = comboBox1.SelectedItem.ToString();
            saborSorvete.Nome_sabor = textBox1.Text;
            saborSorvete.Criar();
            dataGridView1.DataSource = saborSorvete.Listar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            var SABORSORVETE = new Sabor();
            dataGridView1.DataSource = SABORSORVETE.Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cadastroSabor = new Form3();
            cadastroSabor.Show();
            Hide();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            var SABORSORVETE = new Sabor();
            dataGridView1.DataSource = SABORSORVETE.Listar();
        }
    }
}
