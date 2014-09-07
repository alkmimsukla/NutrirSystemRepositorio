using NutrirSystem.Data;
using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Controller
{
    public class LoginController
    {
        private FuncionarioModel modelFuncionario;

        public LoginController() 
        {
            modelFuncionario = new FuncionarioModel();
        }

        public bool validarLoginSenha(string user, string senha)
        {
            return modelFuncionario.validarLogin(user, senha);
        }

        public Perfil recuperarPerfil(string user)
        {
            return modelFuncionario.recuperarPerfil(user);
        }
    }
}
