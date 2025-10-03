using Jewellery_Shop_lib.Models;

namespace Jewellery_Shop_lib.DAL
{
    public interface IFileRepository
    {
        List<Jewelry> GetAllJewelry();
        Jewelry GetJewelryItem(int jewelryId);
        string GetShipmentInfo(int shipmentId);
        string GetGiftWrappingInfo(int giftWrappingId);
        //Saves orders to a file
        void saveOrder(Item item);
        List<string> GetAllOrders();
    }
}
