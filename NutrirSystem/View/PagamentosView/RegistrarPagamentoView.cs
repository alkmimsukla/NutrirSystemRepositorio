using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutrirSystem.Data;
using NutrirSystem.Controller;


namespace View.PagamentosView
{
    public partial class RegistrarPagamentoView : Form
    {
        ConsultaController controller;

        public RegistrarPagamentoView()
        {
            InitializeComponent();
        }

        private void RegistrarPagamentoView_Load(object sender, EventArgs e)
        {
            CadPacienteController pacienteController = new CadPacienteController();
            List<Paciente> listaPacientes = pacienteController.buscarTodosPacientes();

            var dataSource = new List<Paciente>();
            foreach (Paciente p in listaPacientes)
            {
                dataSource.Add(new Paciente() { cpf = p.cpf, nome = p.nome });
            }

            comboboxPaciente.DataSource = dataSource;
            comboboxPaciente.DisplayMember = "nome";
            comboboxPaciente.ValueMember = "cpf";
            this.comboboxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;

            groupBoxCartao.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboboxPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboboxConsulta.DataSource = null;
            if (comboboxPaciente.SelectedValue != null)
            {
                ConsultaController consultaController = new ConsultaController();
                List<Consulta> consultas = consultaController.listarConsultasPaciente((decimal)comboboxPaciente.SelectedValue);

                var dataSource = new List<Consulta>();

                foreach (Consulta c in consultas)
                {
                    dataSource.Add(new Consulta() { DataHora = c.DataHora, idConsulta = c.idConsulta });
                }

                comboboxConsulta.DataSource = dataSource;
                comboboxConsulta.DisplayMember = "DataHora";
                comboboxConsulta.ValueMember = "idConsulta";
                
                this.comboboxConsulta.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }

        private void radioButtonCartao_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCartao.Show();
        }

        private void radioButtonDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCartao.Hide();
        }

        private void textBoxNumParcelas_TextChanged(object sender, EventArgs e)
        {
            if (textBoxvalorConsulta.Text != null && textBoxNumParcelas.Text != null )
            {
                double valorParcela = double.Parse(textBoxvalorConsulta.Text) / double.Parse(textBoxNumParcelas.Text);
                labelValorParcelaExibicao.Text = valorParcela.ToString();
            }

            else
            {
                labelValorParcelaExibicao.Text = "";
            }
        }

        private void textBoxvalorConsulta_TextChanged(object sender, EventArgs e)
        {
            labelValorParcelaExibicao.Text = textBoxvalorConsulta.Text;
        }

        private Pagamento construirPagamento()
        {
            if (comboboxPaciente.SelectedValue != null && comboboxConsulta.SelectedValue != null
                && textBoxvalorConsulta.Text != null && (radioButtonCartao.Checked || radioButtonDinheiro.Checked))
            {
                Pagamento novo = new Pagamento();

                novo.Data = DateTime.Now;
                novo.Consulta = controller.buscarConsulta((decimal)comboboxConsulta.SelectedValue);
                novo.statusPagamento = 1; //pago;
                novo.valor = decimal.Parse(textBoxvalorConsulta.Text);
                novo.formaPagamento = 0; //dinheiro.

                if (radioButtonCartao.Checked)
                {
                    novo.formaPagamento = 1; //cartão
                    if (textBoxBandeira.Text != null &&
                        textBoxNomeTitular.Text != null &&
                        textBoxNumParcelas.Text != null)
                    {
                        novo.CartaoCredito = new CartaoCredito();
                        novo.CartaoCredito.Bandeira = int.Parse(textBoxBandeira.Text);
                        novo.CartaoCredito.numParc = decimal.Parse(textBoxNumParcelas.Text);
                        novo.CartaoCredito.Titular = textBoxNomeTitular.Text;
                        MessageBox.Show("Pagamento efetuado!");
                        return novo;
                    }

                    else
                    {
                        MessageBox.Show("Preencha os dados do cartão para registrar o pagamento!");
                        return null;
                    }
                }

                MessageBox.Show("Pagamento efetuado!");
                return novo;
                
            }

            else
            {
                MessageBox.Show("Preencha os dados para registrar o pagamento!");
                return null;
            }
        }

        private void btRegistrarPgt_Click(object sender, EventArgs e)
        {
            Pagamento p = construirPagamento();
            if(p!= null)  controller.salvarPagamento(p);
        }

        private void textBoxBandeira_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
