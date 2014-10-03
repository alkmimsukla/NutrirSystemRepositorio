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
    public partial class cadastrarProdutoView : Form
    {
        ProdutosController prodControl = new ProdutosController();

        public cadastrarProdutoView()
        {
            InitializeComponent();
        }

        private void btnGravarProdutos_Click(object sender, EventArgs e)
        {
            if (!camposPreenchidos())
            {
                MessageBox.Show("Nem todos os valores foram preenchidos corretamente.\nFavor verificar!",
                        "Validação dos Campos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNomeProduto.Focus();
            }
            else if (produtoExiste())
            {
                MessageBox.Show("Produto já existe na base de dados. Não é possível inserí-lo!",
                    "Produto Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProdutosClinica prod = new ProdutosClinica();

                prod.nome = txtNomeProduto.Text;
                prod.carboidratos = txtCarboidratos.Text;
                prod.fibra = txtFibra.Text;
                prod.gordura = txtGordura.Text;
                prod.sodio = txtSodio.Text;

                prodControl.inserirProduto(prod);

                MessageBox.Show("Produto cadastrado no banco com sucesso", "Inserção concluída",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool camposPreenchidos()
        {
            if (txtNomeProduto.Text == "")
                return false;
            else
            {
                if ((txtCarboidratos.Text == "") || (txtFibra.Text == "") || (txtGordura.Text == "") || (txtSodio.Text == ""))
                    return false;
                else
                    return true;
            }
        }

        private bool produtoExiste()
        {
            return (prodControl.produtoExiste(txtNomeProduto.Text));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
