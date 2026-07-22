using CSM_Database_Core.Core.Attributes;
using CSM_Database_Core.Core.Extensions;

using CSM_Sandbox_Database.Entities.Abstractions.Bases;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSM_Sandbox_Database.Entities;

/// <summary>
///     Represents an <see cref="Order"/> item.
/// </summary>
public class OrderItem : SandboxEntityBase {

    /// <summary>
    ///     Item order.
    /// </summary>
    [EntityRelation]
    public Order Order { get; set; } = default!;

    /// <summary>
    ///     Item product.
    /// </summary>
    [EntityRelation]
    public Product Product { get; set; } = default!;

    /// <summary>
    ///     Item requeested quantity.
    /// </summary>
    public double Quantity { get; set; } = 0.0;

    /// <summary>
    ///     Product unitary price at order time.
    /// </summary>
    public double Price { get; set; } = 0.0;

    /// <summary>
    ///     Item total price at order time.
    /// </summary>
    public double Total { get; set; } = 0.0;

    /// <inheritdoc/>
    protected override void DesignEntity(EntityTypeBuilder etBuilder) {
        etBuilder.Link<OrderItem, Order>(
                nameof(Order),
                nameof(Order.Items)
            );

        etBuilder.Link<OrderItem, Product>(
                nameof(Product),
                nameof(Product.Orders)
            );
    }
}
