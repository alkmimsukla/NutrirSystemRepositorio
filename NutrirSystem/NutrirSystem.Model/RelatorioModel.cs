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

        public List<Paciente> EmitirReCli(bool[]filtros, Decimal cpf, int sexo, string faixaetaria, Decimal convenio)
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            List<Consulta> listaConsultas = new List<Consulta>();

            listaPacientes = banco.Paciente.ToList();
            listaConsultas = banco.Consulta.ToList();

            if(filtros[0] == true)
            {
                listaConsultas = (from C in listaConsultas where C.Funcionario_cpf == cpf select C).ToList();

                List<Paciente> listao = new List<Paciente>();

                foreach (Consulta item in listaConsultas)
                {
                    listaPacientes = (from P in listaPacientes where P.cpf == item.Paciente_cpf select P).ToList();
                }

            }
            if (filtros[1] == true)
            {
                listaPacientes = (from P in listaPacientes where P.sexo == sexo select P).ToList();
            }
            if (filtros[2] == true)
            {
                string[] splitfx = faixaetaria.Split('-');
                int idademin = int.Parse(splitfx[0]);
                int idademax = int.Parse(splitfx[1]);

        //                public int idade()
        //{
        //    return (DateTime.Now.Subtract(this.dataNascimento).Days/365);
        //}

                listaPacientes = (from P in listaPacientes where P.idade()>=idademin && P.idade() <= idademax select P).ToList();
            }
            if (filtros[3] == true)
            {
                listaPacientes = (from P in listaPacientes where P.Convenio_numPlano == convenio select P).ToList();
            }


            return (listaPacientes);
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
