using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Controller
{
    public class CadPacienteController
    {
        private PacienteModel modelPaciente;

        public CadPacienteController()
        {
            modelPaciente = new PacienteModel();
        }

        public bool cpfExistente(string cpf)
        {
            return (modelPaciente.cpfExistente(cpf));
        }

    }
}
