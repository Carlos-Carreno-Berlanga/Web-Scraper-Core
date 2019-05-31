using AngleSharp;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Scraper_Core
{
    class Program
    {
        static async Task Main(string[] args)
        {


            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.google.com/search?q=pound+euro&oq=pound+euro&aqs=chrome..69i57j0l5.2349j1j7&sourceid=chrome&ie=UTF-8";
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            var cellSelector = ".BNeawe.iBp4i.AP7Wnd";
            var cells = document.QuerySelectorAll(cellSelector);
            var titles = cells.Select(m => m.TextContent);
            foreach (var title in titles)
            {
                Console.WriteLine($"{title}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
