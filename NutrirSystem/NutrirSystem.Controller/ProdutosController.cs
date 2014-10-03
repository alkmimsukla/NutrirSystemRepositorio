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
    }
}
