using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Program;

namespace Fitness.BL
{
    internal class Exercise
    {

        private string Name;
        private List<Set> Sets;

            public Exercise(string name)
            {
                Name = name;
                Sets = new List<Set>();
            }

            public void AddSet(Set set)
            {
                Sets.Add(set);
            }
        public void SetName(string name)
        {
            this.Name= name;
        }
        public string GetName() { 
            return this.Name; 
        }
        }

    }
