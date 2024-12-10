
namespace QuickApp.Core.Models.Shop
{
    public class ProductCategory : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }

        public ICollection<Product> Products { get; } = [];
    }
}
