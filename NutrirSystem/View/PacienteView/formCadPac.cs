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
    public partial class formCadPac : Form
    {
        CadPacienteController cadPacienteControl;

        public formCadPac()
        {
            InitializeComponent();

            lblConvenio.Hide();
            txtNomeConvenio.Hide();
            lblNumConvenio.Hide();
            txtNumConvenio.Hide();
            cmbTipoSanguineo.DataSource = Enum.GetValues(typeof(TpSang));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            TpSang tipoSanguineo;
            Enum.TryParse<TpSang>(cmbTipoSanguineo.Text, out tipoSanguineo);
            Sexo sexo;
            Enum.TryParse<Sexo>(ucPessoa1.cmbSexo.Text, out sexo);

            cadPacienteControl = new CadPacienteController();

            Paciente paciente = new Paciente();
            Convenio convenio;

            paciente.cpf = decimal.Parse(ucPessoa1.mkdCPF.Text);
            paciente.nome = ucPessoa1.txtNome.Text;
            paciente.apelido = ucPessoa1.txtApelido.Text;
            paciente.sexo = (int)sexo;
            paciente.dataNascimento = (DateTime.Parse(ucPessoa1.dtmDataNascimento.Text));
            paciente.email = ucPessoa1.txtEmail.Text;
            paciente.telefone = ucPessoa1.mkdTelefone.Text;
            paciente.celular = ucPessoa1.mkdCelular.Text;
            paciente.rua = ucEndereco1.txtRua.Text;
            paciente.numero = decimal.Parse(ucEndereco1.txtNumero.Text);
            paciente.bairro = ucEndereco1.txtBairro.Text;
            paciente.cidade = ucEndereco1.txtCidade.Text;
            paciente.estado = ucEndereco1.cmbEstado.Text;
            

            paciente.objetivo = txtObjetivo.Text;
            paciente.esportesPraticados = txtEspPrat.Text;

            if (chbConvenio.Checked)
            {
                convenio = new Convenio();
                convenio.nome = txtNomeConvenio.Text;
                convenio.numPlano = decimal.Parse(txtNumConvenio.Text);
                paciente.Convenio = convenio;
            }
            else
            {
                paciente.Convenio = null;
            }

            cadPacienteControl.cadastrarPaciente(paciente);
        }

        private void chbConvenio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbConvenio.Checked)
            {
                lblConvenio.Show();
                txtNomeConvenio.Show();
                lblNumConvenio.Show();
                txtNumConvenio.Show();

                txtNomeConvenio.Enabled = true;
                txtNumConvenio.Enabled = true;
            }
            else
            {
                lblConvenio.Hide();
                txtNomeConvenio.Hide();
                lblNumConvenio.Hide();
                txtNumConvenio.Hide();

                txtNomeConvenio.Enabled = false;
                txtNumConvenio.Enabled = false;
            }
        }

        private void txtNomeConvenio_Leave(object sender, EventArgs e)
        {
            if (txtNomeConvenio.Text == "")
            {
                txtNomeConvenio.BackColor = Color.Red;
                txtNomeConvenio.Focus();
            }
            else
            {
                txtNomeConvenio.BackColor = Color.LightGreen;
            }
        }

        private void txtNumConvenio_Leave(object sender, EventArgs e)
        {
            if (txtNumConvenio.Text == "")
            {
                txtNumConvenio.BackColor = Color.Red;
                txtNumConvenio.Focus();
            }
            else
            {
                txtNumConvenio.BackColor = Color.LightGreen;
            }
        }

        private void cmbTipoSanguineo_Leave(object sender, EventArgs e)
        {
            if ((cmbTipoSanguineo.Text == "") || (cmbTipoSanguineo.Text == "Selecione.."))
            {
                cmbTipoSanguineo.BackColor = Color.Red;
                cmbTipoSanguineo.Focus();
            }
            else
            {
                cmbTipoSanguineo.BackColor = Color.LightGreen;
            }
        }

    }
}
