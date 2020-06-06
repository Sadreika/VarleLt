using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarleLt
{
    public partial class StartingWindow : Form
    {
        InforamtionAboutItem InforamtionAboutItemObject = new InforamtionAboutItem();
        public StartingWindow()
        {
            InitializeComponent();
        }

        public void readingDataFromTextBox()
        {
            string item = textBox1.Text;
            string max_sum = textBox2.Text;
            string min_sum = textBox3.Text;
            InforamtionAboutItemObject.settingItemName(item);
            InforamtionAboutItemObject.settingItemMaxPrice(max_sum);
            InforamtionAboutItemObject.settingItemMinPrice(min_sum);

            InforamtionAboutItemObject.gettingAllLinks();
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            readingDataFromTextBox();
        }
    }
}
