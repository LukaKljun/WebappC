using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace CoreWebapp.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo(""));
            ViewData["TimeStamp"] = dateTime;
        } //LUka
    }
}