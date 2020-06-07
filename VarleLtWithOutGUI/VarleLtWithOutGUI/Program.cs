using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace VarleLtWithOutGUI
{
    public class Program
    {
        public List<string> gettingAllLinks(string url)
        {
            List<string> varleLtUrls = new List<string>();
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument data = hw.Load(url);
            foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='departments-links-wrapper']//a"))
            {
                varleLtUrls.Add(link.GetAttributeValue("href", string.Empty));
            }
            return varleLtUrls;
        }
        static void Main(string[] args)
        {
            string url = "https://www.varle.lt/visos";
            List<string> varleLtUrls = new List<string>();
            Program programObject = new Program();
            varleLtUrls = programObject.gettingAllLinks(url);
            Crawling crawlingObject = new Crawling();
            for(int i = 0; i < varleLtUrls.Count; i++)
            {
                crawlingObject.startCrawling(url + varleLtUrls[i]);
            }    
        }
    }
}
