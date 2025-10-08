using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.Domain.Decorators;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    public class GiftWrappingService : IGriftWrapService
    {
        private IFileRepository _fileRepository;

        public GiftWrappingService()
        {
            _fileRepository = FileRepository.GetInstance();
        }
        public Item AddGiftWrapping(Item item, int giftWrappingID)
        {
            List<string> giftWrppings = _fileRepository.GetGiftWrappingInfo();
            string[] chosenGiftWrapping = giftWrppings.FirstOrDefault(g => Convert.ToInt32(g.Split("|")[0]) == giftWrappingID).Split("|");
            if (chosenGiftWrapping != null)
            {
                item = new GiftWrapping(item, giftWrappingID, chosenGiftWrapping[1], Convert.ToDouble(chosenGiftWrapping[2]));
            }
            
            return item;
        }

        public List<string> GetGiftWrappingInfoList()
        {
            return _fileRepository.GetGiftWrappingInfo();
        }
    }
}
