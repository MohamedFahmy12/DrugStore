using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Pharmacy.DAL.Entities;

namespace Pharmacy.DAL.Context
{
    public interface IPharmacyContext
    {
        DbSet<DrugStore> drugStores { get; set; }
        DbSet<Customer> customers { get; set; }
        DbSet<Order> orders { get; set; }
        DbSet<OrderMedicine> orderMedicines { get; set; }
        DbSet<Medicine> medicines { get; set; }
        DbSet<Delivery> deliveries { get; set; }
        

    }
}
