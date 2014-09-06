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


    public partial class formCadFunc : Form
    {
        //só para teste do combobox Perfil
        List<string> Perfil = new List<string>();

        public formCadFunc()
        {
            InitializeComponent();

            //só para teste
            Perfil.Add("Secretária");
            Perfil.Add("Nutricionista");
            cbBoxPerfil.DataSource = Perfil;
            //--
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void formCadFunc_Load(object sender, EventArgs e)
        {

        }

        private void cbPerfilChange(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem == "Secretária")
            {
                masktbCRM.Visible = false;
                label6CRM.Visible = false;
            }
            else
            {
                masktbCRM.Visible = true;
                label6CRM.Visible = true;
            }
        }
    }
}
