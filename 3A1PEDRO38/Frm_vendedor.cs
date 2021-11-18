using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1PEDRO38
{
    public partial class Frm_vendedor : Form
    {
        public Frm_vendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_jogos Frm_jogos = new Frm_jogos();
            Frm_jogos.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtVendedor.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome_vendedor = txtVendedor.Text;
            obj.quantidade = (int)Convert.ToInt64(txtQuantidade.Text);
            obj.Alterar();
            MessageBox.Show("Alterado!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtVendedor.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome_vendedor = txtVendedor.Text;
            obj.quantidade = (int)Convert.ToInt64(txtQuantidade.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtVendedor.Clear();
            dataGridView1.DataSource = obj.Listar();
        }
    }
}
