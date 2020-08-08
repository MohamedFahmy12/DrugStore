using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string ReceiverName { get; set; }
        public int PharmacyId { get; set; }
        public int DeliveryId { get; set; }
        public virtual  ICollection<OrderMedicine> OrderMedicines { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual DrugStore Pharmacy { get; set; }
        public virtual Delivery Delivery { get; set; }

    }
}
