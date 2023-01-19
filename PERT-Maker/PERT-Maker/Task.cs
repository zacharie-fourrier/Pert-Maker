using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERT_Maker
{
    internal class Task
    {
        public String name;
        public float duration;
        private List<Task> dependencies;

        public Task(String n, float d)
        {
            name = n;
            duration = d;
        }

        public List<Task> getDependencies()
        {
            return dependencies;
        }

        public float getEarliestStart()
        {
            if (dependencies.Count() == 0)
            {
                return duration;
            } else
            {
                float max = 0;
                foreach (Task t in dependencies)
                {
                    if (t.getEarliestStart() > max) max = t.getEarliestStart();
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
            
        }

        public override string ToString()
        {
            
        }
    }
}
