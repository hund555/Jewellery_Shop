using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Services.Service_Interfaces
{
    public interface IOrdersService
    {
        List<string> GetAllOrders();
        void SaveOrder(Item item);

    }
}
