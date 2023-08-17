using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MobileStore.Model;

namespace MobileStore.Pages
{
    public class CreateOrderModel : PageModel
    {
        [BindProperty]
        public MobileModel Mobile { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            return RedirectToPage("/ThankYou",new { Mobile.ImageName,Mobile.MobileName});
        }
    }
}
