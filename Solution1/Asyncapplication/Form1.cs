using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asyncapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             GetTheFileData();
           // await GetTheFileDataAsync();
        }
        private void GetTheFileData()
        {
            string fileName = @"C:\Users\praka\OneDrive\Desktop\System Design\API Design.pdf";
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    textBox1.Text = s.TrimEnd();
                }
            }

        }

        private async Task GetTheFileDataAsync()
        {
            string fileName = @"C:\Users\praka\OneDrive\Desktop\System Design\DSA By Pattern.txt";
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = String.Empty;
                string output = string.Empty;
                while ((s = await sr.ReadLineAsync()) != null)
                {
                    output += s;
                }
                textBox1.Text = output.TrimEnd();
            }

        }
    }
}
