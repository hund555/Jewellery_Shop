using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IFileRepository _fileRepository;
        public OrdersService()
        {
            _fileRepository = FileRepository.GetInstance();
        }

        public List<string> GetAllOrders()
        {
            return _fileRepository.GetAllOrders();
        }

        public void SaveOrder(Item item)
        {
            _fileRepository.SaveOrder(item);
        }
    }
}
