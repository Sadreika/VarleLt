using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarleLt
{
    public class InforamtionAboutItem
    {
        private string itemName;
        private string itemMaxPrice;
        private string itemMinPrice;
        private string url = "https://www.varle.lt/visos/";
        public List<string> varleLturls = new List<string>();

        public void settingItemName(string givenItemName)
        {
            this.itemName = givenItemName;
        }
        public void settingItemMaxPrice(string maxPrice)
        {
            this.itemMaxPrice = maxPrice;
        }
        public void settingItemMinPrice(string minPrice)
        {
            this.itemMinPrice = minPrice;
        }

        public void showData()
        {
            Console.WriteLine(itemName + itemMaxPrice + itemMinPrice);
        }

        public void gettingAllLinks ()
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument data = hw.Load(url);
            foreach (HtmlNode link in data.DocumentNode.SelectNodes("//div[@class='departments-links-wrapper']//a"))
            {
                varleLturls.Add(link.GetAttributeValue("href", string.Empty));
            }
        }
    }
}
