﻿using System;
using System.Windows.Forms;
using UpdaterManagerLibrary;

namespace Sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UpdaterManager updaterManager = new UpdaterManager();

            string url = "https://onedrive.live.com/download?resid=7D7FF9DFDA23C644!1341&authkey=!AKmePXmib2r6-sU";

            Console.WriteLine(UpdaterManager.CheckForUpdates(new Version(Application.ProductVersion), new Uri(url), false));
        }
    }
}
