using MY_WHETHER_YANDEX_PARSER.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MY_WHETHER_YANDEX_PARSER.API
{
    class ApiWorker
    {
        public static CoordData GetCoordData(string cityName)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            webClient.Headers.Add("X-Yandex-API-Key", "60dbc116-441a-4f48-a37d-4a09d073dd59");

            string jsonData = webClient.DownloadString($"https://geocode-maps.yandex.ru/1.x/?format=json&apikey={webClient.Headers.Get(1)}&geocode=Россия,город{cityName}");

            JObject json = JObject.Parse(jsonData);
            JToken jToken = json.SelectToken("response").SelectToken("GeoObjectCollection").SelectToken("featureMember")[0].SelectToken("GeoObject").SelectToken("Point").SelectToken("pos");

            string lon = jToken.ToString().Split(' ')[0];
            string lat = jToken.ToString().Split(' ')[1];

            return new CoordData() { CityName = cityName, Lat = lat, Lon = lon };
        }

        public static WeatherData GetWeatherData(CoordData coordData)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            webClient.Headers.Add("X-Yandex-API-Key", "641f296b-5323-4ed5-9034-082f5187935d");

            string jsonData = webClient.DownloadString($"https://api.weather.yandex.ru/v2/forecast?lat={coordData.Lat}&lon={coordData.Lon}");

            JObject json = JObject.Parse(jsonData);

            return JsonConvert.DeserializeObject<WeatherData>(json["fact"].ToString());
        }
    }
}
