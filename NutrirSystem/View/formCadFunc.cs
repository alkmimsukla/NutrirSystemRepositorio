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

namespace View
{

    public partial class formCadFunc : Form
    {

        //Lista de campos obrigatorios
        List<TextBoxBase> Campos = new List<TextBoxBase>();
        //Lista de Combobox Obrigatorio
        List<ComboBox> ComboB = new List<ComboBox>();

        CadFuncController controller = new CadFuncController();

        public formCadFunc()
        {
            InitializeComponent();

            cbBoxPerfil.DataSource = Enum.GetValues(typeof(Perfil));
            cbBoxSexo.DataSource = Enum.GetValues(typeof(Sexo));
            popularListaCamposOb();

        }

        /// <summary>
        /// Popula a lista de campos obrigatorios.
        /// </summary>
        private void popularListaCamposOb()
        {
            Campos.Add(boxCPF);
            Campos.Add(boxLogin);
            Campos.Add(boxRua);
            Campos.Add(mkBoxTel);
            Campos.Add(boxSenha);
            Campos.Add(boxSalario);
            ComboB.Add(cbBoxSexo);
            ComboB.Add(cbBoxPerfil);
        }

        /// <summary>
        /// Verifica se campos obrigatórios estão preenchidos, colore de vermelho os que não estão preenchidos
        /// </summary>
        /// <returns>Retorna True se todos os campos estiverem preenhcidos e False caso uma não esteje preenchido</returns>
        private bool VerificarCampos()
        {
            bool permissao = true;
            foreach (TextBoxBase x in Campos)
            {
                if (String.IsNullOrEmpty(x.Text))
                {
                    x.BackColor = Color.Red;
                    permissao = false;
                }
            }
            foreach (ComboBox x in ComboB)
            {
                if (String.IsNullOrEmpty(x.Text))
                {
                    x.BackColor = Color.Red;
                    permissao = false;
                }
            }

            return(permissao);

        }

        /// <summary>
        /// Exibe ou não o campo CRN de acordo com o tipo de perfil.
        /// </summary>
        private void cbPerfilChange(object sender, EventArgs e)
        {
            Perfil per;
            Enum.TryParse<Perfil>(cbBoxPerfil.SelectedValue.ToString(), out per);

            if (per != Perfil.Nutricionista)
            {
                masktbCRM.Visible = false;
                label6CRM.Visible = false;
                Campos.Remove(masktbCRM);
                masktbCRM.Text = "0";
            }
            else
            {
                masktbCRM.Visible = true;
                label6CRM.Visible = true;
                masktbCRM.Text = String.Empty;
                Campos.Add(masktbCRM);
            }
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos() == false)
            {
                MessageBox.Show("Campos em vermelho devem ser preenchidos.");
            }
            else
            {
                DateTime data = calendarDN.SelectionEnd;

                Perfil per;
                Sexo sex;

                Enum.TryParse<Perfil>(cbBoxPerfil.SelectedValue.ToString(), out per);
                Enum.TryParse<Sexo>(cbBoxSexo.SelectedValue.ToString(), out sex);

                string Mensagem = controller.Gravar(Decimal.Parse(boxCPF.Text), boxNome.Text, boxRua.Text, Decimal.Parse(boxNum.Text), boxBairro.Text,
                    "Belo Horizonte", "MG",Convert.ToInt32(sex), boxEmail.Text, data, mkBoxTel.Text, mkBoxCel.Text, boxApelido.Text,
                    boxLogin.Text, boxSenha.Text, Convert.ToInt32(per),Decimal.Parse(masktbCRM.Text));

                MessageBox.Show(Mensagem);
                this.Close();

            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            ((TextBoxBase)sender).BackColor = Color.White;
        }





    }
}
