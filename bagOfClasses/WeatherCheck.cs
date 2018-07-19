using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace bagOfClasses
{/*
    class WeatherCheck
    {
        public class DataObject
        {
            public string Name { get; set; }    
        }

        public class Class1
        {
            private const string URL = "https://api.darksky.net/forecast/abe32ce7045aa752f84a0c20118f2ea0/42.3601,-71.0589";
            private string urlParameters = "?api_key=abe32ce7045aa752f84a0c20118f2ea0";

            static void Main(string[] args)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);

                //
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsStringAsync<IEnumerable<DataObject>>().Result;
                    foreach (var d in dataObjects)
                    {
                        Console.WriteLine("{0}", d.Name);

                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }

        }

            





    }
    */
}
