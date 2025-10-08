namespace Jewellery_Shop_lib.Domain
{
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

        public Jewelry(int Id, string Description, double Price)
        {
            this.Id = Id;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
