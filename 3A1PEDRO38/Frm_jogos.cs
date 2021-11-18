using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1PEDRO38
{
    public partial class Frm_jogos : Form
    {
        public Frm_jogos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Jogos obj = new Jogos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Jogos obj = new Jogos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Alterar();
            MessageBox.Show("ALTERADO!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Jogos obj = new Jogos();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Jogos obj = new Jogos();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_vendedor Frm_vendedor = new Frm_vendedor();
            Frm_vendedor.ShowDialog();
        }
    }
}
