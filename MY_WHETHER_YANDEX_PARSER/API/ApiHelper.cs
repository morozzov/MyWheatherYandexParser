using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_WHETHER_YANDEX_PARSER.API
{
    //rain — дождь.
    //moderate-rain — умеренно сильный дождь.
    //heavy-rain — сильный дождь.
    //continuous-heavy-rain — длительный сильный дождь.
    //showers — ливень.
    //wet-snow — дождь со снегом.
    class ApiHelper
    {
        private static Dictionary<string, string> conditions = new Dictionary<string, string>()
        {
            { "clear","ясно"},
            { "partly-cloudy", "малооблачно" },
            { "cloudy", "облачно с прояснениями"},
            { "overcast", "пасмурно" },
            { "drizzle", "морось"},
            { "light-rain","небольшой дождь"},
            { "rain", "дождь"},
            { "moderate-rain", "умеренно сильный дождь"},
            { "heavy-rain", "сильный дождь"},
            { "continuous-heavy-rain", "длительный сильный дождь"},
            { "showers", "ливень"},
            { "wet-snow", "дождь со снегом"},
            { "light-snow", "небольшой снег"},
            { "snow", "снег"},
            { "snow-showers", "снегопад"},
            { "hail", "град"},
            { "thunderstorm", "гроза"},
            { "thunderstorm-with-rain", "дождь с грозой"},
            { "thunderstorm-with-hail", "дождь с градом"}
        };

        private static Dictionary<string, string> winDirs = new Dictionary<string, string>()
        {
            { "nw", "северо-западное" },
            { "n", "северное" },
            { "ne", "северо-восточное" },
            { "e", "восточное" },
            { "se", "юго-восточное" },
            { "s", "южное" },
            { "sw", "юго-западное" },
            { "w", "западное" },
            { "с", "штиль" }
        };

        public static string GetWeatherCondition(string key)
        {
            return conditions[key];
        }

        public static string GetWinDir(string key)
        {
            return winDirs[key];
        }
    }
}
