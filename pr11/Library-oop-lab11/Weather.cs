using System;
using System.Text;
using System.Net;

namespace Library_oop_lab11
{
    public class Weather
    {
        public string Temperature {private set; get; }
        public string Wind { private set; get; }
        public string Humidity { private set; get; }
        public string Pressure { private set; get; }
        public string PictureURL { private set; get; }
        public string SkyStatus { private set; get; }

        public Weather()
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            String str = web.DownloadString("https://meteo.gov.ua/ua/33651");
            this.Temperature = System.Text.RegularExpressions.Regex.Match(str, @"<span id=""curWeatherT"">(.+)</span>").Groups[1].Value;
            this.Wind = System.Text.RegularExpressions.Regex.Match(str, @"<span id=""curWeatherWS"">(.+)</span>").Groups[1].Value;
            this.Humidity = System.Text.RegularExpressions.Regex.Match(str, @"<span id=""curWeatherHu"">(.+)</span>").Groups[1].Value;
            this.Pressure = System.Text.RegularExpressions.Regex.Match(str, @"<span id=""curWeatherPr"">(.+)</span>").Groups[1].Value;
            this.PictureURL = System.Text.RegularExpressions.Regex.Match(str, @"<img id=""curWeatherCl"" border=""0"" title="".+"" src=""(.+)"">").Groups[1].Value;
            this.SkyStatus = System.Text.RegularExpressions.Regex.Match(str, @"<img id=""curWeatherCl"" border=""0"" title=""(.+)"" src="".+"">").Groups[1].Value;
        }
    }
}
