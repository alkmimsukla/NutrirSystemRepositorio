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
    public partial class LoginView : Form
    {
        private LoginController controllerLogin;

        public LoginView()
        {
            InitializeComponent();
            controllerLogin = new LoginController();
            campoSenha.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarCamposPreenchidos())
            {
                string user = campoUsuario.Text;
                string senha = campoSenha.Text;

                bool loginExistente = controllerLogin.validarLoginSenha(user, senha);
                if (loginExistente) 
                {
                    Perfil perfilUsuario = controllerLogin.recuperarPerfil(user);
                    exibirTelaCorrespondentePerfil(perfilUsuario);
                }
                else 
                {
                    exibirMsgLoginInexistente();
                }
            }

            else 
            {
                exibirMsgCamposNaoPreenchidos();
            }
        }

        private void exibirTelaCorrespondentePerfil(Perfil perfilUsuario)
        {
            this.Hide();

            if (perfilUsuario == Perfil.Secretaria)
            {
                new SecretariaView().Show();
            }

            if (perfilUsuario == Perfil.Gerente)
            {
                new GerenteView().Show();
            }
            
            if (perfilUsuario == Perfil.Nutricionista)
            {
                //exibirTelaInicialNutricionista
            }
        }

        private void exibirMsgLoginInexistente()
        {
            MessageBox.Show("Login inexistente! Tente novamente!");
        }

        private void exibirMsgCamposNaoPreenchidos()
        {
            MessageBox.Show("Preencha todos os campos!");
        }

        private bool validarCamposPreenchidos()
        {
            if (String.IsNullOrEmpty(campoUsuario.Text) || String.IsNullOrEmpty(campoSenha.Text))
            {
                return false;
            }
            else return true;
        }
    }
}
