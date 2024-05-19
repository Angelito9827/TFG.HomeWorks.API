namespace TFG.HomeWorks.Application.Exceptions.Base
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class CustomApplicationExceptionCodeMessageAttribute : Attribute
    {
        public string Message { get; }
        public CustomApplicationExceptionCodeMessageAttribute(string message) => Message = message;
    }
}

