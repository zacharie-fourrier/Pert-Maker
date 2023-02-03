using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERT_Maker
{
    public partial class Form1 : Form
    {
        public List<String> openedProjects;

        public Form1()
        {
            InitializeComponent();
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