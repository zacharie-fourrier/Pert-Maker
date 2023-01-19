using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERT_Maker
{
    internal class Project
    {
        public String projectName;
        public String projectDesc;
        public BindingList<Task> tasks;
        public float duration;
        public string timeUnit;
        public string timeUnitShort;
        private Task endTask;

        public Project(String name)
        {
            this.projectName = name;
        }
        public void newTasks(Task t)
        {
            tasks.Add(t);
            calculateDuration();
            calculateEndTask();
        }

        public Task getTaskByName(String name)
        {
            foreach(Task t in tasks)
            {
                if (t.name == name) return t;
            }
            return null;
        }

        public List<Task> getCriticalPath()
        {

        }

        private void calculateDuration()
        {
            if (endTask == null) calculateEndTask();
            duration = endTask.getEarliestEnd();
        }

        private void calculateEndTask()
        {
            bool final = true;

            foreach (Task t in tasks)
            {
                foreach (Task T in tasks)
                {
                    foreach(Task d in T.getDependencies())
                    {
                        if (d == t) final = false;
                    }
                }
                if (final == true) endTask = t;
            }
        }
    }
}
