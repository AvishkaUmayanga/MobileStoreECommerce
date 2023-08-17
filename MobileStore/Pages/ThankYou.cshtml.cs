using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MobileStore.Model;

namespace MobileStore.Pages
{
    [BindProperties(SupportsGet =true)]
    public class ThankYouModel : PageModel
    {
        public String MobileName { get; set; }
        public String ImageName { get; set; }

        public void OnGet()
        {
        }
    }
}
