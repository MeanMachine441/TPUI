using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPtest
{
    [XmlType("Administrator")] // The name of the root element for this class when it is serialized.
    [XmlInclude(typeof(Admin))] // This is a base class. Derived classes must be listed like this.

    
    class Administrator
    {
        public Administrator() { }

    }
}
