using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.File_service
{
    /// <summary>
    /// Defines all file operations for the jewellery shop.
    /// Used to read and write data for jewelry, gift wrapping, shipment, and orders.
    /// </summary>
    public interface IFileRepository
    {
        List<string> GetAllJewelry();
        Jewelry GetJewelryItem(int jewelryId);
        List<string> GetShipmentInfo();
        List<string> GetGiftWrappingInfo();
        //Saves orders to a file
        void SaveOrder(Item item);
        List<string> GetAllOrders();
    }
}
