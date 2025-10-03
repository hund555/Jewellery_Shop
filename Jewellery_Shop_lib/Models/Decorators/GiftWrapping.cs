namespace Jewellery_Shop_lib.Models.Decorators
{
    public class GiftWrapping : Decorator
    {
        public override int Id { get; set; }
        public override string Description { get ; set; }
        public override double Price { get; set; }
        
        public GiftWrapping(Item item, int giftWrappingID, string giftWrappingDescription, double giftWrappingPrice) : base(item)
        {
            Id = giftWrappingID;
            Description = giftWrappingDescription;
            Price = giftWrappingPrice;
        }
    }
}
