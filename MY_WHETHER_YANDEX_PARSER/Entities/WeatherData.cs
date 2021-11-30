using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_WHETHER_YANDEX_PARSER.Entities
{
    class WeatherData
    {
        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("wind_speed")]
        public string WindSpeed { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure_mm")]
        public string PressureMM { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }
    }
}
