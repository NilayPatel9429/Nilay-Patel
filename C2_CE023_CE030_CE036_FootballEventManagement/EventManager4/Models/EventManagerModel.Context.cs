﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventManager4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventManagementEntitiesEntities : DbContext
    {
        public EventManagementEntitiesEntities()
            : base("name=EventManagementEntitiesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
