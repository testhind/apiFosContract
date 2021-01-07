using Cds.APITemplate.Domain.ItemAggregate.Abstractions;
using Cds.APITemplate.Infrastructure.ItemRepository.Abstractions;
using Cds.APITemplate.Infrastructure.ItemRepository.Dtos;
using Dapper;
using System;
using System.Data;

namespace Cds.APITemplate.Infrastructure.Data.Items
{
    /// <summary>
    /// Represents the SQL data repository for <see cref="ItemDto"/>.
    /// </summary>
    public sealed class SqlRepository : IItemRepository, IItemReadRepository
    {
        private readonly Func<IDbConnection> _connectionFactory;

        /// <summary>
        /// Instanciate a new instance of <see cref="SqlRepository"/> with a connection.
        /// </summary>
        /// <param name="connectionFactory">A database connection factory.</param>
        public SqlRepository(Func<IDbConnection> connectionFactory)
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            _connectionFactory = connectionFactory;
        }
    }
}
