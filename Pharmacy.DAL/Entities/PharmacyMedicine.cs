using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class PharmacyMedicine
    {
        [Key]
        public int ID { get; set; }
        public int PharmacyId { get; set; }
        public int MedicineId { get; set; }
        public virtual DrugStore Pharmacy { get; set; }
        public virtual Medicine Medicine { get; set; }

    }
}
