using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HairDres
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

       

        public Customer(int customerID, string name,string contact)
        {
            CustomerID = customerID;
            Name =  name;
            Contact = contact;
        }
    }
}
