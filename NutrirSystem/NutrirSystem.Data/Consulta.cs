//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NutrirSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consulta
    {
        public decimal idConsulta { get; set; }
        public Nullable<int> statusConsulta { get; set; }
        public System.DateTime data { get; set; }
        public int hora { get; set; }
        public Nullable<int> tipoConsulta { get; set; }
        public decimal Nutricionista { get; set; }
        public decimal cpfPaciente { get; set; }
        public Nullable<decimal> Pagamento { get; set; }
        public decimal MedidasCorporais { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual MedidasCorporais MedidasCorporais1 { get; set; }
        public virtual Nutricionista Nutricionista1 { get; set; }
        public virtual Pagamento Pagamento1 { get; set; }
    }
}
