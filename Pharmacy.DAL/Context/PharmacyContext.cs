using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharmacy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Context
{
    public class PharmacyContext : IdentityDbContext, IPharmacyContext
    {
      
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
        {

        }
        public virtual DbSet<DrugStore> drugStores { get; set; }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<OrderMedicine> orderMedicines { get; set; }
        public virtual DbSet<Medicine> medicines { get; set; }
        public virtual DbSet<Delivery> deliveries { get; set; }
        public virtual DbSet<PharmacyMedicine> pharmacyMedicines { get; set; }
    }
}
