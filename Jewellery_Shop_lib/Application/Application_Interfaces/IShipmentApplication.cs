using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    public interface IShipmentApplication
    {
        List<string> GetShipmentInfoList();
        Item AddShipment(Item item, int shipmentID);
    }
}
