using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Common.Library
{
    public static class ModelState
    {
        public static List<string> ErrorMessages = new List<string>();

        public static bool IsValid<T>(T model)
        {
            

            TypeDescriptor.AddProviderTransparent(
               new AssociatedMetadataTypeTypeDescriptionProvider(model.GetType()), model.GetType());

            var validationContext = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            var success = Validator.TryValidateObject(model, validationContext, results, true);

            if (success)
            {
                return true;
            }
            else
            {
                ErrorMessages = results.Select(x => x.ErrorMessage).ToList();
                return false;
            }
        }

        
    }
}
