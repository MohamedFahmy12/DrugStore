using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class DrugStore
    {
        [Key]
        public int ID { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string PharmacyName { get; set; }
        public string LeadingPharmacist { get; set; }
        public TimeSpan WorkingHours { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PharmacyMedicine> PharmacyMedicines { get; set; }
    }
}
