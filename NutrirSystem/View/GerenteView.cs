using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class GerenteView : Form
    {
        public GerenteView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCadFunc formCad = new formCadFunc();
            formCad.Show();
        }

        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            removerFuncionarioView removerFunc = new removerFuncionarioView();
            removerFunc.Show();
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            formAltFunc alterarFunc = new formAltFunc();
            alterarFunc.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new View.formVisFunc().Show();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            new View.Relatorios.formRelatorioClientes().Show();
        }
    }
}
