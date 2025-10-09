using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    /// <summary>
    /// Handles everything related to orders in the application.
    /// Used to get existing orders and to save new ones.
    /// </summary>
    public interface IOrdersApplication
    {
        List<string> GetAllOrders();
        void SaveOrder(Item item);

    }
}
