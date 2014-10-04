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
            panel_ALteracao.Hide();
            InitializeComponent();
        }

        ProdutosController controller = new ProdutosController();

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
            txtFibra_alteracao.Text = pesquisado.fibra;
            txtGordura_alteracao.Text = pesquisado.gordura;
            txtSodio_alteracao.Text = pesquisado.sodio;
            txtCarboidratos_alteracao.Text = pesquisado.carboidratos;
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            panel_ALteracao.Hide();
        }
    }
}
