using CSM_Database_Testing;

using CSM_Sandbox_Database_Core.Entities;

namespace CSM_Sandbox_Database_Testing.Utils;

/// <summary>
///     Utility class that provides drafting for <see cref="CSM_Sandbox_Database_Core.SandboxDatabase"/> entities.
/// </summary>
static public class DraftUtils {


    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.Product"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.Product"/> entity.
    /// </returns>
    static public Product Product(Product? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);
        @ref.Category = Category(@ref.Category);

        return @ref;
    }


    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.OrderItem"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.OrderItem"/>s entity.
    /// </returns>
    static public OrderItem OrderItem(OrderItem? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);

        return @ref;
    }


    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.Order"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.Order"/> entity.
    /// </returns>
    static public Order Order(Order? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);
        @ref.Customer = Customer(@ref.Customer);

        return @ref;
    }

    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.Category"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.Category"/> entity.
    /// </returns>
    static public Category Category(Category? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);

        return @ref;
    }

    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.Customer"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.Customer"/> entity.
    /// </returns>
    static public Customer Customer(Customer? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);
        @ref.Supplier = Supplier(@ref.Supplier);

        return @ref;
    }

    /// <summary>
    ///     Drafts a <see cref="CSM_Sandbox_Database_Core.Entities.Supplier"/> entity.
    /// </summary>
    /// <param name="ref">
    ///     Pre-defined drafting values.
    /// </param>
    /// <returns>
    ///     A drafted <see cref="CSM_Sandbox_Database_Core.Entities.Supplier"/> entity.
    /// </returns>
    static public Supplier Supplier(Supplier? @ref = null) {
        @ref = BaseDraftUtils.NamedEntity(@ref);

        return @ref;
    }
}
