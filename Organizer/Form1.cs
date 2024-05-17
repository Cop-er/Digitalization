using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void folderopen(string folderpath)
        {
            try { 
            Process.Start("explorer.exe", folderpath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String folderpath = @"C:\Sorted Scanned Files";
            folderopen(folderpath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String folderpath = @"C:\Processed PDFs";
            folderopen(folderpath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String folderpath = @"C:\Users\NBF\Desktop\Scanned";
            folderopen(folderpath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try {
            String url = "http://192.168.4.143/";
            Process.Start("chrome.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void openExe(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Floi\Main_Application";
            folderopen(path);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Floi\Checker\dist\main.exe";
            openExe(path);
        }
    }
}
