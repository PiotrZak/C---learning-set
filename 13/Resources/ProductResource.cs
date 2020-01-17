using supermarket.Resources;

namespace Supermarket.API.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityInPackage { get; set; }
        public string UnitOfMeasurement { get; set; }
        public SaveCategoryResource Category { get; set; }
    }
}