using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace TFG.HomeWorks.Application.Validations
{
    /// <summary>
    /// Validador de objetos que permite validar cualquier objeto que implemente la interfaz <see cref="DtoValidatable{T}"/> o exista definida una validación mediante la implementación de <see cref="IValidator{T}"/>
    /// </summary>
    public class ApplicationObjectValidator : IObjectValidator
    {
        private readonly IServiceProvider _serviceProvider;

        public ApplicationObjectValidator(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        public void EnsureIsValid<T>(T instance) => GetValidaror(instance)?.ValidateAndThrow(instance);

        public bool IsValid<T>(T instance) => GetValidaror(instance)?.Validate(instance).IsValid ?? true;

        private IValidator<T>? GetValidaror<T>(T instance) => GetValidatorFromInstance(instance) ?? GetValidatorFromDependencies<T>();

        private static IValidator<T>? GetValidatorFromInstance<T>(T instance) => (instance as DtoValidatable<T>);

        private IValidator<T>? GetValidatorFromDependencies<T>() => _serviceProvider.GetService<IValidator<T>>();
    }
}
