﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JusticeEntities : DbContext
    {
        public JusticeEntities()
            : base("name=JusticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Product> Products { get; set; }
        public DbSet<tblCategory> tblCategories { get; set; }
        public DbSet<tblDocument> tblDocuments { get; set; }
        public DbSet<tblManufacture> tblManufactures { get; set; }
        public DbSet<tblOrder> tblOrders { get; set; }
        public DbSet<tblProperty> tblProperties { get; set; }
        public DbSet<tblSubCategory> tblSubCategories { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblPropertyValue> tblPropertyValues { get; set; }
    }
}
