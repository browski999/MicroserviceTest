namespace Product.Microservices.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public decimal BuyingPrice { get; set; }
        public string ConfidentialData { get; set; }
        public string SKU { get; set; }
        public int Age { get; set; }
    }
}
