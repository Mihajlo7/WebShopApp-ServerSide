using System.Runtime.CompilerServices;

namespace GlobalValidator
{
    public class GlobalValidationHandler : IGlobalValidationHandler
    {
        private readonly Dictionary<Type, object> _validators= new Dictionary<Type, object>();

        public IGlobalValidationHandler SetValidator<T>(T value) where T : class
        {
            var type= typeof(T);
            if (!_validators.ContainsKey(type))
            {
                
            }
            return null;
        }

        public void Validate<T>(T value) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
