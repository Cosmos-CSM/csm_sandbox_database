using CSM_Database_Core.Depots.Abstractions.Interfaces;

using CSM_Sandbox_Database_Core.Entities;

namespace CSM_Sandbox_Database_Core.Depots.Abstractions.Interfaces;

/// <summary>
///     Represents a <see cref="Product"/> business entity depot.
/// </summary>
public interface IProductsDepot
    : IDepot<Product> {
}
