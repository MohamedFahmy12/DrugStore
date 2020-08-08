using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy.DAL.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public int PhoneNumber { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
