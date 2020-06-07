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
            List<string> titles = new List<string>();
            try
            {
                //Console.WriteLine(url);
                HtmlWeb hw = new HtmlWeb();
                HtmlDocument data = hw.Load(url);
              /*  foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  first']//a[@class='title']"))
                {
                     titles.Add(link.InnerText);
                }
                */
              /*  foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  last']//a[@class='title']"))
                {
                    titles.Add(link.InnerText);
                }
                */
                foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='grid-item product  ']//a[@class='title']"))
                {
                    titles.Add(link.InnerText);
                }
                
                for(int i = 0; i < titles.Count; i++)
                {
                    Console.WriteLine(titles[i]);
                }
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}
