using System.Collections.Generic;
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
        public string SweetName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorSweet> Flavors { get; set; }
    }
}