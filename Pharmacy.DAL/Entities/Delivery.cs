using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class Delivery
    {
        public int ID { get; set; }
        public double? DeliveryFees { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
