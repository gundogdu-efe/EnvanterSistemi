﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvanterSistemi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EnvanterSistemiEntities : DbContext
    {
        public EnvanterSistemiEntities()
            : base("name=EnvanterSistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Envanter> Envanters { get; set; }
        public virtual DbSet<EnvanterDetay> EnvanterDetays { get; set; }
        public virtual DbSet<EnvanterDosya> EnvanterDosyas { get; set; }
        public virtual DbSet<EnvanterSKDisi> EnvanterSKDisis { get; set; }
        public virtual DbSet<EnvanterTür> EnvanterTür { get; set; }
        public virtual DbSet<Konum> Konums { get; set; }
        public virtual DbSet<LogKayit> LogKayits { get; set; }
        public virtual DbSet<MarkaModel> MarkaModels { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<ServisKayit> ServisKayits { get; set; }
        public virtual DbSet<SonSiraNo> SonSiraNoes { get; set; }
        public virtual DbSet<TurSiraNo> TurSiraNoes { get; set; }
        public virtual DbSet<VarlikKategori> VarlikKategoris { get; set; }
        public virtual DbSet<Zimmet> Zimmets { get; set; }
        public virtual DbSet<Birimler> Birimlers { get; set; }
    }
}
