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
    public partial class excluirProdutoView : Form
    {
        ProdutosController controller;
        public excluirProdutoView()
        {
            InitializeComponent();
            controller = new ProdutosController();

            panel_Dados_Produto_Excluido.Hide();
        }

        private void excluirProdutoView_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            ProdutosClinica pesquisado = controller.pesquisarProduto(txtNomeProduto.Text);
            if (pesquisado != null)
            {
                exibirDadosProduto(pesquisado);
            }
            else
            {
                MessageBox.Show("Produto inexistente!",
                    "Produto Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeProduto.Text = "";
            }
        }

        private void exibirDadosProduto(ProdutosClinica pesquisado)
        {
            panel_Dados_Produto_Excluido.Show();

            txtFibra_exclusao.Text = pesquisado.fibra;
            txtGordura_exclusao.Text = pesquisado.gordura;
            txtSodio_exclusao.Text = pesquisado.sodio;
            txtCarboidratos_exclusao.Text = pesquisado.carboidratos;

            bloquearCamposDadosProduto();

        }

        private void bloquearCamposDadosProduto()
        {
            txtFibra_exclusao.ReadOnly = true;
            txtGordura_exclusao.ReadOnly = true;
            txtSodio_exclusao.ReadOnly = true;
            txtCarboidratos_exclusao.ReadOnly = true;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            panel_Dados_Produto_Excluido.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            controller.excluirProduto(txtNomeProduto.Text);
            MessageBox.Show("Produto Excluído com sucesso!",
                   "Produto Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel_Dados_Produto_Excluido.Hide();
            txtNomeProduto.Text = "";
        }
    }
}