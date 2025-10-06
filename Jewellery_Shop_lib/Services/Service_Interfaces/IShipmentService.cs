using Jewellery_Shop_lib.Models;

namespace Jewellery_Shop_lib.Services.Service_Interfaces
{
    public interface IShipmentService
    {
        List<string> GetShipmentInfoList();
        Item AddShipment(Item item, int shipmentID);
    }
}
