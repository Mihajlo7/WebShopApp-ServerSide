using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Products.Core.Domain
{
    public class SubCategory : IEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
