namespace Bakery.Models
{
    public class FlavorSweet
    {
        public int? FlavorSweetId { get; set; }
        public int? FlavorId { get; set; }
        public int? SweetId { get; set; }

        public virtual Flavor Flavor { get; set; }
        public virtual Sweet Sweet { get; set; }
    }
}