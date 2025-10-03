using Jewellery_Shop_lib.Models;

namespace Jewellery_Shop_lib.DAL
{
    public class FileRepository : IFileRepository
    {
        private List<Jewelry> _jevelry_Items;
        private const string JEWELRY_FILE = "Jewelry.txt";
        private const string GIFTWRAPPING_FILE = "GiftWrapping.txt";
        private const string SHIPMENT_FILE = "Shipment.txt";
        private const string ORDER_FILE = "Orders.txt";

        public List<Jewelry> GetAllJewelry()
        {
            _jevelry_Items = new List<Jewelry>();
            if(File.Exists(JEWELRY_FILE))
            {
                using(StringReader sr = new StringReader(JEWELRY_FILE))
                { 
                    while(sr.Peek() >= 0)
                    {
                        string[] data = sr.ReadLine().Split('|');

                        _jevelry_Items.Add(new Jewelry(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2])));
                    }
                }
            }
            return _jevelry_Items;
        }

        public List<string> GetAllOrders()
        {
            
        }

        public string GetGiftWrappingInfo(int giftWrappingId)
        {
            
        }

        public Jewelry GetJewelryItem(int jewelryId)
        {
            
        }

        public string GetShipmentInfo(int shipmentId)
        {
            
        }

        public void saveOrder(Item item)
        {
            
        }
    }
}
