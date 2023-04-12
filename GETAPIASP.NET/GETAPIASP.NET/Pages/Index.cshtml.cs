using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using System.Net;

namespace GETAPIASP.NET.Pages
{
    public class Planet
    {
        public string Name { get; set; }
        public string Gravity { get; set; }
        public List<string> Residents { get; set; } = new List<string>();
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Planet planet = new();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        HttpClient httpClient = new HttpClient();
        public void OnGet()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://swapi.dev/api/planets/1/");
            
            dynamic data = JObject.Parse(json);
            planet.Name = data.name;
            planet.Gravity = data.gravity;
                if (data.residents != null)
                {
                    foreach (string item in data.residents)
                    {
                        json = wc.DownloadString(item);
                        dynamic pepole = JObject.Parse(json);
                        planet.Residents.Add((string)pepole.name);
                    }

                }
            }
        }
        public void OnGetId(int id)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString($"https://swapi.dev/api/planets/{id}/");

                dynamic data = JObject.Parse(json);
                planet.Name = data.name;
                planet.Gravity = data.gravity;
                if (data.residents != null)
                {
                    foreach (string item in data.residents)
                    {
                        json = wc.DownloadString(item);
                        dynamic pepole = JObject.Parse(json);
                        planet.Residents.Add((string)pepole.name);
                    }

                }
            }
        }
    }
}