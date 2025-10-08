using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.File_service
{
    public interface IFileRepository
    {
        List<Jewelry> GetAllJewelry();
        Jewelry GetJewelryItem(int jewelryId);
        List<string> GetShipmentInfo();
        List<string> GetGiftWrappingInfo();
        //Saves orders to a file
        void saveOrder(Item item);
        List<string> GetAllOrders();
    }
}
