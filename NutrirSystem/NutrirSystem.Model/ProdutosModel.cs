using NutrirSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutrirSystem.Model
{
    public class ProdutosModel : ModelBD
    {
        public ProdutosModel()
            : base()
        { }


        public bool produtoExiste(string nomeProd)
        {
            return banco.ProdutosClinica.Any(_item => _item.nome == nomeProd);
        }

        public void insereProduto(ProdutosClinica produto)
        {
            produto.idProdutosClinica = proximoId();

            banco.ProdutosClinica.Add(produto);

            banco.SaveChanges();
        }

        public decimal proximoId()
        {
            return (banco.ProdutosClinica.Max(_item => _item.idProdutosClinica)) + 1;
        }
        
        public ProdutosClinica pesquisarProduto(string nome)
        {
            return banco.ProdutosClinica.Where(item => item.nome == nome).SingleOrDefault();
        }

        public void excluirProduto(string nome)
        {
            banco.ProdutosClinica.Remove(banco.ProdutosClinica.Where(item => item.nome == nome).SingleOrDefault());
            banco.SaveChanges();
        }

        public void alteraProduto(ProdutosClinica prod)
        {
            banco.ProdutosClinica.Attach(prod);
            banco.Entry(prod).Property(_item => _item.nome).IsModified = true;
            banco.Entry(prod).Property(_item => _item.fibra).IsModified = true;
            banco.Entry(prod).Property(_item => _item.carboidratos).IsModified = true;
            banco.Entry(prod).Property(_item => _item.sodio).IsModified = true;
            banco.Entry(prod).Property(_item => _item.gordura).IsModified = true;

            banco.SaveChanges();
        }
    }
}
