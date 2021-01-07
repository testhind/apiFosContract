using Cds.APITemplate.Domain.ItemAggregate.Abstractions;
using Cds.APITemplate.Infrastructure.ItemRepository.Abstractions;
using Cds.APITemplate.Infrastructure.ItemRepository.Dtos;

namespace Cds.APITemplate.Infrastructure.Data.Items
{
    /// <summary>
    /// Represents the data repository for <see cref="ItemDto"/>.
    /// </summary>
    public sealed class InMemoryRepository : IItemRepository, IItemReadRepository
    {
    }
}
