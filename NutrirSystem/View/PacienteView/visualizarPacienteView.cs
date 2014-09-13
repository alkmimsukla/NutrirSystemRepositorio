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

namespace View.PacienteView
{
    public partial class visualizarPacienteView : Form
    {
        CadPacienteController pacienteController;

        public visualizarPacienteView()
        {
            InitializeComponent();
            pacienteController = new CadPacienteController();

            //escondendo painel.
            panel1.Hide();
            
        }

        private void btBuscarAlteracao_Click(object sender, EventArgs e)
        {
            Paciente pacienteBuscado = pacienteController.buscarPaciente(decimal.Parse(campoCPFVisualizacao.Text.Trim()));

            if (pacienteBuscado != null)
            {
                preencherCamposView(pacienteBuscado);
            }

            else
            {
                exibirMsgPacienteInexistente();
            }
        }

        private void exibirMsgPacienteInexistente()
        {
            MessageBox.Show("Paciente Inexistente! Busque novamente!");
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
            campoObjetivoAlteracao.Text = pacienteBuscado.objetivo;
            campoTpSangAlteracao.SelectedItem = (TpSang)pacienteBuscado.tipoSanguineo;
            textBoxesportesPraticados.Text = pacienteBuscado.esportesPraticados;


            // mostrando panel1
            panel1.Show();

            bloquearCamposTela();
        }

        private void btVoltarVisualizacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exibirMsgCPFFormatoInvalido()
        {
            MessageBox.Show("Campo CPF deve ser númerico! Tente novamente!");
        }

        private void campoCPFVisualizacao_KeyUp(object sender, KeyEventArgs e)
        {
            validarFormatoCPF();
        }

        private void validarFormatoCPF()
        {
            string cpfDigitado = campoCPFVisualizacao.Text;
            decimal convertido = 9760; // numero qualquer 
            decimal.TryParse(cpfDigitado, out convertido);

            if (convertido == 0)
            {
                exibirMsgCPFFormatoInvalido();
                campoCPFVisualizacao.Text = "";
            }
        }

        private void bloquearCamposTela()
        {
            campoNomeAlteracao.ReadOnly = true;
            campoApelidoAlteracao.ReadOnly = true;
            campoSexoAlteracao.Enabled = false;
            campoDtNascAlteracao.Enabled= false;
            campoRuaAlteracao.ReadOnly = true;
            campoNumeroAlteracao.ReadOnly = true;
            campoBairroAlteracao.ReadOnly = true;
            campoEmailAlteracao.ReadOnly = true;
            campoTelefoneAlteracao.ReadOnly = true;
            campoCelularAlteracao.ReadOnly = true;
            campoCidadeAlteracao.ReadOnly = true;
            campoEstadoAlteracao.ReadOnly = true;
            campoDtNascAlteracao.Enabled =false;
            campoObjetivoAlteracao.ReadOnly = true;
            campoTpSangAlteracao.Enabled= false;
            textBoxesportesPraticados.ReadOnly = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void campoObjetivoAlteracao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
