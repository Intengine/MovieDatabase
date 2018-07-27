using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntengineMovie.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Skontaktuj się z nami";
        }
    }
}