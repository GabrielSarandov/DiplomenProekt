using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicEquipmentService.Data
{
    public class Execute
    {
        public string Id { get; set; }
        public string OrderId{ get; set; }
        public string EmployeeId { get; set; }
        public string Discription { get; set; }
        public string Warrantly { get; set; }
        public string StatusOfOrder { get; set; }
        public string PriceOf { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
