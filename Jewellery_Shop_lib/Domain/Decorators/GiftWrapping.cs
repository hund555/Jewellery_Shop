namespace Jewellery_Shop_lib.Domain.Decorators
{
    /// <summary>
    /// A decorator that adds gift wrapping to an existing item.
    /// It extends the Decorator class and updates both description and price to include the wrapping details.
    /// </summary>
    public class GiftWrapping : Decorator
    {
        /// <summary>
        /// The ID for this type of gift wrapping.
        /// </summary>
        public override int Id { get; set; }

        private string description;

        /// <summary>
        /// Combines the original item description with the gift wrapping info.
        /// </summary>
        public override string Description
        {
            get { return $"{_item.Description}. Giftwrapping: ID:{this.Id} Desc: {description}"; } // Add the gift wrapping details to the base item description
            set { description = value; }  // Store the wrapping description
        }

        private double price;

        /// <summary>
        /// Calculates the total price including the gift wrapping.
        /// </summary>
        public override double Price
        {
            get { return _item.Price + this.price; }
            set { price = value; }
        }

        /// <summary>
        /// Creates a new gift wrapping decorator around the given item.
        /// </summary>
        /// <param name="item">The item being wrapped.</param>
        /// <param name="giftWrappingID">ID of the wrapping type.</param>
        /// <param name="giftWrappingDescription">Text describing the wrapping.</param>
        /// <param name="giftWrappingPrice">Extra price for the wrapping.</param>
        public GiftWrapping(Item item, int giftWrappingID, string giftWrappingDescription, double giftWrappingPrice) : base(item)
        {
            Id = giftWrappingID;
            Description = giftWrappingDescription;
            Price = giftWrappingPrice;
        }
    }
}
