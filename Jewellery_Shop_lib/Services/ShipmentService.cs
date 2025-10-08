using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.Domain.Decorators;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    public class ShipmentService : IShipmentService
    {
        private IFileRepository _fileRepository;
        public ShipmentService()
        {
            _fileRepository = FileRepository.GetInstance();
        }

        public Item AddShipment(Item item, int shipmentID)
        {
            List<string> shipments = _fileRepository.GetShipmentInfo();
            string[] chosenShipment = shipments.FirstOrDefault(s => Convert.ToInt32(s.Split("|")[0]) == shipmentID).Split("|");
            if (chosenShipment != null)
            {
                item = new Shipment(item, shipmentID, chosenShipment[1], Convert.ToDouble(chosenShipment[2]));
            }
            return item;
        }

        public List<string> GetShipmentInfoList()
        {
            return _fileRepository.GetShipmentInfo();
        }
    }
}
