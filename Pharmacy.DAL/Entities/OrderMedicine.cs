using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class OrderMedicine
    {
        public int ID { get; set; }
        public int MedicineId { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Medicine Medicine { get; set; }
    }
}
