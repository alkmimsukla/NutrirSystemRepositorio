using NutrirSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.UserControls
{
    public partial class ucPessoa : UserControl
    {
        CadPacienteController ucPessoaController;

        public ucPessoa()
        {
            InitializeComponent();
            ucPessoaController = new CadPacienteController();
        }

        private void mkdCPF_Leave(object sender, EventArgs e)
        {
            if (mkdCPF.Text.Length < 11)
            {
                MessageBox.Show("Quantidade de caracteres inserida inválida.\nFavor verificar o CPF preenchido e tentar novamente!", "Quantidade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkdCPF.BackColor = Color.Red;
                mkdCPF.Focus();
            }
            else
            {
                decimal cpf = decimal.Parse(mkdCPF.Text);

                if (ucPessoaController.cpfExistente(cpf))
                {
                    MessageBox.Show("CPF já cadastrado na base de dados.\nFavor verificar o CPF preenchido e tentar novamente!", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mkdCPF.BackColor = Color.Red;
                    mkdCPF.Focus();
                }
                else
                {
                    mkdCPF.BackColor = Color.LightGreen;
                }
            }
        }

        private void cmbSexo_Leave(object sender, EventArgs e)
        {
            if ((cmbSexo.Text == "") || (cmbSexo.Text == "Selecione.."))
            {
                cmbSexo.BackColor = Color.Red;
                cmbSexo.Focus();
            }
            else
            {
                cmbSexo.BackColor = Color.LightGreen;
            }
        }

        private void mkdTelefone_Leave(object sender, EventArgs e)
        {
            if (mkdTelefone.Text == "")
            {
                mkdTelefone.BackColor = Color.Red;
                mkdTelefone.Focus();
            }
            else
            {
                mkdTelefone.BackColor = Color.LightGreen;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.BackColor = Color.Red;
                txtNome.Focus();
            }
            else
            {
                txtNome.BackColor = Color.LightGreen;
            }
        }

    }
}
