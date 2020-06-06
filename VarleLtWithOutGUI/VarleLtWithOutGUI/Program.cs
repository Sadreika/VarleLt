using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace VarleLtWithOutGUI
{
    public class Program
    {
        private string url = "https://www.varle.lt/visos/";
        List<string> varleLtUrls = new List<string>();
        public void gettingAllLinks()
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument data = hw.Load(url);
            foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='departments-links-wrapper']//a"))
            {
                varleLtUrls.Add(link.GetAttributeValue("href", string.Empty));
            }
        }
        static void Main(string[] args)
        {
            Program programObject = new Program();
            programObject.gettingAllLinks();
        }
    }
}
