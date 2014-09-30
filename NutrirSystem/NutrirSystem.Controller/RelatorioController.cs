using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrirSystem.Model;
using NutrirSystem.Data;

namespace NutrirSystem.Controller
{
    public class RelatorioController
    {
        RelatorioModel relatModel;

        public RelatorioController()
        { 
            this.relatModel = new RelatorioModel();
        }

        public IEnumerable<Consulta> EmitirReCli(Decimal cpf, int sexo, string faixaetaria, Decimal convenio)
        {
            return (this.relatModel.EmitirReCli(cpf, sexo, faixaetaria, convenio));
        }


    }
}
