using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPtest
{
    [XmlType("Admin")]

    class Admin : Administrator
    {
        [XmlElement("password")] // This will be an element of the Admin element.
        public string password { get; set; }

        public Admin() { }

        public Admin(string password)
        {
            this.password = password;
        }
    }
}
