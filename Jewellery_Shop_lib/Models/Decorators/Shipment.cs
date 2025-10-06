namespace Jewellery_Shop_lib.Models.Decorators
{
    public class Shipment : Decorator
    {
        public override int Id { get; set; }

        private string description;
        public override string Description
        {
            get { return $"{_item.Description}. shipment: ID:{this.Id} Desc: {description}"; }
            set { description = value; }
        }

        private double price;
        public override double Price
        {
            get { return _item.Price + this.price; }
            set { price = value; }
        }

        public Shipment(Item item, int shipmentID, string shipmentDescription, double shipmentPrice) : base(item)
        {
            Id = shipmentID;
            Description = shipmentDescription;
            Price = shipmentPrice;
        }
    }
}
