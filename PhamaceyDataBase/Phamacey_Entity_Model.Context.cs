﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhamaceyDataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PHANACEY_DBEntities : DbContext
    {
        public PHANACEY_DBEntities()
            : base("name=PHANACEY_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<F_Med_Companeys> F_Med_Companeys { get; set; }
        public virtual DbSet<T_Med_Category> T_Med_Category { get; set; }
        public virtual DbSet<T_Med_Shape> T_Med_Shape { get; set; }
        public virtual DbSet<T_Med_Storage_Shape> T_Med_Storage_Shape { get; set; }
        public virtual DbSet<T_Medician> T_Medician { get; set; }
        public virtual DbSet<T_Pharmcey_Info> T_Pharmcey_Info { get; set; }
        public virtual DbSet<T_Store> T_Store { get; set; }
        public virtual DbSet<T_Store_Operation_Type> T_Store_Operation_Type { get; set; }
        public virtual DbSet<T_Store_Types> T_Store_Types { get; set; }
        public virtual DbSet<T_Store_Operation> T_Store_Operation { get; set; }
    }
}
