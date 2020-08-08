using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class Medicine
    {
        [Key]
        public int ID { get; set; }
        public string MedicineName { get; set; }
        public string MedicalName { get; set; }
        public double? Price { get; set; }
        public bool PrescriptionRequired { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PharmacyMedicine> PharmacyMedicines { get; set; }
        public virtual ICollection<OrderMedicine> OrderMedicines { get; set; }

    }
}
