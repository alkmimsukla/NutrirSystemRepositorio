using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutrirSystem.Data;

namespace NutrirSystem.Model
{
    public class PacienteModel : ModelBD
    {
        public PacienteModel()
            : base() { }


        public bool cpfExistente(decimal cpf)
        {
            return banco.Pessoa.Any(_item => _item.cpf == cpf);
        }

        public Paciente buscarPaciente(decimal cpf)
        {
            Pessoa pessoa = banco.Pessoa.Where(item => item.cpf == cpf).SingleOrDefault();
            if (pessoa is Paciente)
            {
                return ((Paciente)pessoa);
            }
            else
            {
                return null;
            }
        }

        public void alterarPaciente(Paciente paciente)
        {
            banco.Pessoa.Attach(paciente);
            banco.Entry(paciente).Property(u => u.nome).IsModified = true;
            banco.Entry(paciente).Property(u => u.numero).IsModified = true;
            banco.Entry(paciente).Property(u => u.apelido).IsModified = true;
            banco.Entry(paciente).Property(u => u.rua).IsModified = true;
            banco.Entry(paciente).Property(u => u.bairro).IsModified = true;
            banco.Entry(paciente).Property(u => u.email).IsModified = true;
            banco.Entry(paciente).Property(u => u.sexo).IsModified = true;
            banco.Entry(paciente).Property(u => u.estado).IsModified = true;
            banco.Entry(paciente).Property(u => u.telefone).IsModified = true;
            banco.Entry(paciente).Property(u => u.celular).IsModified = true;
            banco.Entry(paciente).Property(u => u.numero).IsModified = true;
            banco.Entry(paciente).Property(u => u.cidade).IsModified = true;
            banco.Entry(paciente).Property(u => u.dataNascimento).IsModified = true;
            banco.Entry(paciente).Property(u => u.objetivo).IsModified = true;
            banco.Entry(paciente).Property(u => u.tipoSanguineo).IsModified = true;
            banco.Entry(paciente).Property(u => u.esportesPraticados).IsModified = true;

            banco.SaveChanges();

        }

        public void cadastrarPessoa(Pessoa pessoa)
        {
            banco.Pessoa.Add(pessoa);

            banco.SaveChanges();
        }

        public void excluirPaciente(decimal cpf)
        {
            Pessoa removido = banco.Pessoa.Where(item => item.cpf == cpf).SingleOrDefault();
            banco.Pessoa.Remove(removido);
            banco.SaveChanges();
        }
    }
}
