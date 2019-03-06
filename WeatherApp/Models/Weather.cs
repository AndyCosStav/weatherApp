using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public Object GetWeather()
        {
            string url = "https://api.darksky.net/forecast/c30caf7803678145d408195f953642e9/51.5074,-0.1278";

            var client = new WebClient();

            var todaysWeather = client.DownloadString(url);

            var serializer = new JavaScriptSerializer();

            var jsonContent = serializer.Deserialize<Object>(todaysWeather);

            return jsonContent;


        }
    }
}