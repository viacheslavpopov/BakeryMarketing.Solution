using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Bakery.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Sweets = new HashSet<FlavorSweet>();
        }
        public int FlavorId { get; set; }

        [Display(Name = "Flavor Name")]
        public string FlavorName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorSweet> Sweets { get; set; }
    }
}