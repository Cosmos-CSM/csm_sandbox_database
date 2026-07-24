using CSM_Database_Core.Core.Attributes;

using CSM_Sandbox_Database_Core.Entities.Abstractions.Bases;

namespace CSM_Sandbox_Database_Core.Entities;

/// <summary>
///     Represents a supplier business, wich are the immeadiate link between the business and customers.
/// </summary>
public class Supplier : SandboxEntityBase {
    /// <summary>
    ///     Supplier assigned customers.
    /// </summary>
    [EntityRelation]
    public ICollection<Customer> Customers { get; set; } = [];

    /// <summary>
    ///     Supplier orders.
    /// </summary>
    [EntityRelation]
    public ICollection<Order> Orders { get; set; } = [];
}
