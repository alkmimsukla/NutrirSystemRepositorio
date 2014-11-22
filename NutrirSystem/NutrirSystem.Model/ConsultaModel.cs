using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NutrirSystem.Data;

namespace NutrirSystem.Model
{
    public class ConsultaModel : ModelBD
    {
        public ConsultaModel() : base() { }

        public List<NutrirSystem.Data.Consulta> listarConsultasPaciente(decimal cpf)
        {
            return banco.Consulta.Where(item => item.Paciente_cpf == cpf).ToList();
        }

        public void salvarPagamento(Pagamento pagamento)
        {
            banco.Pagamento.Add(pagamento);
            banco.SaveChanges();
        }

        public Consulta buscarConsulta(decimal idConsulta)
        {
            return banco.Consulta.Where(item => item.idConsulta == idConsulta).SingleOrDefault();
        }
    }
}
