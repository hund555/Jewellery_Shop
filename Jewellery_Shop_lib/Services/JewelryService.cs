using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    internal class JewelryService : IJewelryService
    {
        private IFileRepository _fileRepository;
        public JewelryService()
        {
            _fileRepository = FileRepository.GetInstance();
        }

        public List<Jewelry> GetAllJewelryItems()
        {
            return _fileRepository.GetAllJewelry();
        }
    }
}
