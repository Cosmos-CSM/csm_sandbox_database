using CSM_Database_Core.Entities.Abstractions.Interfaces;

using CSM_Foundation_Core.Abstractions.Interfaces;

using CSM_Sandbox_Database_Core.Depots.Abstractions.Bases;
using CSM_Sandbox_Database_Core.Depots.Abstractions.Interfaces;
using CSM_Sandbox_Database_Core.Entities;

namespace CSM_Sandbox_Database_Core.Depots;

/// <inheritdoc cref="IProductsDepot"/>
public class ProductsDepot
    : SandboxDepotBase<Product>, IProductsDepot {

    /// <inheritdoc/>
    public ProductsDepot(SandboxDatabase Database, IDisposer<IEntity>? Disposer)
        : base(Database, Disposer) {
    }
}
