namespace Jewellery_Shop_lib.Domain.Decorators
{
    /// <summary>
    /// 
    /// </summary>
    public class GiftWrapping : Decorator
    {
        public override int Id { get; set; }
        
        private string description;
        public override string Description
        {
            get { return $"{_item.Description}. Giftwrapping: ID:{this.Id} Desc: {description}"; }
            set { description = value; }
        }

        private double price;
        public override double Price
        {
            get { return _item.Price + this.price; }
            set { price = value; }
        }

        public GiftWrapping(Item item, int giftWrappingID, string giftWrappingDescription, double giftWrappingPrice) : base(item)
        {
            Id = giftWrappingID;
            Description = giftWrappingDescription;
            Price = giftWrappingPrice;
        }
    }
}
