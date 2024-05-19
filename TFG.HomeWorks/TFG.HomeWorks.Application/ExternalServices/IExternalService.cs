namespace TFG.HomeWorks.Application.ExternalServices
{
    public class ExternalServiceResponseDto(int Value)
    {
        public int Value { get; }
    }

    public interface IExternalService
    {
        Task<ExternalServiceResponseDto> Test();
    }
}