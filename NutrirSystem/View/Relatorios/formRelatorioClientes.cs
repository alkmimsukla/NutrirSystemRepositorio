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
        RelatorioController Controller_RelCli;
        CadFuncController Controller_Func;
        ConvenioController Conv_Controller;

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
            
            Controller_RelCli.EmitirReCli(1235456, 1, "10-25", 2255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sexo sexo;
            Enum.TryParse<Sexo>(cbSexo.SelectedText, out sexo);

            List<Paciente> list = 
            Controller_RelCli.EmitirReCli(((Funcionario)cbNutri.SelectedItem).cpf, (int)sexo, ((Convenio)cbConvenio.SelectedItem).numPlano);

            var listGrad = new BindingList<Paciente>(list);
            var source = new BindingSource(listGrad, null);

            gradRel.DataSource = source;
        }
    }
}
