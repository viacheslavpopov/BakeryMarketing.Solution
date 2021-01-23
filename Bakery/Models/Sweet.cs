using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bakery.Models
{
    public class Sweet
    {
        public Sweet()
        {
            this.Flavors = new HashSet<FlavorSweet>();
        }
        public int SweetId { get; set; }

        [Display(Name = "Sweet Name")]
        public string SweetName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorSweet> Flavors { get; set; }
    }
}