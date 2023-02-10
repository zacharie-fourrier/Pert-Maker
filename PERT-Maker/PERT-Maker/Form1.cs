//Code by Alexandre Prat & Zacharie Fourrier



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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PERT_Maker
{
    public partial class Form1 : Form
    {
        public List<Project> openedProjects = new List<Project>();

        public Form1()
        {
            InitializeComponent();
            string filename;
            string text;
            try
            {
                filename = @"./Data/config.json";
                text = File.ReadAllText(filename);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                Warnings.Text = "Couldn't find config.json, creating it now...";
                string newConfig = "[]";
                File.WriteAllText(@"./Data/config.json", newConfig);
                Warnings.Text = "Created config files, you can create or import projects now.";
                text = "";
            }

            if (text.Length > 0)
            {
                List<string> ls;
                try
                {
                    ls = JsonSerializer.Deserialize<List<string>>(text);
                    Warnings.Text = "Loaded ./Data/config.json";
                    if (ls.Count == 0) { return; }
                }
                catch (Exception ex)
                {
                    Warnings.Text = "Error while reopening your projects";
                    JSONFileUtils.WriteTXT(ex.ToString(), @"./Data/logs.txt");
                    return;
                }
                foreach (string file in ls)
                {
                    try
                    {
                        filename = @"./Data/" + file + ".json";
                        text = File.ReadAllText(filename);
                        var options = new JsonSerializerOptions
                        {
                            IncludeFields = true
                        };
                        openedProjects.Add(JsonSerializer.Deserialize<Project>(text, options));
                    }
                    catch (Exception ex)
                    {
                        Warnings.Text = "Loading of " + file + " has gone wrong, cancelling.";
                        JSONFileUtils.WriteTXT(ex.ToString(), @"./Data/logs.txt");
                        JSONFileUtils.WriteTXT("Failed loading of " + file, @"./Data/logs.txt");
                    }
                }
            }
            else
            {
                Warnings.Text = "Config file is empty, load a project to start working";
            }

            foreach (Project p in openedProjects)
            {
                CreateProjectTab(p);
            }

            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\";
            string filter = "*.json";
            string[] files = Directory.GetFiles(folder, filter);
            foreach (string f in files)
            {
                Regex rx = new Regex(@".*\\(?<filename>[\w|\s]+).json",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = rx.Matches(f);
                GroupCollection groups = matches[0].Groups;
                string fileMatched = groups["filename"].Value;
                foreach (Project p in openedProjects)
                {
                    if (fileMatched != p.ProjectName && fileMatched != "config")
                    {
                        //loadProjectToolStripMenuItem.DropDownItems.Add(filename);
                        //Doesnt seem to work and is placed in a weird spot
                    }
                }
            }
        }

        private void FileNewProject_Clicked(object sender, EventArgs e)
        {
            CreateProject form = new CreateProject();
            form.Show();

        }

        private void QuitApp(object sender, EventArgs e)
        {
            Warnings.Text = "Preparing for shutdown";
            JSONFileUtils.WriteJSON(openedProjects, @"./Data/config.json");
            Application.Exit();
        }

        private void CreateProjectTab(Project p)
        {
            TabPage newTab = new TabPage(p.ProjectName);
            MainPanel.TabPages.Add(newTab);
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}