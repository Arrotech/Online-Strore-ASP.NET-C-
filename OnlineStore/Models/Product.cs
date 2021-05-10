using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public static Product GetProduct()
        {
            Product product = new Product() {ProductId=1, ProductName="Official Boots", ProductDescription="Latest official boots now available", ProductImage= "https://www.bing.com/images/search?view=detailV2&ccid=re9diHSP&id=DC500A3D1FAC6403A827850A1BFDA671F37A31CD&thid=OIP.re9diHSP3eRhlfaI9J1wuAHaD4&mediaurl=https%3A%2F%2Fcdna.lystit.com%2F1200%2F630%2Ftr%2Fphotos%2Ffarfetch%2F140e73a9%2Fburberry-yellow-The-1983-Check-Link-Loafer.jpeg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FRadef5d88748fdde46195f688f49d70b8%3Frik%3DzTF683Gm%2FRsKhQ&pid=ImgRaw&exph=630&expw=1200&q=loafers+images+links&simid=608026846468506288&ck=28537E4A1D45760A565E9E0FF8E936B1&selectedindex=64&form=EX0023&adlt=demote&shtp=GetUrl&shid=4864688e-ee6d-411a-a4eb-e21f65fcefc5&shtk=QnVyYmVycnkgTGVhdGhlciBUaGUgMTk4MyBDaGVjayBMaW5rIExvYWZlciBpbiBZZWxsb3cgZm9yIC4uLg%3D%3D&shdk=Rm91bmQgb24gQmluZyBmcm9tIHd3dy5seXN0LmNvLnVr&shhk=YEwlE7igyVf%2B6aTC1b14%2FilnSEbZQRq6MrRT%2Bp01eD4%3D&shth=OSH.yBo68WVFVKBK1nnwA4u%252FEg", ProductPrice =259, OrderId =1, Quantity=20 };
            return product;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId = 1, ProductName = "Official Boots", ProductDescription="Latest official boots now available", ProductImage= "https://www.bing.com/images/search?view=detailV2&ccid=6muolWit&id=C6470227245D0931211B42B8CF0C940EC8D96FF9&thid=OIP.6muolWitKtbW9f-DxdSLPQHaJ4&mediaurl=https%3A%2F%2Fi.pinimg.com%2F736x%2F16%2F4a%2F3b%2F164a3b77ad45d48ad043c120b89229f1.jpg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FRea6ba89568ad2ad6d6f5ff83c5d48b3d%3Frik%3D%2BW%2FZyA6UDM%2B4Qg&pid=ImgRaw&exph=981&expw=735&q=official+boots+images+links&simid=608055635633984503&ck=18F6438E6AE03A33602E5A1534D8ACB6&selectedindex=0&form=EX0023&adlt=demote&shtp=GetUrl&shid=aa915157-18a7-4d72-b308-8d2cfe41f658&shtk=TGluayBEZXRhaWwgTGVhdGhlciBMYWNlLXVwIEFua2xlIEJvb3RzIHwgQm9vdHMsIFN1ZWRlIC4uLg%3D%3D&shdk=Rm91bmQgb24gQmluZyBmcm9tIHd3dy5waW50ZXJlc3QuY29t&shhk=HkSw8TewmEehoQQ3S7chUb1M6mHA2kjIyNXMzdlwVP0%3D&shth=OSH.BO6P%252BGNzt7XZiTKnO9hIpA", ProductPrice=2500, OrderId = 2, Quantity = 20 },
                new Product() { ProductId = 2, ProductName = "Loafers", ProductDescription="Loafers available in all colors and sizes", ProductImage= "https://www.bing.com/images/search?view=detailV2&ccid=re9diHSP&id=DC500A3D1FAC6403A827850A1BFDA671F37A31CD&thid=OIP.re9diHSP3eRhlfaI9J1wuAHaD4&mediaurl=https%3A%2F%2Fcdna.lystit.com%2F1200%2F630%2Ftr%2Fphotos%2Ffarfetch%2F140e73a9%2Fburberry-yellow-The-1983-Check-Link-Loafer.jpeg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FRadef5d88748fdde46195f688f49d70b8%3Frik%3DzTF683Gm%2FRsKhQ&pid=ImgRaw&exph=630&expw=1200&q=loafers+images+links&simid=608026846468506288&ck=28537E4A1D45760A565E9E0FF8E936B1&selectedindex=64&form=EX0023&adlt=demote&shtp=GetUrl&shid=4864688e-ee6d-411a-a4eb-e21f65fcefc5&shtk=QnVyYmVycnkgTGVhdGhlciBUaGUgMTk4MyBDaGVjayBMaW5rIExvYWZlciBpbiBZZWxsb3cgZm9yIC4uLg%3D%3D&shdk=Rm91bmQgb24gQmluZyBmcm9tIHd3dy5seXN0LmNvLnVr&shhk=YEwlE7igyVf%2B6aTC1b14%2FilnSEbZQRq6MrRT%2Bp01eD4%3D&shth=OSH.yBo68WVFVKBK1nnwA4u%252FEg", ProductPrice=1590, OrderId = 2, Quantity = 100 },
                new Product() { ProductId = 3, ProductName = "Supra", ProductDescription="Supras storming the market with new design", ProductImage= "https://www.bing.com/images/search?view=detailV2&ccid=awJvjSjz&id=46DC645A34A2112C0C4378377D70F2FD5D55814B&thid=OIP.awJvjSjzrrKQD9xDb8SYVQHaHa&mediaurl=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F2e%2F72%2Fb5%2F2e72b59bbfc8db35e35103ef387a1b35.jpg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR6b026f8d28f3aeb2900fdc436fc49855%3Frik%3DS4FVXf3ycH03eA&pid=ImgRaw&exph=500&expw=500&q=supras+shoes+images+links&simid=608036213788783506&ck=72DB76376D4F18E231902DCD89FED87C&selectedindex=0&form=EX0023&adlt=demote&shtp=GetUrl&shid=e3a9bdda-2481-41f9-902e-5393ced8cd5b&shtk=U2hvZXMgU1VQUkEgUzFXIEJMQUNLIC8gTkFWWSAtIFdISVRFIFNUQVIgUFJJTlQgLi4u&shdk=Rm91bmQgb24gQmluZyBmcm9tIHd3dy5waW50ZXJlc3QuY29t&shhk=mIN7%2BXUQmatN1RAoJTJagVCJFrVaX%2FdZyYKOhDhNULM%3D&shth=OSH.kY6fBhuglS%252BZgcZ6mzAoRQ", ProductPrice=4599, OrderId = 2, Quantity = 50 }
            };
            return products;
        }
    }
}
