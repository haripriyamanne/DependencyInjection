using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIViews.Models
{
    public class ProfileOptionsService
    {
        public List<string> ListGenders()
        {
            // keeping this simple
            return new List<string>() { "Female", "Male" };
        }

        public List<State> ListStates()
        {

            return new List<State>()
            {
                 
                new State("AndhraPradesh","AP"),
                new State("Telegana", "TS"),
                new State("TamilNadu", "TN")
            };
        }

        public List<string> ListColors()
        {
            return new List<string>() { "Blue", "Green", "Red", "Yellow" };
        }
    }

    //public class State
    //{
    //    private string Name;
    //    private string Code;

    //    public State(string Name, string Code)
    //    {
    //        this.Name = Name;
    //        this.Code = Code;
    //    }
    //}


}
 


