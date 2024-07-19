using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalValidator
{
    public interface IGlobalValidationHandler
    {
        public void Validate<T>(T value) where T : class; 
        public IGlobalValidationHandler SetValidator<T>(T value) where T : class;
    }
}
