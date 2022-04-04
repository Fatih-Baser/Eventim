using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterClassPattern.Classes
{
    class JsonConverter
    {
        private IEnumerable<Eventim> eventim_;

        public JsonConverter(IEnumerable<Eventim> eventim)
        {
            eventim_ = eventim;
        }

        public void ConvertToJson()
        {
            var jsonEventims = JsonConvert.SerializeObject(eventim_, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonEventims);
        }
    }
}
