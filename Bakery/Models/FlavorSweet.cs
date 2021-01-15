namespace Bakery.Models
{
    public class FlavorSweet
    {
        public int FlavorSweetId { get; set; }
        public int FlavorId { get; set; }
        public int SweetId { get; set; }

        public Flavors flavor { get; set; }
        public Sweets sweet { get; set; }
    }
}