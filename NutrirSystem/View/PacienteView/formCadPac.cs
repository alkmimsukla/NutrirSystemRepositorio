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
        ConvenioController convController;

        public formCadPac()
        {
            InitializeComponent();

            convController = new ConvenioController();

            lblConvenio.Hide();
            cbConvenio.Hide();
            cmbTipoSanguineo.DataSource = Enum.GetValues(typeof(TpSang));
            
            //Carrega Combox Convenio do banco.
            cbConvenio.DataSource = convController.RetonarListConvenios();
            cbConvenio.DisplayMember = "nome";
            cbConvenio.ValueMember = "nome";
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
                paciente.Convenio_numPlano = ((Convenio)cbConvenio.SelectedItem).numPlano;
            }
            else
            {
                paciente.Convenio_numPlano = default(decimal?);
            }

            cadPacienteControl.cadastrarPaciente(paciente);
        }

        private void chbConvenio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbConvenio.Checked)
            {
                lblConvenio.Show();
                cbConvenio.Show();

                cbConvenio.Enabled = true;
            }
            else
            {
                lblConvenio.Hide();
                cbConvenio.Hide();

                cbConvenio.Enabled = false;
            }
        }

        private void txtNomeConvenio_Leave(object sender, EventArgs e)
        {
            if (cbConvenio.Text == "")
            {
                cbConvenio.BackColor = Color.Red;
                cbConvenio.Focus();
            }
            else
            {
                cbConvenio.BackColor = Color.LightGreen;
            }
        }

        private void txtNumConvenio_Leave(object sender, EventArgs e)
        {
            if (cbConvenio.SelectedItem == null)
            {
                cbConvenio.BackColor = Color.Red;
                cbConvenio.Focus();
            }
            else
            {
                cbConvenio.BackColor = Color.LightGreen;
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
