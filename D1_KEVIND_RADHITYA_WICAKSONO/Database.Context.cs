﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EsemNetEntities : DbContext
    {
        public EsemNetEntities()
            : base("name=EsemNetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Jeni> Jenis { get; set; }
        public virtual DbSet<KodePotonganHarga> KodePotonganHargas { get; set; }
        public virtual DbSet<Komputer> Komputers { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<Pengguna> Penggunas { get; set; }
        public virtual DbSet<Transaksi> Transaksis { get; set; }
    }
}
