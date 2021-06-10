using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIViews.Models
{
    public class State
    {
        public State(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}

