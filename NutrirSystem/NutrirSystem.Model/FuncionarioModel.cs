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

        private string GravarBanco(Pessoa obj)
        {
            string retorno = "Funcionario " + banco.Pessoa.Add(obj).nome + " inserida com sucesso!";
            int res = banco.SaveChanges();

            return (retorno);
        }

        public string Gravar(decimal _cpf, string _nome, string _rua, decimal _numero, string _bairro, string _cidade, string _estado,
            int _sexo, string _email, DateTime _datan, string _telefone,
            string _celular, string _apelido, string _usuario, string _senha,
            int _pe, decimal _crm = 0)
        {
            Funcionario funcObj;

            if (!VerificarDupCPF(_cpf))
            {
                    
                funcObj = new Funcionario()
                    {
                        cpf = _cpf,
                        nome = _nome,
                        rua = _rua,
                        numero = _numero,
                        bairro = _bairro,
                        cidade = _cidade,
                        estado = _estado,
                        sexo = _sexo,
                        email = _email,
                        dataNascimento = _datan,
                        telefone = _telefone,
                        celular = _celular,
                        apelido = _apelido,
                        usuario = _usuario,
                        password = _senha,
                        perfil = _pe,
                    };

                if(_pe == 2)
                {
                    funcObj.CRN = +_crm;
                }

                    return (GravarBanco(funcObj));
            }
            else
            {
                return ("CPF ja existe! Cadastre um outro");
            }
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

        public void alterarFuncionario(Funcionario funcionario)
        {
            banco.Pessoa.Attach(funcionario);
            banco.Entry(funcionario).Property(u => u.nome).IsModified = true;
            banco.Entry(funcionario).Property(u => u.numero).IsModified = true;
            banco.Entry(funcionario).Property(u => u.password).IsModified = true;
            banco.Entry(funcionario).Property(u => u.perfil).IsModified = true;
            banco.Entry(funcionario).Property(u => u.apelido).IsModified = true;
            banco.Entry(funcionario).Property(u => u.rua).IsModified = true;
            banco.Entry(funcionario).Property(u => u.bairro).IsModified = true;
            banco.Entry(funcionario).Property(u => u.email).IsModified = true;
            banco.Entry(funcionario).Property(u => u.sexo).IsModified = true;
            banco.Entry(funcionario).Property(u => u.estado).IsModified = true;
            banco.Entry(funcionario).Property(u => u.telefone).IsModified = true;
            banco.Entry(funcionario).Property(u => u.celular).IsModified = true;
            banco.Entry(funcionario).Property(u => u.salario).IsModified = true;
            banco.Entry(funcionario).Property(u => u.numero).IsModified = true;
            banco.Entry(funcionario).Property(u => u.cidade).IsModified = true;
            banco.Entry(funcionario).Property(u => u.usuario).IsModified = true;
            banco.Entry(funcionario).Property(u => u.dataNascimento).IsModified = true;

            if (funcionario.perfil == 2)
            {
                banco.Entry(funcionario).Property(u => u.CRN).IsModified = true;
            }

            banco.SaveChanges();

        }

    }
}
