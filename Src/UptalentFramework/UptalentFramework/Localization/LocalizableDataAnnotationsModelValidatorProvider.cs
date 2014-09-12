using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace UptalentFramework.Localization
{
    public class LocalizableDataAnnotationsModelValidatorProvider : DataAnnotationsModelValidatorProvider
    {
        public LocalizableDataAnnotationsModelValidatorProvider()
            : base()
        {
        }

        protected override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context, IEnumerable<Attribute> attributes)
        {
            var validators = base.GetValidators(metadata, context, attributes);
            var result = new List<LocalizableDataAnnotationsModelValidator>();
            foreach (var validator in validators)
            {
                result.Add(new LocalizableDataAnnotationsModelValidator(validator, metadata, context));
            }
            return result;
        }
    }
}