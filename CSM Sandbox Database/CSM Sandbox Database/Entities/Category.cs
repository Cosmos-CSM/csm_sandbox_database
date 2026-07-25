using CSM_Database_Core.Core.Attributes;

using CSM_Sandbox_Database_Core.Entities.Abstractions.Bases;

namespace CSM_Sandbox_Database_Core.Entities;

/// <summary>
///     Represents a business category to identify data.
/// </summary>
public class Category : SandboxEntityBase {

    /// <summary>
    ///     Category products.
    /// </summary>
    [EntityRelation]
    public ICollection<Product> Products { get; set; } = []; 
}
