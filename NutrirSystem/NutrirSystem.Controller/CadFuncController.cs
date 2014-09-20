using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Controller
{
    public class CadFuncController
    {
        FuncionarioModel funModel;

        public CadFuncController()
        {
            funModel = new FuncionarioModel();
        }

        public bool VerificarDupCPF(decimal cpf)
        {
            return(funModel.VerificarDupCPF(cpf));
        }

        public string Gravar(decimal cpf, string nome, string rua, decimal numero, string bairro, string cidade, string estado,
            int sexo, string email, DateTime datan, string telefone,
            string celular, string apelido, string usuario, string senha,
            int pe, decimal crm = 0)
        {
            return(funModel.Gravar(cpf, nome, rua, numero, bairro, cidade, estado, sexo, email, datan, telefone, celular, apelido, usuario, senha, pe, crm));
        }

        public Data.Funcionario buscarFuncionario(decimal cpf)
        {
            return funModel.buscarFuncionario(cpf);
        }

        public void excluirFuncionario(decimal cpf)
        {
            funModel.excluirFuncionario(cpf);
        }

        public void alterarFuncionario(decimal cpf, string nome, string rua, decimal numero, string bairro, string cidade, string estado,
            int sexo, string email, DateTime datan, string telefone,
            string celular, string apelido, string usuario, string senha,
            int pe, Data.Funcionario funcalterado, decimal crm = 0)
        {
            funcalterado.cpf = cpf;
            funcalterado.nome = nome;
            funcalterado.rua = rua;
            funcalterado.numero = numero;
            funcalterado.bairro = bairro;
            funcalterado.cidade = cidade;
            funcalterado.estado = estado;
            funcalterado.sexo = sexo;
            funcalterado.email = email;
            funcalterado.dataNascimento = datan;
            funcalterado.telefone = telefone;
            funcalterado.celular = celular;
            funcalterado.apelido = apelido;
            funcalterado.usuario = usuario;
            funcalterado.password = senha;
            funcalterado.perfil = pe;

            if (pe == 2)
            {
                funcalterado.CRN = crm;
            }

            funModel.alterarFuncionario(funcalterado);
        }

    }
}
