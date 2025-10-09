namespace Jewellery_Shop_lib.Domain.Decorators
{
    /// <summary>
    /// A decorator that adds shipment details to an existing item.
    /// It extends the Decorator class and updates both description and price 
    /// to include the shipment information.
    /// </summary>
    public class Shipment : Decorator
    {
        /// <summary>
        /// The ID for this shipment option.
        /// </summary>
        public override int Id { get; set; }

        private string description;

        /// <summary>
        /// Combines the original item description with the shipment info.
        /// </summary>
        public override string Description
        {
            get { return $"{_item.Description}. shipment: ID:{this.Id} Desc: {description}"; } // Add shipment details to the base item description
            set { description = value; } // Store the shipment description
        }

        private double price;

        /// <summary>
        /// Calculates the total price including the shipment cost.
        /// </summary>
        public override double Price
        {
            get { return _item.Price + this.price; }
            set { price = value; }
        }

        /// <summary>
        /// Creates a new shipment decorator around the given item.
        /// </summary>
        /// <param name="item">The item being shipped.</param>
        /// <param name="shipmentID">ID of the shipment type.</param>
        /// <param name="shipmentDescription">Text describing the shipment option.</param>
        /// <param name="shipmentPrice">Extra price for the shipment.</param>
        public Shipment(Item item, int shipmentID, string shipmentDescription, double shipmentPrice) : base(item)
        {
            Id = shipmentID;
            Description = shipmentDescription;
            Price = shipmentPrice;
        }
    }
}
