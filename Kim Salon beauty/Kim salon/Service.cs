using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HairDres
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Service(int serviceID, string description, decimal price)
        {
            ServiceID = serviceID;
            Description = description;
            Price = price;
        }
    }
}
