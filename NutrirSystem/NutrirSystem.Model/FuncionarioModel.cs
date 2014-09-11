using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Model
{
    public class FuncionarioModel : ModelBD
    {
        public FuncionarioModel()
            : base() { }

        public bool validarLogin(string user, string senha)
        {
            return banco.Funcionario.Any(item => item.usuario == user.Trim() && item.password.Trim() == senha);
        }

        public Perfil recuperarPerfil(string user)
        {
            return (Perfil)banco.Funcionario.Where(item => item.usuario == user.Trim()).SingleOrDefault().perfil;
        }

        public bool VerificarDupCPF(decimal cpf)
        {
            return (banco.Funcionario.Any(item => item.cpf == cpf));
        }

        private string GravarBanco(Funcionario obj)
        {
            return ("Funcioanario " + banco.Funcionario.Add(obj).nome + " inserida com sucesso!");
        }

        public string Gravar(decimal cpf, string nome, string rua, decimal numero, string bairro, string cidade, string estado,
            int sexo, string email, DateTime datan, string telefone,
            string celular, string apelido, string usuario, string senha,
            int pe, decimal crm = 0)
        {

            Funcionario func = new Funcionario();

            if (VerificarDupCPF(cpf))
            {
                func.cpf = cpf;
                func.nome = nome;
                func.rua = rua;
                func.numero = numero;
                func.bairro = bairro;
                func.cidade = cidade;
                func.estado = estado;
                func.sexo = sexo;
                func.email = email;
                func.dataNascimento = datan;
                func.telefone = telefone;
                func.celular = celular;
                func.apelido = apelido;
                func.usuario = usuario;
                func.password = senha;
                func.perfil = pe;
                if (pe == 2)
                {
                    ((Nutricionista)func).crm = crm;
                }
            }
            else
            {
                return ("CPF ja existe! Cadastre um outro");
            }

            return (this.GravarBanco(func));

        }

        public Funcionario buscarFuncionario(decimal cpf)
        {
            return banco.Funcionario.Where(item => item.cpf == cpf).SingleOrDefault();
        }

        public void excluirFuncionario(decimal cpf)
        {
            Funcionario removido = banco.Funcionario.Where(item => item.cpf == cpf).SingleOrDefault();
            banco.Funcionario.Remove(removido);
            banco.SaveChanges();
        }
    }
}
