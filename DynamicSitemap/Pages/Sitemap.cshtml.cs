using DynamicSitemap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicSitemap.Pages
{
    public class SitemapModel : PageModel
    {

        public List<Test> TestItems { get; set; }

        public void OnGet()
        {
            // You Can Get Data From Database
            TestItems = new List<Test>();
        }
    }
}
