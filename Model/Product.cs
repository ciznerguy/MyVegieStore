namespace MyVegieStore.Model
{

    public class Product
    {
        public int ProductID { get; set; }  // Primary key
        public string? ProductName { get; set; }
        public double PricePerUnit { get; set; }
        public double StockQuantity { get; set; }
        public string? PricingType { get; set; }

        private string? _image;
        public string Image
        {
            get => string.IsNullOrEmpty(_image) ? "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpixlr.com%2Fimage-generator%2F&psig=AOvVaw3fPGRMWgnSl4krfm1PC7Rp&ust=1723622000687000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCOinyru-8YcDFQAAAAAdAAAAABAE" : _image;
            set => _image = value;
        }


    }

}