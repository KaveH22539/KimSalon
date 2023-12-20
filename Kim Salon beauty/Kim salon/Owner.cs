using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HairDres
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public Owner(int ownerID, string name, string contactInformation)
        {
            OwnerID = ownerID;
            Name = name;
            ContactInformation = contactInformation;
        }
    }
    
}
