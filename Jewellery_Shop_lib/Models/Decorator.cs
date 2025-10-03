namespace Jewellery_Shop_lib.Models
{
    public abstract class Decorator : Item
    {
        protected readonly Item _item;

        public Decorator(Item item)
        {
            _item = item;
        }
    }
}
