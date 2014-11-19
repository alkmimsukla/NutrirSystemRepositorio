using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutrirSystem.Controller
{
    public class ConsultaController
    {
        ConsultaModel model;

        public ConsultaController() 
        {
            model = new ConsultaModel();
        }
        public List<NutrirSystem.Data.Consulta> listarConsultasPaciente(decimal cpf)
        {
            return model.listarConsultasPaciente(cpf);
        }
    }
}
