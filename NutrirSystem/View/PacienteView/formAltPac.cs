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
    public partial class formAltPac : Form
    {
        CadPacienteController pacienteController;
        Paciente paciente;

        public formAltPac()
        {
            InitializeComponent();

            campoSexoAlteracao.DataSource = Enum.GetValues(typeof(Sexo));

            //escondo painel dos dados do funcionário buscado.
            panel1.Hide();

            pacienteController = new CadPacienteController();
        }

        private void btBuscarAlteracao_Click(object sender, EventArgs e)
        {
            Paciente pacienteBuscado = pacienteController.buscarPaciente(decimal.Parse(campoCPFAlteracao.Text.Trim()));

            if (pacienteBuscado != null)
            {
                preencherCamposView(pacienteBuscado);
                paciente = pacienteBuscado;
            }

            else
            {
                exibirMsgFuncionarioInexistente();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            bool funcionarioExistente = pacienteController.cpfExistente(decimal.Parse(campoCPFAlteracao.Text.Trim()));

            if (funcionarioExistente)
            {

                Sexo sex;
                TpSang tps;

                Enum.TryParse<Sexo>(campoSexoAlteracao.SelectedValue.ToString(), out sex);
                Enum.TryParse<TpSang>(campoSexoAlteracao.SelectedValue.ToString(), out tps);

                pacienteController.alterarPaciente(decimal.Parse(campoCPFAlteracao.Text.Trim()), campoNomeAlteracao.Text, campoRuaAlteracao.Text,
                    decimal.Parse(campoNumeroAlteracao.Text.Trim()), campoBairroAlteracao.Text, campoCidadeAlteracao.Text, campoEstadoAlteracao.Text,
                    Convert.ToInt32(sex), campoEmailAlteracao.Text, campoDtNascAlteracao.SelectionEnd, campoTelefoneAlteracao.Text, campoCelularAlteracao.Text,
                    campoApelidoAlteracao.Text,campoObjetivoAlteracao.Text, Convert.ToInt32(tps), paciente);
                exibirMsgAlteracaoSucesso();
            }
        }

        private void campoCPFAlteracao_TextChanged(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void exibirMsgFuncionarioInexistente()
        {
            MessageBox.Show("Paciente Inexistente ou CPF pertence a Funcionario! Busque novamente!");
        }

        private void exibirMsgAlteracaoSucesso()
        {
            MessageBox.Show("Funcionário alterado com Sucesso!");
        }

        private void preencherCamposView(Paciente pacienteBuscado)
        {
            campoNomeAlteracao.Text = pacienteBuscado.nome;
            campoApelidoAlteracao.Text = pacienteBuscado.apelido;
            campoSexoAlteracao.SelectedItem = (Sexo)pacienteBuscado.sexo;
            campoDtNascAlteracao.Text = pacienteBuscado.dataNascimento.ToShortDateString();
            campoRuaAlteracao.Text = pacienteBuscado.rua;
            campoNumeroAlteracao.Text = pacienteBuscado.numero.ToString();
            campoBairroAlteracao.Text = pacienteBuscado.bairro;
            campoEmailAlteracao.Text = pacienteBuscado.email;
            campoTelefoneAlteracao.Text = pacienteBuscado.telefone;
            campoCelularAlteracao.Text = pacienteBuscado.celular;
            campoCidadeAlteracao.Text = pacienteBuscado.cidade;
            campoEstadoAlteracao.Text = pacienteBuscado.estado;
            campoDtNascAlteracao.TodayDate = pacienteBuscado.dataNascimento;
            campoObjetivoAlteracao.Text = paciente.objetivo;
            campoTpSangAlteracao.SelectedItem = (TpSang)pacienteBuscado.tipoSanguineo;


            // mostrando panel1
            panel1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formAltPac_Load(object sender, EventArgs e)
        {

        }


    }
}
