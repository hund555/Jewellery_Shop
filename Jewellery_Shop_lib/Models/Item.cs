namespace Jewellery_Shop_lib.Models
{
    public abstract class Item
    {
        public abstract int Id { get; set; }
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }

    }
}
