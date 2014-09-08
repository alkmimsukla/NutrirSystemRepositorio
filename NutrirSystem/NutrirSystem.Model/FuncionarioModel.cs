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
        public FuncionarioModel()
            : base() { }

        public bool validarLogin(string user, string senha)
        {
            return banco.Funcionario.Any(item => item.usuario == user.Trim() && item.password.Trim() == senha);
        }

        public Perfil recuperarPerfil(string user)
        {
            return (Perfil)banco.Funcionario.Where(item => item.usuario == user.Trim()).SingleOrDefault().perfil;
        }
    }
}
