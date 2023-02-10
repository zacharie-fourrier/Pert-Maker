using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PERT_Maker
{
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescTextBox.Text = "";
            Hide();
        }

        private void ConfirmProjectBtn_Click(object sender, EventArgs e)
        {
            if(TitleTextBox.Text.Length > 0) {
                string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Data\";
                string filter = "*.json";
                string[] files = Directory.GetFiles(folder, filter);
                foreach(string f in files)
                {
                    Regex rx = new Regex(@".*\\(?<filename>[\w|\s]+).json",
                    RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection matches = rx.Matches(f);
                    GroupCollection groups = matches[0].Groups;
                    string filename = groups["filename"].Value;

                    if(filename == TitleTextBox.Text)
                    {
                        string message = "A project with the same name already exists, cancel ?";
                        string caption = "Wrong project name";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes) { Close(); }
                        else { return; }
                    }
                }
                string stu;
                switch (TimeUnitSelector.Text)
                {
                    case "hours":
                        stu = "H";
                        break;
                    case "days":
                        stu = "d";
                        break;
                    case "weeks":
                        stu = "w";
                        break;
                    case "months":
                        stu = "M";
                        break;
                    default:
                        stu = "";
                        break;
                }
                Project newProject = new Project
                {
                    ProjectName = TitleTextBox.Text,
                    ProjectDesc = DescTextBox.Text,
                    TimeUnit = TimeUnitSelector.Text,
                    TimeUnitShort = stu
                };
                JSONFileUtils.WriteJSON(newProject, @"./Data/" + newProject.ProjectName + ".json");
                
                Close();
            }
            else
            {
                string message = "You did not enter a project name. Cancel this operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Close();
                }
            }
        }
    }
}