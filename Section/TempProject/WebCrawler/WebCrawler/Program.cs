using HtmlAgilityPack;
using System.Net.Http;
namespace WebCrawler

{
    class Program
    {
        static void Main()
        {
            startCrawlerasync();
            Console.ReadKey();
        }

        private static async Task startCrawlerasync()
        {
            var url = "https://www.automobile.tn/neuf/bmw.3/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var divs = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Equals("versions-items"));
            var cars = new List<Car>();
            foreach(var div in divs )
            {
                var car = new Car()
                {
                    Model = div.Descendants("h2").FirstOrDefault().InnerText,
                    Price = div.Descendants("div").FirstOrDefault().InnerText,
                    Link = div.Descendants("a").FirstOrDefault().InnerText,
                    ImageUrl = div.Descendants("img").FirstOrDefault().InnerText

                };
               cars.Add(car);
            }
        }
    }
}
