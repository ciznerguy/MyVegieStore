using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace YourNamespace.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            using (var client = new HttpClient())
            {
                // Replace with your actual API URL
                string apiUrl = "https://vegiestoreapi20240819183809.azurewebsites.net/api/Products";

                Products = await client.GetFromJsonAsync<List<Product>>(apiUrl);
            }
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Add other properties from your Product model here
    }
}
