using CSM_Database_Core.Entities.Abstractions.Interfaces;

using CSM_Foundation_Core.Abstractions.Interfaces;

using CSM_Sandbox_Database_Core.Depots.Abstractions.Bases;
using CSM_Sandbox_Database_Core.Depots.Abstractions.Interfaces;
using CSM_Sandbox_Database_Core.Entities;

namespace CSM_Sandbox_Database_Core.Depots;

/// <summary>
///     Represents a <see cref="Category"/> business entity depot.
/// </summary>
public class CategoriesDepot
    : SandboxDepotBase<Category>, ICategoriesDepot {

    /// <inheritdoc/>
    public CategoriesDepot(SandboxDatabase Database, IDisposer<IEntity>? Disposer)
        : base(Database, Disposer) {
    }
}
