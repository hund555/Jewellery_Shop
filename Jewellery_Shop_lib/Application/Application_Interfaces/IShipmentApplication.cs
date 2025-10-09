using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    /// <summary>
    /// Handles everything related to shipment in the application.
    /// Used to show available shipment options and to add shipment details to an item.
    /// </summary>
    public interface IShipmentApplication
    {
        List<string> GetShipmentInfoList();
        Item AddShipment(Item item, int shipmentID);
    }
}
