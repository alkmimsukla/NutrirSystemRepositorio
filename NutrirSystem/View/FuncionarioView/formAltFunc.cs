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
        Funcionario funcionario;

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
                funcionario = funcionarioBuscado;
                if (funcionarioBuscado.perfil == 2)
                {
                    campoCRNAlteracao.Show();
                }
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

                Perfil per;
                Sexo sex;

                Enum.TryParse<Perfil>(campoPerfilAlteracao.SelectedValue.ToString(), out per);
                Enum.TryParse<Sexo>(campoSexoAlteracao.SelectedValue.ToString(), out sex);

                funcionarioController.alterarFuncionario(decimal.Parse(campoCPFAlteracao.Text.Trim()), campoNomeAlteracao.Text, campoRuaAlteracao.Text,
                    decimal.Parse(campoNumeroAlteracao.Text.Trim()), campoBairroAlteracao.Text, campoCidadeAlteracao.Text, campoEstadoAlteracao.Text,
                    Convert.ToInt32(sex), campoEmailAlteracao.Text, campoDtNascAlteracao.SelectionEnd, campoTelefoneAlteracao.Text, campoCelularAlteracao.Text,
                    campoApelidoAlteracao.Text, campoUsuarioAlteracao.Text, campoSenhaAlteracao.Text, Convert.ToInt32(per), funcionario, decimal.Parse(campoCRNAlteracao.Text));
                exibirMsgAlteracaoSucesso();
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

        private void exibirMsgAlteracaoSucesso()
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
            campoCidadeAlteracao.Text = funcionarioBuscado.cidade;
            campoEstadoAlteracao.Text = funcionarioBuscado.estado;
            campoDtNascAlteracao.TodayDate = funcionarioBuscado.dataNascimento;

            //Campos do Login
            campoUsuarioAlteracao.Text = funcionarioBuscado.usuario;
            campoPerfilAlteracao.SelectedItem= (Perfil)funcionarioBuscado.perfil;
            campoSenhaAlteracao.Text = funcionarioBuscado.password;

            if (funcionarioBuscado.perfil == 2)
            {
                campoCRNAlteracao.Text = ((Nutricionista)funcionarioBuscado).crm.ToString();
                labelCRN.Show();
            }

            // mostrando panel1
            panel1.Show();
        }

        private void validarFormatoCPF()
        {
            string cpfDigitado = campoCPFAlteracao.Text;
            decimal convertido = 9760; // numero qualquer 
            decimal.TryParse(cpfDigitado, out convertido);

            if (convertido == 0)
            {
                exibirMsgCPFFormatoInvalido();
                campoCPFAlteracao.Text = "";
            }
        }

        private void exibirMsgCPFFormatoInvalido()
        {
            MessageBox.Show("Campo CPF deve ser númerico! Tente novamente!");
        }

        private void campoNomeAlteracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoCPFAlteracao_KeyUp(object sender, KeyEventArgs e)
        {
            validarFormatoCPF();
        }

        private void btVoltarAlteracaoView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
