using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    public interface IJewelryApplication
    {
        List<Jewelry> GetAllJewelryItems();
        Item GetJewelryItem(int jewelryId);
    }
}
