using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz10._4
{
    internal class Statuses
    {
        public string Name { get; set; }
        public Status status { get; set; }
        public Statuses(string name, Status st)
        {
            Name = name;
            status = st;
        }
    }
    public enum Status
    {
        Active,
        completed
    }
}

