using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1LUCAS27
{
    public partial class Frm_venda : Form
    {
        public Frm_venda()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.vendedor = txtNome.Text;
            obj.quantidade = Convert.ToDouble(txtQuantidade.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastrado com Sucesso!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.vendedor = txtNome.Text;
            obj.quantidade = Convert.ToDouble(txtQuantidade.Text);
            obj.Alterar();
            MessageBox.Show("Alterado com Sucesso!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtQuantidade.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Vendedor obj = new Vendedor();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_cosmeticos Frm_cosmeticos = new Frm_cosmeticos();
            Frm_cosmeticos.ShowDialog();
        }
    }
}
