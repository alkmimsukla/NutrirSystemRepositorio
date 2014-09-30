using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrirSystem.Data;

namespace NutrirSystem.Model
{
    public class RelatorioModel:ModelBD
    {
        public RelatorioModel() : base() { }

        public IEnumerable<Consulta> EmitirReCli(Decimal cpf, int sexo, string faixaetaria, Decimal convenio)
        { 
            //IEnumerable<Pessoa> filtro = from cliente in this.banco.Pessoa where cliente.cpf == cpf

            IEnumerable<Consulta> filtroCon = from consulta in this.banco.Consulta where consulta.Funcionario_cpf == cpf select consulta;

            return (filtroCon);
        }


    }
}
