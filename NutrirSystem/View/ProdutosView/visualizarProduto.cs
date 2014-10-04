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
    public partial class visualizarProduto : Form
    {
        ProdutosController controller = new ProdutosController();

        public visualizarProduto()
        {
            InitializeComponent();
            panelProduto_View.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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
            panelProduto_View.Show();

            txtFibra_view.Text = pesquisado.fibra;
            txtGordura_view.Text = pesquisado.gordura;
            txtSodio_view.Text = pesquisado.sodio;
            txtCarboidratos_view.Text = pesquisado.carboidratos;

            bloquearCamposDadosProduto();

        }

        private void bloquearCamposDadosProduto()
        {
            txtFibra_view.ReadOnly = true;
            txtGordura_view.ReadOnly = true;
            txtSodio_view.ReadOnly = true;
            txtCarboidratos_view.ReadOnly = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            panelProduto_View.Hide();
        }


    }
}
