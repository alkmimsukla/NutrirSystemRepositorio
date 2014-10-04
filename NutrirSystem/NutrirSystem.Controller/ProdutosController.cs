using NutrirSystem.Data;
using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Controller
{
    public class ProdutosController
    {
        private ProdutosModel modelProdutos = new ProdutosModel();

        public bool produtoExiste(string nomeProd)
        {
            return (modelProdutos.produtoExiste(nomeProd));
        }

        public void inserirProduto(ProdutosClinica prod)
        {
            modelProdutos.insereProduto(prod);
        }

        public ProdutosClinica pesquisarProduto(string nome)
        {
            return modelProdutos.pesquisarProduto(nome);
        }

        public void excluirProduto(string nome)
        {
            modelProdutos.excluirProduto(nome);
        }

        public void alterarProduto(string nomeProduto, string sodio, string carboidratos, string gordura, string fibra, ProdutosClinica prod)
        {
            prod.nome = nomeProduto;
            prod.sodio = sodio;
            prod.gordura = gordura;
            prod.fibra = fibra;
            prod.carboidratos = carboidratos;

            modelProdutos.alteraProduto(prod);
        }
    }
}
