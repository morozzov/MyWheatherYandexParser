using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MY_WHETHER_YANDEX_PARSER.Entities
{
    class CoordData
    {
        public string CityName { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }
    }
}
