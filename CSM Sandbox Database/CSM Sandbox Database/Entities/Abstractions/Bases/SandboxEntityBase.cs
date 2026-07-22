using CSM_Database_Core.Entities.Abstractions.Bases;

namespace CSM_Sandbox_Database.Entities.Abstractions.Bases;

/// <summary>
///     Represents a <see cref="SandboxDatabase"/> entity.
/// </summary>
public abstract class SandboxEntityBase : NamedEntityBase {

    /// <inheritdoc/>
    public override Type Database { get; init; } = typeof(SandboxDatabase);
}
