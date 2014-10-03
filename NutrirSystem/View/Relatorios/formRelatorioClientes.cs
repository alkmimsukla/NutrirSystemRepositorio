using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutrirSystem.Controller;
using NutrirSystem.Data;

namespace View.Relatorios
{
    public partial class formRelatorioClientes : Form
    {
        private RelatorioController Controller_RelCli;
        private CadFuncController Controller_Func;
        private ConvenioController Conv_Controller;
        private bool[] filtros;

        public formRelatorioClientes()
        {
            InitializeComponent();

            Controller_RelCli  = new RelatorioController();
            Controller_Func = new CadFuncController();
            Conv_Controller = new ConvenioController();

            cbSexo.DataSource = Enum.GetValues(typeof(Sexo));

            //Carrega Combox de Nutricionistas
            cbNutri.DataSource = Controller_RelCli.RetornaListaNutricionista();
            cbNutri.DisplayMember = "nome";
            cbNutri.ValueMember = "nome";

            //Carrega Combox de Convenios
            cbConvenio.DataSource = Conv_Controller.RetonarListConvenios();
            cbConvenio.DisplayMember = "nome";
            cbConvenio.ValueMember = "nome";

            filtros = new bool[4] {true, true, true, true };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Sexo sexo;
            Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sexo);

            List<Paciente> list = Controller_RelCli.EmitirReCli(
                filtros,
                ((Funcionario)cbNutri.SelectedItem).cpf,
                (int)sexo,
                fxetariaMin.Value.ToString() + "-" + fxetariaMin.Value.ToString(),
                ((Convenio)cbConvenio.SelectedItem).numPlano);

            var listGrad = new BindingList<Paciente>(list);
            var source = new BindingSource(listGrad, null);

            gradRel.DataSource = source;

        }

        private void chbNutri_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox chb = (CheckBox)sender;

            if (chb.Name == "chbNutri")
            {
                if (chb.Checked)
                {
                    cbNutri.Hide();
                    filtros[0] = false;
                }
                else
                {
                    cbNutri.Show();
                    filtros[0] = true;
                }
                 
            }
            else if (chb.Name == "chbGen")
            {
                if (chb.Checked)
                {
                    cbSexo.Hide();
                    filtros[1] = false;
                }
                else
                {
                    cbSexo.Show();
                    filtros[1] = true;
                }
            }
            else if (chb.Name == "chbIdade")
            {
                if (chb.Checked)
                {
                    fxetariaMax.Hide();
                    fxetariaMin.Hide();
                    filtros[2] = false;
                }
                else
                {
                    fxetariaMax.Show();
                    fxetariaMin.Show();
                    filtros[2] = true;
                }
            }
            else if (chb.Name == "chbConv")
            {
                if (chb.Checked)
                {
                    cbConvenio.Hide();
                    filtros[3] = false;
                }
                else
                {
                    cbConvenio.Show();
                    filtros[3] = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
