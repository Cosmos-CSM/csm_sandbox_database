using CSM_Database_Core.Core.Extensions;

using CSM_Sandbox_Database.Entities.Abstractions.Bases;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSM_Sandbox_Database.Entities;

/// <summary>
///     Represents a business offered product.
/// </summary>
public class Product : SandboxEntityBase {

    /// <summary>
    ///     Product category.
    /// </summary>
    public Category Category { get; set; } = default!;

    /// <summary>
    ///    Orders requesting this product.
    /// </summary>
    public ICollection<OrderItem> Orders { get; set; } = [];

    /// <inheritdoc/>
    protected override void DesignEntity(EntityTypeBuilder etBuilder) {
        etBuilder.Link<Product, Category>(
                nameof(Category),
                nameof(Category.Products),
                isRequired: true,
                isAutoLoaded: true
            );
    }
}
