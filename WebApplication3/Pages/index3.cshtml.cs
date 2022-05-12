using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;

namespace WebApplication3.Pages
{
    public class index3Model : PageModel
    {
        [BindProperty]
        public Modelss modelss { get; set; }
        public IActionResult OnPost()
        {
            
            return RedirectToPage("/checkout/Index6", new { modelss.howard});
        }
    }
}
