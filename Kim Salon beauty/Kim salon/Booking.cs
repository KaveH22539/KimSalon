using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HairDres
{
    public class Booking
    {
        public int AppointmentID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string ServiceType { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string Status { get; set; }
    }
    
}
