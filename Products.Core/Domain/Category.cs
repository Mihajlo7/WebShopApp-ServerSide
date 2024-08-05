using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace Products.Core.Domain
{
    public class Category : IEntity
    {
        public string Name { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
