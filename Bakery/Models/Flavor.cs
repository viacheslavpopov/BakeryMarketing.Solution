using System.Collections.Generic;
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
        public string FlavorName { get; set; }
        public virtual ICollection<FlavorSweet> Sweets { get; set; }
    }
}