using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    /// <summary>
    /// Handles everything related to jewelry in the application.
    /// Used to get all available jewelry items or a specific one by ID.
    /// </summary>
    public interface IJewelryApplication
    {
        List<Jewelry> GetAllJewelryItems();
        Item GetJewelryItem(int jewelryId);
    }
}
