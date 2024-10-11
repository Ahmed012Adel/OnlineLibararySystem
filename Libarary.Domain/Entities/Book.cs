using Libarary.Domain.Common;

namespace Libarary.Domain.Entities
{

    public class Book : BaseEntity
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string ISBN { get; set; }
        public required int Quantity { get; set; }
        public required int AvailableQuantity { get; set; }
    }
}
