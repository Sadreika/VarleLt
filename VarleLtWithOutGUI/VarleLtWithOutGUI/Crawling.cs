using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarleLtWithOutGUI
{
    public class Crawling
    {
        public void startCrawling(string url)
        {
            try
            {
                Console.WriteLine(url);
                HtmlWeb hw = new HtmlWeb();
                HtmlDocument data = hw.Load(url);
                foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  first']//a"))
                {
                 
                    // varleLtUrls.Add(link.GetAttributeValue("href", string.Empty));
                }
                foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  last']//a"))
                {
                  
                    // varleLtUrls.Add(link.GetAttributeValue("href", string.Empty));
                }
                foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  ']//a"))
                {
                   
                    // varleLtUrls.Add(link.GetAttributeValue("href", string.Empty));
                }

            }
            catch(Exception ex)
            {

            }
        }
    }
}
