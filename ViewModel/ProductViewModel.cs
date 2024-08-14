using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyVegieStore.Model;

namespace MyVegieStore.ViewModel
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "Product name is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price per unit is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price per unit must be greater than zero.")]
        public double PricePerUnit { get; set; }

        [Required(ErrorMessage = "Stock quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be a non-negative number.")]
        public double StockQuantity { get; set; }

        [Required(ErrorMessage = "Pricing type is required.")]
        public string PricingType { get; set; }

        public IFormFile ImageFile { get; set; }  // Property to hold the uploaded image file

        public string Image { get; set; }

        // Method to convert ViewModel to Model
        public Product ToProduct(string imagePath)
        {
            return new Product
            {
                ProductName = this.ProductName,
                PricePerUnit = this.PricePerUnit,
                StockQuantity = this.StockQuantity,
                PricingType = this.PricingType,
                Image = imagePath // Save the image path to the product
            };
        }

        // Method to populate ViewModel from Model
        public static ProductViewModel FromProduct(Product product)
        {
            return new ProductViewModel
            {
                ProductName = product.ProductName,
                PricePerUnit = product.PricePerUnit,
                StockQuantity = product.StockQuantity,
                PricingType = product.PricingType,
                Image = product.Image
            };
        }
    }
}
