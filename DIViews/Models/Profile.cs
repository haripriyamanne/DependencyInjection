using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIViews.Models
{
    public class Profile
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public State State { get; set; }
        public string FavColor { get; set; }
    }
}
