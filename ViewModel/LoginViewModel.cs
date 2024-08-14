using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyVegieStore.Model;

namespace MyVegieStore.ViewModel
{
    public class LoginViewModel
    {
        private readonly MyVegieStoreContext _context;

        public string Username { get; set; }
        public string Password { get; set; }
        public string PopupMessage { get; set; }

        public LoginViewModel(MyVegieStoreContext context)
        {
            _context = context;
        }

        public async Task<bool> LoginAsync()
        {
            // Search for the user in the Person table asynchronously
            var user = await _context.Person
                .Where(p => p.Email == Username && p.Password == Password)
                .FirstOrDefaultAsync();

            if (user != null)
            {
                PopupMessage = "Login successful!";
                return true;
            }
            else
            {
                PopupMessage = "Invalid username or password.";
                return false;
            }
        }
    }
}
