using System;
using System.Linq;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Xml;

namespace RssFeedReader
{
  class Program
  {
    static void Main(string[] args)
    {
      var url = new Uri("https://www.crunchyroll.com/boruto-naruto-next-generations.rss");
      Console.WriteLine($"Fetching {url}");
      // HttpClient httpClient = new HttpClient();
      // var results = httpClient.GetStringAsync(url).Result;
      // Console.WriteLine(results);
      using var reader = XmlReader.Create(url.ToString());
      var feed = SyndicationFeed.Load(reader);
      foreach (var item in feed.Items)
      {
        Console.WriteLine(item.Title.Text);
      }

      Console.ReadKey();
    }
  }
}
