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

        public List<Paciente> EmitirReCli(bool[] filtros, Decimal cpf, int sexo, string faixaetaria, Decimal convenio)
        {

            return (this.relatModel.EmitirReCli(filtros, cpf, sexo, faixaetaria, convenio));
        }

        public List<Funcionario> RetornaListaNutricionista()
        { 
            return (this.relatModel.RetornarListaNutricionista());
        }


        public List<Paciente> RetornarListaClientes()
        {
            return(this.relatModel.RetornarListaCliente());
        }
    }
}
