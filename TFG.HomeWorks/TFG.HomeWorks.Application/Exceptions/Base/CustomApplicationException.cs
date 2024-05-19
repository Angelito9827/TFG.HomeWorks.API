using TFG.HomeWorks.Application.Exceptions.Base;

namespace TFG.HomeWorks.Application.Exceptions
{
    public partial class CustomApplicationException : ApplicationException
    {
        private static readonly IDictionary<CustomApplicationExceptionCode, string> CustomApplicationExceptionCodeMessages = Enum.GetValues<CustomApplicationExceptionCode>()
            .ToDictionary(code => code, code => GetAttributeOfType<CustomApplicationExceptionCodeMessageAttribute>(code)?.Message ?? code.ToString());

        private static T? GetAttributeOfType<T>(Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : default;
        }
    }
}

