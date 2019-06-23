using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SaleClassLibrary
{
    [DataContract]
   public class Customer
    {
        [DataMember]
        public int CustomerID;

        [DataMember]
        public string CustomerName;

        
        [DataMember]
        public string Address;

        [DataMember]
        public string EmailId;
    }
}
