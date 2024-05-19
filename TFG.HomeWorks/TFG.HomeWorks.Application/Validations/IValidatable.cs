using FluentValidation;
using FluentValidation.Results;

namespace TFG.HomeWorks.Application.Validations
{
    /// <summary>
    /// Define un objeto como validable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class DtoValidatable<T> : IValidator<T>
    {
        private readonly Lazy<IValidator<T>> _validator;

        protected DtoValidatable()
        {
            _validator = new(BuildValidator);
        }

        private IValidator<T> BuildValidator()
        {
            var validator = new InlineValidator<T>();
            Configure(validator);
            return validator;
        }

        /// <summary>
        /// Configura una instancia de <see cref="IValidator{T}"/> para validar una instancia del objeto de tipo <typeparamref name="T"/>
        /// </summary>
        /// <returns></returns>
        public abstract void Configure(InlineValidator<T> validator);

        public bool CanValidateInstancesOfType(Type type) => _validator.Value.CanValidateInstancesOfType(type);

        public IValidatorDescriptor CreateDescriptor() => _validator.Value.CreateDescriptor();

        public ValidationResult Validate(T instance) => _validator.Value.Validate(instance);

        public ValidationResult Validate(IValidationContext context) => _validator.Value.Validate(context);

        public Task<ValidationResult> ValidateAsync(T instance, CancellationToken cancellation = default) => _validator.Value.ValidateAsync(instance, cancellation);

        public Task<ValidationResult> ValidateAsync(IValidationContext context, CancellationToken cancellation = default) => _validator.Value.ValidateAsync(context, cancellation);
    }
}