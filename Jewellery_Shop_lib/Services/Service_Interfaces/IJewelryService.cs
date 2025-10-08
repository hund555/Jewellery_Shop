using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Services.Service_Interfaces
{
    public interface IJewelryService
    {
        List<Jewelry> GetAllJewelryItems();
        Item GetJewelryItem(int jewelryId);
    }
}
