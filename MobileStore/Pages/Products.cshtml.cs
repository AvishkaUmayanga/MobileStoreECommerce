using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MobileStore.Model;

namespace MobileStore.Pages
{
    public class ProductsModel : PageModel
    {
        public List<MobileModel> MobileModels = new List<MobileModel>() {
            new MobileModel() { MobileName = "iphone 13 pro max", ImageName = "iphone13promax", MoblePrice = 1099 },
            new MobileModel() { MobileName = "iphone 12 pro max", ImageName = "iphone12promax", MoblePrice = 990 },
            new MobileModel() { MobileName = "iphone 11 pro max", ImageName = "iphone11promax", MoblePrice = 860 },
            new MobileModel() { MobileName = "Google pixel 7 pro", ImageName = "Googlepixel7pro", MoblePrice = 899 },
            new MobileModel() { MobileName = "Google Pixel 7", ImageName = "GooglePixel7", MoblePrice = 500 },
            new MobileModel() { MobileName = "Google pixel 6 pro", ImageName = "Googlepixel6pro", MoblePrice = 440 },
            new MobileModel() { MobileName = "redmi note 12", ImageName = "redminote12", MoblePrice = 235 },
            new MobileModel() { MobileName = "xiaomi redmi note 12s", ImageName = "xiaomiredminote12s", MoblePrice = 259 },
            new MobileModel() { MobileName = "Redmi A2 Plus", ImageName = "RedmiA2Plus", MoblePrice = 110 }
        };
        public void OnGet()
        {
           
        }
    }
}
