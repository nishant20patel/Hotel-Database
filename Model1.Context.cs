﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelDatabaseEntities : DbContext
    {
        public HotelDatabaseEntities()
            : base("name=HotelDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<Guest_Info> Guest_Info { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Room_Prices> Room_Prices { get; set; }
        public virtual DbSet<Complete_Booking> Complete_Bookings { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
    }
}
