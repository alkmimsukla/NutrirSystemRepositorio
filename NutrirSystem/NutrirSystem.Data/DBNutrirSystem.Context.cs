﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBNutrirSystemEntities : DbContext
    {
        public DBNutrirSystemEntities()
            : base("name=DBNutrirSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Dieta> Dieta { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Habitos> Habitos { get; set; }
        public DbSet<MedidasCorporais> MedidasCorporais { get; set; }
        public DbSet<Nutricionista> Nutricionista { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<ProdutosClinica> ProdutosClinica { get; set; }
    }
}