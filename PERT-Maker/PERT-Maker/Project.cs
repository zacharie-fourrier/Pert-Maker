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
        public String ProjectName { get; set; }
        public String ProjectDesc { get; set; }
        public BindingList<Task> Tasks { get; set; }
        public float Duration { get; set; }
        public string TimeUnit { get; set; }
        public string TimeUnitShort { get; set; }
        private Task EndTask { get; set; }

        public void NewTasks(Task t)
        {
            Tasks.Add(t);
            CalculateDuration();
            CalculateEndTask();
        }

        public Task GetTaskByName(String name)
        {
            foreach(Task t in Tasks)
            {
                if (t.name == name) return t;
            }
            return null;
        }

        public List<List<Task>> GetCriticalPath(List<Task> listTask = null)
        {
            Task task;
            List<List<Task>> finalList = new List<List<Task>>();
            if (listTask == null) {
                if (EndTask == null) CalculateEndTask();
                task = EndTask;
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
                    finalList.Add(GetCriticalPath(listTask)[0]);
                }
            }
            return finalList;
        }

        private void CalculateDuration()
        {
            if (EndTask == null) CalculateEndTask();
            Duration = EndTask.getEarliestEnd();
        }

        private void CalculateEndTask()
        {
            bool final = true;

            foreach (Task t in Tasks)
            {
                foreach (Task T in Tasks)
                {
                    foreach(Task d in T.getDependencies())
                    {
                        if (d == t) final = false;
                    }
                }
                if (final == true) EndTask = t;
            }
        }
    }
}
