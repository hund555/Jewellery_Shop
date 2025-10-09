using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.Domain.Decorators;

namespace Jewellery_Shop_lib.Interface_Adapter
{
    /// <summary>
    /// Handles conversion and creation of gift wrapping data between text files and domain objects.
    /// Used to read gift wrapping info and apply the selected wrapping to an item.
    /// </summary>
    public class GiftWrappingAdapter
    {

        /// <summary>
        /// Converts the lines from the .txt file into a list of gift wrapping options.
        /// </summary>
        /// <param name="lines">The lines read from the GiftWrapping.txt file.</param>
        /// <returns>A list of strings for the available gift wrapping options.</returns>
        public List<string> ConvertToGiftWrappingList(List<string> giftWrapLines)
        {
            return giftWrapLines;
        }

        /// <summary>
        /// Creates a new item with the selected gift wrapping applied.
        /// </summary>
        /// <param name="item">The item to be wrapped.</param>
        /// <param name="giftWrappingOptions">All available gift wrapping options.</param>
        /// <param name="giftWrappingId">The ID of the gift wrapping to apply.</param>
        /// <returns>A new <see cref="Item"/> with gift wrapping added, or the original item if not found.</returns>
        public Item CreateGiftWrappedItem(Item item, List<string> giftWrappingOptions, int giftWrappingId)
        {
            var chosenLine = giftWrappingOptions.FirstOrDefault(g => Convert.ToInt32(g.Split("|")[0]) == giftWrappingId);
            if (chosenLine == null) return item;

            var splitLines = chosenLine.Split("|");
            return new GiftWrapping(item, giftWrappingId, splitLines[1], Convert.ToDouble(splitLines[2]));
        }
    }
}
