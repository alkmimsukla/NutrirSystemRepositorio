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
    public partial class formVisFunc : Form
    {
        CadFuncController funcionarioController;
        Funcionario funcionario;

        public formVisFunc()
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


        private void campoCPFAlteracao_TextChanged(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void exibirMsgFuncionarioInexistente()
        {
            MessageBox.Show("Funcionário Inexistente! Busque novamente!");
        }

        private void blockCampos()
        {
            campoCPFAlteracao.ReadOnly = true;

            campoSexoAlteracao.Enabled = false;
            campoPerfilAlteracao.Enabled = false;

            foreach (Control Box in this.panel1.Controls)
            {
                if (Box is TextBoxBase)
                {
                    ((TextBoxBase)Box).ReadOnly = true;
                }
            }
            foreach (Control Box in this.groupBox1.Controls)
            {
                if (Box is TextBoxBase)
                {
                    ((TextBoxBase)Box).ReadOnly = true;
                }
            }
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

            this.blockCampos();

            // mostrando panel1
            panel1.Show();

        }

        private void campoNomeAlteracao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
