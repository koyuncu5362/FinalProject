using Entites.Abstract;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProcutId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}