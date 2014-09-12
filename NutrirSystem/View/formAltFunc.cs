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

namespace View
{
    public partial class formAltFunc : Form
    {
        CadFuncController funcionarioController;

        public formAltFunc()
        {
            InitializeComponent();

            campoSexoAlteracao.DataSource = Enum.GetValues(typeof(Sexo));
            campoPerfilAlteracao.DataSource = Enum.GetValues(typeof(Perfil));

            // escondo campos CRN
            labelCRN.Hide();
            campoCRNAlteracao.Hide();

            //escondo painel dos dados do funcionário buscado.
            panel1.Hide();

            funcionarioController = new CadFuncController();
        }

        private void btBuscarAlteracao_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioBuscado = funcionarioController.buscarFuncionario(decimal.Parse(campoCPFAlteracao.Text.Trim()));

            if (funcionarioBuscado != null)
            {
                preencherCamposView(funcionarioBuscado);
            }

            else
            {
                exibirMsgFuncionarioInexistente();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            bool funcionarioExistente = funcionarioController.VerificarDupCPF(decimal.Parse(campoCPFAlteracao.Text.Trim()));

            if (funcionarioExistente)
            {
                //funcionarioController.alterarFuncionario(decimal.Parse(campoCPFAlteracao.Text.Trim()));
                exibirMsgExclusaoSucesso();
            }
        }

        private void campoCPFAlteracao_TextChanged(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void exibirMsgFuncionarioInexistente()
        {
            MessageBox.Show("Funcionário Inexistente! Busque novamente!");
        }

        private void exibirMsgExclusaoSucesso()
        {
            MessageBox.Show("Funcionário alterado com Sucesso!");
        }

        private void preencherCamposView(Funcionario funcionarioBuscado)
        {
            campoNomeAlteracao.Text = funcionarioBuscado.nome;
            campoApelidoAlteracao.Text = funcionarioBuscado.apelido;
            campoSexoAlteracao.SelectedItem = (Sexo)funcionarioBuscado.sexo;
            campoDtNascAlteracao.Text = funcionarioBuscado.dataNascimento.ToShortDateString();
            campoSalarioAlteracao.Text = funcionarioBuscado.salario.ToString();
            campoRuaAlteracao.Text = funcionarioBuscado.rua;
            campoNumeroAlteracao.Text = funcionarioBuscado.numero.ToString();
            campoBairroAlteracao.Text = funcionarioBuscado.bairro;
            campoEmailAlteracao.Text = funcionarioBuscado.email;
            campoTelefoneAlteracao.Text = funcionarioBuscado.telefone;
            campoCelularAlteracao.Text = funcionarioBuscado.celular;

            //Campos do Login
            campoUsuarioAlteracao.Text = funcionarioBuscado.usuario;
            campoPerfilAlteracao.SelectedItem= (Perfil)funcionarioBuscado.perfil;
            campoSenhaAlteracao.Text = funcionarioBuscado.password;

            if (funcionarioBuscado.perfil != 2)
            {
                campoCRNAlteracao.Visible = false;
            }

            // mostrando panel1
            panel1.Show();
        }
    }
}
