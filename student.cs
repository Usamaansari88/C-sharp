using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2forms
{
    public class student
    {
        public string name;
        public int roll;
        public string section;

        public void set(string n, int r, string s)
        {
            this.name = n;
            this.roll = r;
            this.section = s;
        }

    }
}
