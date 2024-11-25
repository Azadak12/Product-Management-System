using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using YourNamespace.Models;  // Import your model namespace
using YourNamespace.Data;    // Import your data access context

namespace YourNamespace.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly YourDbContext _context;

        public IndexModel(YourDbContext context)
        {
            _context = context;
        }

        // Property to hold the list of clients
        public IList<Client> Clients { get; set; }

        // OnPageLoad method to load the clients from the database
        public void OnGet()
        {
            Clients = _context.Clients.ToList();
        }
    }
}
