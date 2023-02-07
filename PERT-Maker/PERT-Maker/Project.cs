using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERT_Maker
{
    public class Project
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

        public List<List<Task>> getCriticalPath(List<Task> listTask = null)
        {
            Task task;
            List<List<Task>> finalList = new List<List<Task>>();
            if (listTask == null) {
                if (endTask == null) calculateEndTask();
                task = endTask;
            } else
            {
                task = listTask[listTask.Count() - 1];
            }

            if (task.getDependencies() == null)
            {
                List<List<Task>> listListTask = new List<List<Task>>();
                listListTask.Add(listTask);
                return listListTask;
            }

            foreach(Task t in task.getDependencies())
            {
                if((t.getEarliestStart() - t.getLatestStart()) == 0)
                {
                    if (listTask == null) listTask = new List<Task>();
                    listTask.Add(t);
                    finalList.Add(getCriticalPath(listTask)[0]);
                }
            }
            return finalList;
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
