using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterClassPattern.Classes
{
    class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Eventims");
            var xAttributes = EventimDataProvider.GetData()
                .Select(m => new XElement("Eventim",
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("Surname", m.Surname),
                                     new XAttribute("PhoneNo", m.PhoneNo),
                                    new XAttribute("Miejsca", m.Miejsca)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
