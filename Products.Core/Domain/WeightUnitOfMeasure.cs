using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Products.Core.Domain
{
    public class WeightUnitOfMeasure : IEntity
    {
        public decimal Value { get; set; }
        public string UnitOfMeasure { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
