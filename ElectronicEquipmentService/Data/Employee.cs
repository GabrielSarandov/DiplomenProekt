using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicEquipmentService.Data
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Experiance { get; set; }
        public string Discription { get; set; }
        public DateTime Date { get; set; }
        public string Images { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
