using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public List<string> fav_list = new List<string>();
        //string[] fav_list = new string[100];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void addFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //if (e.C == Keys.Enter) {
                fav_list.Add(textBox1.Text.ToString());
          // }
        }

        private void browseFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
