using Dapper;
using System.Data;
using TFG.HomeWorks.Application.ExternalServices;

namespace TFG.HomeWorks.Infrastructure.Persistance.Queries
{
    /// <summary>
    /// Esto es un ejemplo de como usar Dapper para hacer consultas que no podamos realizar mediante entity framework.
    /// Por ejemplo hacer llamadas a Store Procedures que nos proporcione el cliente
    /// </summary>
    public class DapperQueryExternalService : IExternalService
    {
        private readonly IDbConnection _dbConnection;

        public DapperQueryExternalService(DbConnectionFactory dbConnection)
        {
            _dbConnection = dbConnection.GetDefaultDbConnection();
        }

        public async Task<ExternalServiceResponseDto> Test()
        {
            // Parámestros del SP
            var parameters = new DynamicParameters();
            parameters.Add("INPUTPARAMETER", 42);
            parameters.Add("RESULTADO", dbType: DbType.Int32, direction: ParameterDirection.Output);

            // Consulta
            //var result = await _dbConnection.QuerySingleAsync<ExampleResponse>("dbo.sp_ExampleSP", parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);

            await _dbConnection.ExecuteAsync("SELECT 1").ConfigureAwait(false);

            //Ejemplo de como obtener un parámetro de salida del SP
            //parameters.Get<int>("RESULTADO");

            return new ExternalServiceResponseDto(42);
        }
    }


}
