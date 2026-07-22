using CSM_Sandbox_Database.Entities.Abstractions.Bases;

namespace CSM_Sandbox_Database.Entities;

/// <summary>
///     Represents a business category to identify data.
/// </summary>
public class Category : SandboxEntityBase {

    /// <summary>
    ///     Category products.
    /// </summary>
    public ICollection<Product> Products { get; set; } = []; 
}
