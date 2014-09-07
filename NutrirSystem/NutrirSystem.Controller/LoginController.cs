using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Controller
{
    public class LoginController
    {
        //modelFuncionario
        public LoginController() 
        {

        }

        public bool validarLoginSenha(string user, string senha)
        {
            return false;
        }

        public Perfil recuperarPerfil(string user)
        {
            return Perfil.Secretaria;
        }
    }
}
