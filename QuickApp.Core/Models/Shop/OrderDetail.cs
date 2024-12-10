
namespace QuickApp.Core.Models.Shop
{
    public class OrderDetail : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public int ProductId { get; set; }
        public required Product Product { get; set; }

        public int OrderId { get; set; }
        public required Order Order { get; set; }
    }
}
