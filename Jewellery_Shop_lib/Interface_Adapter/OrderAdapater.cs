using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Interface_Adapter
{
    /// <summary>
    /// Handles conversion between order data and text file format.
    /// Used to read orders from files and convert items into text lines for saving.
    /// </summary>
    public class OrderAdapater
    {
        /// <summary>
        /// Converts a list of .txt lines from the orders file into a list of string.
        /// </summary>
        /// <param name="getOrdersLines">The lines read from Orders.txt.</param>
        /// <returns>A list of strings for all saved orders.</returns>
        public List<string> ConvertToOrderList(List<string> getOrdersLines)
        {
            return getOrdersLines;
        }

        /// <summary>
        /// Converts an order item into a textline to be stored in the orders file.
        /// </summary>
        /// <param name="item">The item to convert.</param>
        /// <returns>A formatted text line representing the order.</returns>
        public string ConvertOrderToLine(Item item)
        {
            return $"{item.Id}|{item.Description}|{item.Price}";
        }

    }
}
