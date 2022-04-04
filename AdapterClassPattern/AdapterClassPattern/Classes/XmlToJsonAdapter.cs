using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassPattern.Classes
{
    class XmlToJsonAdapter
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var eventims = _xmlConverter.GetXML()
                    .Element("Eventims")
                    .Elements("Eventim")
                    .Select(m => new Eventim
                    { 
                        Name = m.Attribute("Name").Value,
                        Surname = m.Attribute("Surname").Value,
                        PhoneNo = Convert.ToInt32(m.Attribute("PhoneNo").Value),
                        Miejsca = m.Attribute("Miejsca").Value
                        
                    });

            new JsonConverter(eventims)
                .ConvertToJson();
        }
    }
}
