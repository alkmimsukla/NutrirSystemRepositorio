using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Model
{
    public class PacienteModel : ModelBD
    {
        public PacienteModel()
            : base() { }


        public bool cpfExistente(string cpf)
        {
            return banco.Pessoa.Any(_item => _item.cpf.ToString() == cpf);
        }   
    }
}
