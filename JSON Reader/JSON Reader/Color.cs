using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace JSON_Reader
{
    [DataContract]
    class Color
    {
        [DataMember]
        public String colorName { get; set; }
        [DataMember]
        public String hexValue { get; set; }
        [DataMember]
        public String example { get; set; } 
    }

  }
