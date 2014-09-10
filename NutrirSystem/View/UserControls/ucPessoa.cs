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
            if (ucPessoaController.cpfExistente(mkdCPF.Text))
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
}
