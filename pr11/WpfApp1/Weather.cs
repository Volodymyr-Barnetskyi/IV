using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace Weather
{
    class Weather
    {
        static private string city;
        static private string temp;
        static private string wind;
        static private string humid;

        static public void getData()
        {
            WebClient web = new WebClient();
            Byte[] pageData = web.DownloadData("https://www.gismeteo.ua/ua/weather-kolomyya-4971/now/");
            string pageHtml = Encoding.UTF8.GetString(pageData);
            Console.WriteLine(pageHtml);
            Regex regex = new Regex(@"placeholder(\w*)""");
            foreach (Match match in regex.Matches(pageHtml))
            {
                Console.WriteLine(match.ToString());
            }
            Console.ReadLine();

        }
    }
}
