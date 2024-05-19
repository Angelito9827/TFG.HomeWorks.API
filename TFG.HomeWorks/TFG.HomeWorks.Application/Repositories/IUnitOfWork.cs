namespace TFG.HomeWorks.Application.Repositories
{
    /// <summary>
    /// Unidad de trabajo
    /// </summary>
    internal interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Persiste los cambios
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

