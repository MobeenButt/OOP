using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self2
{
  class Class2
    {
  
        public Class2(string sname, float matricMarks, float fscMarks, float ecatMarks, float aggregate)
        {
            this.sname = sname;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.aggregate = aggregate;
        }
    
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
