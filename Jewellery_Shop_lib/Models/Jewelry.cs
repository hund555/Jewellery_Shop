namespace Jewellery_Shop_lib.Models
{
    public class Jewelry : Item
    {
        public override int Id { get; set; }
        public override string Description { get; set; }
        public override double Price { get; set; }

        public Jewelry(int Id, string Description, double Price)
        {
            this.Id = Id;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
