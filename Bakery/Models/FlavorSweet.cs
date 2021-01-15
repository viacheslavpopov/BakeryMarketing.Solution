namespace Bakery.Models
{
    public class FlavorSweet
    {
        public int FlavorSweetId { get; set; }
        public int FlavorId { get; set; }
        public int SweetId { get; set; }

        public Flavor flavor { get; set; }
        public Sweet sweet { get; set; }
    }
}