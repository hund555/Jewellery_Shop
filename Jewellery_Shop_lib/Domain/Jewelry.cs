namespace Jewellery_Shop_lib.Domain
{
    /// <summary>
    /// Represents a concrete item in the jewellery shop.
    /// This class implements the base Item and defines its own ID, description, and price.
    /// </summary>
    public class Jewelry : Item
    {
        public override int Id { get; set; }

        private string description;
        public override string Description
        {
            get { return $"{description}."; }
            set { description = value; }
        }

        private double price;
        public override double Price
        {
            get { return this.price; }
            set { price = value; }
        }

        /// <summary>
        /// Creates a new jewelry item with the given details.
        /// </summary>
        /// <param name="Id">Unique ID of the jewelry item.</param>
        /// <param name="Description">Text describing the item.</param>
        /// <param name="Price">Price of the item.</param>
        public Jewelry(int Id, string Description, double Price)
        {
            this.Id = Id;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
