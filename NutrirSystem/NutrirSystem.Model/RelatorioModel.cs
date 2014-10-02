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


        public List<Funcionario> RetornarListaNutricionista()
        {
            return (banco.Funcionario.Where(item => item.perfil==2).ToList());
        }

        public List<Paciente> RetornarListaCliente()
        {
            return (banco.Paciente.ToList());
        }

        public List<Paciente> EmitirReCli(decimal cpf, int sexo, decimal convenio)
        {
            IEnumerable<Consulta> filtroCon = from consulta in this.banco.Consulta where consulta.Funcionario_cpf == cpf select consulta;

            List<Paciente> listaPacientesSel = new List<Paciente>();
            List<Paciente> listaTodosPacientes = this.RetornarListaCliente();

            foreach (Consulta item in filtroCon)
            {
                Paciente pa = listaTodosPacientes.First(itemP => itemP.Convenio_numPlano == convenio);
                if(pa !=null)
                    listaPacientesSel.Add(pa);
            }

            return(listaPacientesSel);
        }
    }
}
