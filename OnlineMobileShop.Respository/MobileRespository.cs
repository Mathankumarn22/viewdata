using System.Collections.Generic;
using OnlineMobileShop.Entity;

namespace OnlineMobileShop.Respository
{
    public class MobileRespository
    {
        public static List<Mobile> mobile = new List<Entity.Mobile>();

        static MobileRespository()
        {
            mobile.Add(new Mobile { MobileID = 1, Brand = "Nokia", Model = "y22", Battery = 3000, Price = 6000 });

            mobile.Add(new Mobile { MobileID = 2, Brand = "Vivo", Model = "v5", Battery = 4000, Price = 8000 });

            mobile.Add(new Mobile { MobileID = 3, Brand = "Oppo", Model = "f1", Battery = 5000, Price = 11000 });
        }
        public static IEnumerable<Mobile> GetDetails()
        {
            return mobile;
        }
    }
}

