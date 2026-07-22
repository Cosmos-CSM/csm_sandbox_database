using CSM_Database_Core.Depots.Abstractions.Bases;
using CSM_Database_Core.Entities.Abstractions.Interfaces;

using CSM_Foundation_Core.Abstractions.Interfaces;

using CSM_Sandbox_Database.Depots.Abstractions.Interfaces;
using CSM_Sandbox_Database.Entities;

namespace CSM_Sandbox_Database.Depots;

/// Represents a <see cref="Supplier"/> entity depot.
public class SuppliersDepot
    : DepotBase<SandboxDatabase, Supplier>, ISuppliersDepot {

    /// <inheritdoc/>
    public SuppliersDepot(SandboxDatabase Database, IDisposer<IEntity>? Disposer) : base(Database, Disposer) {
    }
}
