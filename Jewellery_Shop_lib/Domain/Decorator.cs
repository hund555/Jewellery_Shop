namespace Jewellery_Shop_lib.Domain
{
    /// <summary>
    /// Base class for all decorators.
    /// It holds a reference to an Item and allows subclasses to extend or modify its behavior without changing the original class.
    /// </summary>
    public abstract class Decorator : Item
    {
        protected readonly Item _item; // The wrapped item that this decorator adds functionality to.

        /// <summary>
        /// Creates a new decorator that wraps an existing item.
        /// </summary>
        /// <param name="item">The item being decorated.</param>
        public Decorator(Item item)
        {
            _item = item;
        }
    }
}
