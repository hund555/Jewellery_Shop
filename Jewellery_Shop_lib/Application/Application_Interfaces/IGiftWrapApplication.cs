using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    /// <summary>
    /// Handles everything related to gift wrapping in the application.
    /// Used to show available wrapping options and to add a wrapping to an item.
    /// </summary>
    public interface IGiftWrapApplication
    {
        List<string> GetGiftWrappingInfoList();
        Item AddGiftWrapping(Item item, int giftWrappingID);
    }
}
