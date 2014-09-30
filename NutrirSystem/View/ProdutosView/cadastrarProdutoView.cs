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

        }

        private bool camposPreenchidos()
        {
            if (txtNomeProduto.Text == "")
            {
                return false;
            }
            else
            {
                if ((txtCarboidratos.Text == "") || (txtFibra.Text == "") || (txtGordura.Text == "") || (txtSodio.Text == ""))
                    return false;
                else
                    return true;
            }


        }
    }
}
