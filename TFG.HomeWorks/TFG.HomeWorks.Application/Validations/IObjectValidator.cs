using FluentValidation;

namespace TFG.HomeWorks.Application.Validations
{
    public interface IObjectValidator
    {
        void EnsureIsValid<T>(T instance);
        bool IsValid<T>(T instance);
    }
}
