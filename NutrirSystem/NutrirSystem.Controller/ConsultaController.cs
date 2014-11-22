using NutrirSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutrirSystem.Controller
{
    public class ConsultaController
    {
        ConsultaModel model;
        PagamentoModel modelPagamento;

        public ConsultaController() 
        {
            model = new ConsultaModel();
        }
        public List<NutrirSystem.Data.Consulta> listarConsultasPaciente(decimal cpf)
        {
            return model.listarConsultasPaciente(cpf);
        }

        public void salvarPagamento(Data.Pagamento pagamento)
        {
            model.salvarPagamento(pagamento);
        }

        public Data.Consulta buscarConsulta(decimal idConsulta)
        {
            return model.buscarConsulta(idConsulta);
        }
    }
}
