namespace Jewellery_Shop_lib.Models.Decorators
{
    public class Shipment : Decorator
    {
        public override int Id { get; set; }
        public override string Description { get; set; }
        public override double Price { get; set; }

        public Shipment(Item item, int shipmentID, string shipmentDescription, double shipmentPrice) : base(item)
        {
            Id = shipmentID;
            Description = shipmentDescription;
            Price = shipmentPrice;
        }
    }
}
