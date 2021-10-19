using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;


namespace ScrrenSaverAPT
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        public ChromiumWebBrowser chromeBrowser;



        public Form1()
        {
            InitializeComponent();
            
            InitializeChromium();

            while (true)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    System.Environment.Exit(1);
                }
            }


        }

      

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            //ako e bql ekran znachi fileovete ne sa na pravilnoto mqsto

            String page = string.Format(@"{0}\html-resources\index.html", Application.StartupPath);

            if (!File.Exists(page))
            {
                MessageBox.Show("ne se namira file a : " + page);
            }

            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(page);

            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            // Allow the use of local resources in the browser
            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chromeBrowser.BrowserSettings = browserSettings;
        }

        
    }
}

