using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader
{
    public partial class Form1 : Form
    {
        public string web;

        public Form1()
        {
            InitializeComponent();
            string hp = "www.google.com";
            //webBrowser1.GoSearch();
            webBrowser1.Navigate(hp);
            lb1.Items.Add("www.youtube.com");
            lb1.Visible = false;
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(lb1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hp = "www.google.com";
            //webBrowser1.GoSearch();
            webBrowser1.Navigate(hp);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(webBrowser1.Url);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lb1.Visible = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            web = (webBrowser1.Url.ToString());
            txt.Text = web;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string wb = txt.Text;
            webBrowser1.Navigate(wb);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
