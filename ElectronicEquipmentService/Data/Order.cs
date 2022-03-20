using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicEquipmentService.Data
{
    public class Order
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public User user { get; set; }
        public string Type { get; set; }
        public string Discription { get; set; }
        public DateTime DateOnOrder { get; set; }
        public string Status { get; set; }
    }
}
