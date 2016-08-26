using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class WebScraper
    {
        public void GetHtml()
        {
            HtmlWeb web = new HtmlWeb();
 
            HtmlDocument document = web.Load("http://www.wegottickets.com/searchresults/all");

            HtmlNode[] links =
                document.DocumentNode.SelectNodes("//a")
                    .Where(x => x.Attributes.Contains("class") && x.Attributes["class"].Value.Contains("event_link")).ToArray();
         


            foreach (HtmlNode item in links)
            {
                Console.WriteLine(item.InnerHtml); 
            }

        }

    }
}
