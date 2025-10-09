namespace Jewellery_Shop_lib.Domain
{
    /// <summary>
    /// Base class for all items in the jewellery shop.
    /// It defines the common properties that every item must have: ID, description, and price.
    /// </summary>
    public abstract class Item
    {
        public abstract int Id { get; set; }
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }
    }
}
