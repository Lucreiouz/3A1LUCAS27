using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1LUCAS27
{
    public partial class Frm_cosmeticos : Form
    {
        public Frm_cosmeticos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cosmeticos obj = new Cosmeticos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastrado com Sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cosmeticos obj = new Cosmeticos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtNome.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Alterar();
            MessageBox.Show("Alterado com Sucesso!");
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cosmeticos obj = new Cosmeticos();
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
            Cosmeticos obj = new Cosmeticos();
            dataGridView1.DataSource = obj.Listar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_venda Frm_venda = new Frm_venda();
            Frm_venda.ShowDialog();
        }
    }
}
