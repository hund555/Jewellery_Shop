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
            List<string> orders = new List<string>();
            if (File.Exists(ORDER_FILE))
            {
                using (StringReader sr = new StringReader(ORDER_FILE))
                {
                    while (sr.Peek() >= 0)
                    {
                        orders.Add(sr.ReadLine());
                    }
                }
            }
            return orders;
        }

        public List<string> GetGiftWrappingInfo()
        {
            List<string> giftWrappingInfoList = new List<string>();
            if (File.Exists(GIFTWRAPPING_FILE))
            {
                using (StringReader sr = new StringReader(GIFTWRAPPING_FILE))
                {
                    while (sr.Peek() >= 0)
                    {
                        giftWrappingInfoList.Add(sr.ReadLine());
                    }
                }
            }
            return giftWrappingInfoList;
        }

        public Jewelry GetJewelryItem(int jewelryId)
        {
            if(_jevelry_Items == null)
            {
                GetAllJewelry();
            }
            return _jevelry_Items.Find(j => j.Id == jewelryId);
        }

        public List<string> GetShipmentInfo()
        {
            List<string> shippingInfoList = new List<string>();
            if (File.Exists(SHIPMENT_FILE))
            {
                using (StringReader sr = new StringReader(SHIPMENT_FILE))
                {
                    while (sr.Peek() >= 0)
                    {
                        shippingInfoList.Add(sr.ReadLine());
                    }
                }
            }
            return shippingInfoList;
        }

        public void saveOrder(Item item)
        {
            List<string> ordersList = GetAllOrders();
            if (!File.Exists(ORDER_FILE))
            {
                File.Create(ORDER_FILE);
            }
            string order = $"{item.Id}|{item.Description}|{item.Price}";
            ordersList.Add(order);
            File.WriteAllLines(ORDER_FILE, ordersList);
        }
    }
}
