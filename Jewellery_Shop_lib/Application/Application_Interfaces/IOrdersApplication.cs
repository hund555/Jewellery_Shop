using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    public interface IOrdersApplication
    {
        List<string> GetAllOrders();
        void SaveOrder(Item item);

    }
}
