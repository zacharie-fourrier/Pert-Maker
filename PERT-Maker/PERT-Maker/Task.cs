using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERT_Maker
{
    public class Task
    {
        public String name;
        public float duration;
        public uint workforce;
        private List<Task> dependencies;
        private List<Task> requirements;

        public Task(String n, float d, uint wf)
        {
            name = n;
            duration = d;
            workforce = wf;
        }

        public List<Task> getDependencies()
        {
            return dependencies;
        }

        public float getEarliestStart()
        {
            if (dependencies.Count() == 0)
            {
                return 0;
            } else
            {
                float max = 0;
                foreach (Task t in dependencies)
                {
                    if (t.getEarliestEnd() > max) max = t.getEarliestEnd();
                }
                return max;
            } 
        }

        public float getLatestStart()
        {
            return this.getLatestEnd() - this.duration;
        }

        public float getEarliestEnd()
        {
            return this.getEarliestStart() + this.duration;
        }

        public float getLatestEnd()
        {
            if (requirements.Count() == 0)
            {
                return getEarliestEnd();
            }
            else
            {
                float min = requirements[0].getLatestStart();
                foreach (Task t in requirements)
                {
                    if (t.getLatestStart() < min) min = t.getLatestStart();
                }
                return min;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
