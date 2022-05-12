using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    [BindProperties(SupportsGet = true)]
    public class Index6Model : PageModel
    {
        public double howard { get; set; }
        public void OnGet()
        {
        }
    }
}
