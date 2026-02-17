using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty]
        public UserInput Input {get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            return RedirectToPage("Test");
        }
    }
}
