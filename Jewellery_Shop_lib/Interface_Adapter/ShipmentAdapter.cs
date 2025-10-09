using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.Domain.Decorators;

namespace Jewellery_Shop_lib.Interface_Adapter
{
    /// <summary>
    /// Handles conversion and creation of shipment data between text files and domain objects.
    /// Used to read shipment information and apply the selected shipment option to an item.
    /// </summary>
    public class ShipmentAdapter
    {
        /// <summary>
        /// Converts lines from the .txt file into a list of shipment options.
        /// </summary>
        /// <param name="getShipmentLines">The lines read from Shipment.txt.</param>
        /// <returns>A list of strings of available shipment options.</returns>
        public List<string> ConvertToShipmentList(List<string> getShipmentLines)
        {
            return getShipmentLines;
        }

        /// <summary>
        /// Creates a new item with the selected shipment details applied.
        /// </summary>
        /// <param name="item">The item to which shipment will be added.</param>
        /// <param name="shipmentLines">All available shipment options as strings.</param>
        /// <param name="shipmentId">The ID of the shipment option to be applied.</param>
        /// <returns>A new <see cref="Item"/> with shipment added, or the original item if no match is found.</returns>
        public Item CreateShipmentItem(Item item, List<string> shipmentLines, int shipmentId)
        {
            var chosenLine = shipmentLines.FirstOrDefault(s => Convert.ToInt32(s.Split("|")[0]) == shipmentId);
            if (chosenLine == null) return item;

            var parts = chosenLine.Split("|");
            return new Shipment(item, shipmentId, parts[1], Convert.ToDouble(parts[2])); ;
        }
    }
}
