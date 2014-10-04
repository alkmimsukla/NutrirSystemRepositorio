using NutrirSystem.Controller;
using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.ProdutosView
{
    public partial class alterarProdutoView : Form
    {
        public alterarProdutoView()
        {
            InitializeComponent();
            panel_ALteracao.Hide();
        }

        ProdutosController controller = new ProdutosController();
        ProdutosClinica produto;

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            ProdutosClinica pesquisado = controller.pesquisarProduto(txtNomeProduto.Text);
            produto = pesquisado;

            if (pesquisado != null)
            {
                exibirDadosProduto(pesquisado);
            }
            else
            {
                MessageBox.Show("Produto inexistente!",
                    "Produto Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
            }
        }

        private void exibirDadosProduto(ProdutosClinica pesquisado)
        {
            panel_ALteracao.Show();

            txtFibra_alteracao.Text = pesquisado.fibra;
            txtGordura_alteracao.Text = pesquisado.gordura;
            txtSodio_alteracao.Text = pesquisado.sodio;
            txtCarboidratos_alteracao.Text = pesquisado.carboidratos;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            panel_ALteracao.Hide();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            controller.alterarProduto(txtNomeProduto.Text, txtSodio_alteracao.Text, txtCarboidratos_alteracao.Text,
                txtGordura_alteracao.Text, txtFibra_alteracao.Text, produto);

            MessageBox.Show("Produto alterado com sucesso!", "Alteração de Produto", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtNomeProduto.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
