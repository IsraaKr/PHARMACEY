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
        public PHANACEY_DBEntities(string constr)
            : base(constr)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_Med_Category> T_Med_Category { get; set; }
        public virtual DbSet<T_Med_Shape> T_Med_Shape { get; set; }
        public virtual DbSet<T_Med_Unites> T_Med_Unites { get; set; }
        public virtual DbSet<T_Medician> T_Medician { get; set; }
        public virtual DbSet<T_Medicin_Move> T_Medicin_Move { get; set; }
        public virtual DbSet<T_OPeration_Damage> T_OPeration_Damage { get; set; }
        public virtual DbSet<T_OPeration_IN> T_OPeration_IN { get; set; }
        public virtual DbSet<T_OPeration_IN_Item> T_OPeration_IN_Item { get; set; }
        public virtual DbSet<T_OPeration_Out> T_OPeration_Out { get; set; }
        public virtual DbSet<T_OPeration_Out_Item> T_OPeration_Out_Item { get; set; }
        public virtual DbSet<T_OPeration_Type> T_OPeration_Type { get; set; }
        public virtual DbSet<T_Pers_Donars> T_Pers_Donars { get; set; }
        public virtual DbSet<T_Pers_Emploee> T_Pers_Emploee { get; set; }
        public virtual DbSet<T_Store_Placees> T_Store_Placees { get; set; }
        public virtual DbSet<T_Pers_Recivers> T_Pers_Recivers { get; set; }
    }
}
