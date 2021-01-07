using Cds.APITemplate.Domain.ItemAggregate.Abstractions;
using System;

namespace Cds.APITemplate.Domain.ItemAggregate
{
    /// <summary>
    /// Represents the command handler for items.
    /// </summary>
    public sealed class ItemHandler
    {
        private readonly IItemRepository _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemHandler"/> class.
        /// </summary>
        /// <param name="repository">The repository</param>
        public ItemHandler(IItemRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
