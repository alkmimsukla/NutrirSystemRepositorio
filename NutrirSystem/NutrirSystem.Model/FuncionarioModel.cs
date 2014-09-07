using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Model
{
    public class FuncionarioModel : ModelBD
    {
        public bool validarLogin(string user, string senha)
        {
            return false;
            // executar consulta para validação de login
        }

        public Perfil recuperarPerfil(string user)
        {
            return Perfil.Secretaria;
            // executar consulta para recuperar Perfil.
        }
    }
}
