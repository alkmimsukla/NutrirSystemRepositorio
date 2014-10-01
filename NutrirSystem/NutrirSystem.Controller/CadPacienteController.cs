using NutrirSystem.Data;
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

        public bool cpfExistente(decimal cpf)
        {
            return (modelPaciente.cpfExistente(cpf));
        }


        public Data.Paciente buscarPaciente(decimal cpf)
        {
            return (modelPaciente.buscarPaciente(cpf));
        }

        public void alterarPaciente(decimal cpf, string nome, string rua, decimal numero, string bairro, string cidade, string estado,
            int sexo, string email, DateTime datan, string telefone,
            string celular, string apelido, string obj, int tpsg, string esporte, Data.Paciente pacalterado)
        {
            pacalterado.cpf = cpf;
            pacalterado.nome = nome;
            pacalterado.rua = rua;
            pacalterado.numero = numero;
            pacalterado.bairro = bairro;
            pacalterado.cidade = cidade;
            pacalterado.estado = estado;
            pacalterado.sexo = sexo;
            pacalterado.email = email;
            pacalterado.dataNascimento = datan;
            pacalterado.telefone = telefone;
            pacalterado.celular = celular;
            pacalterado.apelido = apelido;
            pacalterado.objetivo = obj;
            pacalterado.tipoSanguineo = tpsg;
            pacalterado.esportesPraticados = esporte;

            modelPaciente.alterarPaciente(pacalterado);

        }

        public void cadastrarPaciente(Paciente paciente)
        {
            modelPaciente.cadastrarPessoa(paciente);
        }

        public void excluirPaciente(decimal cpf)
        {
            modelPaciente.excluirPaciente(cpf);
        }
    }
}
