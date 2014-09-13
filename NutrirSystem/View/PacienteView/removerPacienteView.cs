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
    public partial class removerPacienteView : Form
    {
        CadPacienteController controllerPaciente;

        public removerPacienteView()
        {
            InitializeComponent();

            controllerPaciente = new CadPacienteController();

            cmbTipoSanguineo.DataSource = Enum.GetValues(typeof(TpSang));
            ucPessoa1.cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));

            esconderMostrarCamposDoPacienteRecuperado(true);
        }

        private void btnRemoverPaciente_Click(object sender, EventArgs e)
        {
            bool pacienteExistente= controllerPaciente.cpfExistente(decimal.Parse(campoCPFRemocao.Text.Trim()));

            if (pacienteExistente)
            {
                controllerPaciente.excluirPaciente(decimal.Parse(campoCPFRemocao.Text.Trim()));
                exibirMsgExclusaoSucesso();
            }
        }

        private void exibirMsgExclusaoSucesso()
        {
            MessageBox.Show("Paciente Excluído com sucesso!");
        }

        private void btBuscarRemocao_Click(object sender, EventArgs e)
        {
            Paciente buscado = controllerPaciente.buscarPaciente(decimal.Parse(campoCPFRemocao.Text));
            if (buscado != null)
            {
                preencherCamposView(buscado);
            }

            else
            {
                exibirMsgPacienteInexistente();
            }
        }

        private void preencherCamposView(Paciente paciente)
        {
            esconderMostrarCamposDoPacienteRecuperado(false);

            ucPessoa1.mkdCPF.Text = paciente.cpf.ToString();
            ucPessoa1.txtNome.Text = paciente.nome;
            ucPessoa1.txtApelido.Text = paciente.apelido;

            ucPessoa1.cmbSexo.SelectedItem = (Sexo)paciente.sexo;

            ucPessoa1.dtmDataNascimento.Text = paciente.dataNascimento.ToShortDateString();
            ucPessoa1.txtEmail.Text = paciente.email;

            ucPessoa1.mkdTelefone.Text = paciente.telefone;
            ucPessoa1.mkdCelular.Text = paciente.celular;
            ucEndereco1.txtRua.Text = paciente.rua;

            ucEndereco1.txtNumero.Text = paciente.numero.ToString();
            ucEndereco1.txtBairro.Text = paciente.bairro;
            ucEndereco1.txtCidade.Text = paciente.cidade;
            ucEndereco1.cmbEstado.Text = paciente.estado;

            txtObjetivo.Text = paciente.objetivo;
            textBox1.Text = paciente.esportesPraticados;

            cmbTipoSanguineo.SelectedItem = (TpSang)paciente.tipoSanguineo;

            if (paciente.Convenio != null && paciente.Convenio.Count() != 0)
            {
                mostrarCamposConvenio();

                txtNomeConvenio.Text = paciente.Convenio.SingleOrDefault().nome;
                txtNumConvenio.Text = paciente.Convenio.SingleOrDefault().numPlano.ToString();
            }
            else
            {
                esconderCamposConvenio();
            }

            bloquearCamposPacienteRecuperado();            
        }

        private void esconderCamposConvenio()
        {
            chbConvenio.CheckState = CheckState.Checked;
            lblConvenio.Hide();
            txtNomeConvenio.Hide();

            lblNumConvenio.Hide();
            txtNumConvenio.Hide();

            txtNomeConvenio.Enabled = false;
            txtNumConvenio.Enabled = false;
        }

        private void mostrarCamposConvenio()
        {
            chbConvenio.CheckState = CheckState.Checked;
            lblConvenio.Show();
            txtNomeConvenio.Show();

            lblNumConvenio.Show();
            txtNumConvenio.Show();

            txtNomeConvenio.Enabled = false;
            txtNumConvenio.Enabled = false;
        }

        private void exibirMsgPacienteInexistente()
        {
            MessageBox.Show("Paciente Inexistente! Busque novamente!");
        }

        private void campoIDRemocao_TextChanged(object sender, EventArgs e)
        {
            esconderMostrarCamposDoPacienteRecuperado(true);

        }

        private void esconderMostrarCamposDoPacienteRecuperado(bool esconder)
        {
            if (esconder)
            {
                tableLayoutPanel1.Hide();
                ucEndereco1.Hide();
                ucPessoa1.Hide();
            }

            else
            {
                tableLayoutPanel1.Show();
                ucEndereco1.Show();
                ucPessoa1.Show();
            }
        }

        private void bloquearCamposPacienteRecuperado()
        {
            ucPessoa1.mkdCPF.ReadOnly = true;
            ucPessoa1.txtNome.ReadOnly = true;
            ucPessoa1.txtApelido.ReadOnly = true;

            ucPessoa1.dtmDataNascimento.Enabled = false;
            ucPessoa1.txtEmail.ReadOnly = true;

            ucPessoa1.mkdTelefone.ReadOnly = true;
            ucPessoa1.mkdCelular.ReadOnly = true;
            ucEndereco1.txtRua.ReadOnly = true;

            ucEndereco1.txtNumero.ReadOnly = true;
            ucEndereco1.txtBairro.ReadOnly = true;
            ucEndereco1.txtCidade.ReadOnly = true;
            ucEndereco1.cmbEstado.Enabled= false;

            txtObjetivo.ReadOnly = true;
            txtObjetivo.ReadOnly = true;

            txtNomeConvenio.ReadOnly = true;
            txtNumConvenio.ReadOnly = true;
            ucPessoa1.cmbSexo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPessoa1_Load(object sender, EventArgs e)
        {

        }
    }
}
