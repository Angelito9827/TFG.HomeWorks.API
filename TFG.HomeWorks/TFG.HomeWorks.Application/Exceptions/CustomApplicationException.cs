namespace TFG.HomeWorks.Application.Exceptions
{
    public partial class CustomApplicationException : ApplicationException
    {
        public CustomApplicationExceptionCode Code { get; }

        public static CustomApplicationException Create(CustomApplicationExceptionCode code) => new(code, CustomApplicationExceptionCodeMessages[code]);

        private CustomApplicationException(CustomApplicationExceptionCode code, string message) : base(message) => Code = code;

    }
}

