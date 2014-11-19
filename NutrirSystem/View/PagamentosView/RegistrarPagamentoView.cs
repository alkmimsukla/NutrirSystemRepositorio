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
        

        public RegistrarPagamentoView()
        {
            InitializeComponent();
        }

        private void RegistrarPagamentoView_Load(object sender, EventArgs e)
        {
            CadPacienteController pacienteController = new CadPacienteController();
            List<Paciente> listaPacientes = pacienteController.buscarTodosPacientes();

            List<KeyValuePair<string, decimal>> dic = new List<KeyValuePair<string,decimal>>();

            foreach (Paciente p in listaPacientes)
            {
                dic.Add(new KeyValuePair<string,decimal> (p.nome, p.cpf));
            }

            comboboxPaciente.DataSource = dic;
            comboboxPaciente.DisplayMember = "SELECIONE O PACIENTE";
            comboboxPaciente.ValueMember = null;
            
            groupBoxCartao.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboboxPaciente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            if (comboboxPaciente.SelectedValue != null)
            {
                ConsultaController consultaController = new ConsultaController();
                List<Consulta> consultas = consultaController.listarConsultasPaciente((decimal)comboboxPaciente.SelectedValue);

                List<KeyValuePair<DateTime, decimal>> dic = new List<KeyValuePair<DateTime, decimal>>();

                foreach (Consulta c in consultas)
                {
                    dic.Add(new KeyValuePair<DateTime, decimal>(c.DataHora, c.idConsulta));
                }

                comboboxConsulta.DataSource = dic;
                comboboxConsulta.DisplayMember = "Selecione uma consulta";
                comboboxConsulta.ValueMember = null;
                
            }
        }
    }
}
