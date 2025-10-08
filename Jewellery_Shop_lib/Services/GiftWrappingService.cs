using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.Domain.Decorators;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    public class GiftWrappingService : IGriftWrapService
    {
        private readonly IFileRepository _fileRepository;

        public GiftWrappingService()
        {
            _fileRepository = FileRepository.GetInstance();
        }

        /// <summary>
        /// Adds gift wrapping to the specified item using the provided gift wrapping ID.
        /// </summary>
        /// <remarks>This method retrieves gift wrapping information from an external repository and
        /// applies the selected  gift wrapping to the item. The gift wrapping includes details such as its description and
        /// additional cost.</remarks>
        /// <param name="item">The item to which gift wrapping will be added.</param>
        /// <param name="giftWrappingID">The unique identifier of the gift wrapping option to apply.</param>
        /// <returns>A new <see cref="Item"/> instance with the selected gift wrapping applied.  If the specified gift wrapping
        /// ID is not found, the original item is returned unchanged.</returns>
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

        /// <summary>
        /// Retrieves a list of gift wrapping information.
        /// </summary>
        /// <returns>A list of strings containing gift wrapping details. The list will be empty if no gift wrapping information
        /// is available.</returns>
        public List<string> GetGiftWrappingInfoList()
        {
            return _fileRepository.GetGiftWrappingInfo();
        }
    }
}
