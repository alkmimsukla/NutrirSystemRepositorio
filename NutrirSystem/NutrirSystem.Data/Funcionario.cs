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
    
    public partial class Funcionario
    {
        public Funcionario()
        {
            this.Nutricionista = new HashSet<Nutricionista>();
        }
    
        public string usuario { get; set; }
        public string password { get; set; }
        public decimal salario { get; set; }
        public int perfil { get; set; }
        public decimal cpf { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Nutricionista> Nutricionista { get; set; }
    }
}