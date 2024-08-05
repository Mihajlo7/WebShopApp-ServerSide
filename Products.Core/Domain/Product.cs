using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Products.Core.Domain
{
    public class Product : IEntity
    {
        public string Name { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public SizeUnitOfMeasure Size {  get; set; }
        public WeightUnitOfMeasure Weight { get; set; }
        public string Class {  get; set; }
        public string Style { get; set; }

        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
