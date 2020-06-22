using FluentValidation.Results;
using System.Collections.Generic;
namespace Testapp.Validation
{
    public class ValidatedRequest<TRequest>
    {

        public TRequest Value { get; set; }

        /// <summary>
        /// Whether or not the deserialized value was found to be valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// The collection of validation errors.
        /// </summary>
        public IList<ValidationFailure> Errors { get; set; }

    }
}
