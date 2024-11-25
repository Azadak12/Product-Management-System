using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YourNamespace.Models;
using YourNamespace.Data;

namespace YourNamespace.Pages.Clients
{
    public class CreateModel : PageModel
    {
        private readonly YourDbContext _context;

        public CreateModel(YourDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; }

        // Handle the POST request to save the new client
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clients.Add(Client);
            _context.SaveChanges();

            return RedirectToPage("./Index"); // Redirect back to the client list
        }
    }
}
