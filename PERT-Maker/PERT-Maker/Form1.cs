﻿//Code by Alexandre Prat & Zacharie Fourrier



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace PERT_Maker
{
    public partial class Form1 : Form
    {
        public List<String> openedProjects = new List<string>();

        public Form1()
        {
            InitializeComponent();
            try
            {
                const string filename = @"./Data/config.json";
                string text = File.ReadAllText(filename);
                openedProjects = JsonSerializer.Deserialize<List<string>>(text);
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                //CREATE ./Data/config.json HERE
            }

            foreach(string s in openedProjects)
            {
                TabPage newTab = new TabPage(s);
                MainPanel.TabPages.Add(newTab);
            }
        }

        private void FileNewProject_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("bruh");
        }

        private void QuitApp(object sender, EventArgs e) => Application.Exit();

        //private void CreateProjectTab(Project p)
        //{
            
        //}
    }
}