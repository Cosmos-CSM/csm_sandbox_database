using CSM_Database_Testing.Managers;

using CSM_Sandbox_Database_Core.Entities;

using CSM_Sandbox_Database_Testing.Utils;

using SandboxEntities = CSM_Sandbox_Database_Core.Entities;

namespace CSM_Sandbox_Database_Testing.Managers;

/// <summary>
///     Represents a test data storing handler for <see cref="CSM_Sandbox_Database_Core.SandboxDatabase"/> entities.
/// </summary>
public class StoreManager {

    /// <summary>
    ///     Base store manager,
    /// </summary>
    readonly TestingStoreManager _testingStoreManager;

    /// <summary>
    ///     Creates a new instance
    /// </summary>
    /// <param name="storeManager">
    ///     Testing data store manager.
    /// </param>
    public StoreManager(TestingStoreManager storeManager) {
        _testingStoreManager = storeManager;
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.Category"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.Category"/>.
    /// </returns>
    public async Task<Category> Category(Category? @ref = null) {
        @ref = DraftUtils.Category(@ref);

        return await _testingStoreManager.Store(@ref);
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.Customer"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.Customer"/>.
    /// </returns>
    public async Task<Customer> Customer(Customer? @ref = null) {
        @ref = DraftUtils.Customer(@ref);

        if (@ref.Supplier.Id <= 0)
            await Supplier(@ref.Supplier);

        return await _testingStoreManager.Store(@ref);
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.Order"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.Order"/>.
    /// </returns>
    public async Task<Order> Order(Order? @ref = null) {
        @ref = DraftUtils.Order(@ref);

        if (@ref.Customer.Id <= 0)
            await Customer(@ref.Customer);


        return await _testingStoreManager.Store(@ref);
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.OrderItem"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.OrderItem"/>.
    /// </returns>
    public async Task<OrderItem> OrderItem(OrderItem? @ref = null) {
        @ref = DraftUtils.OrderItem(@ref);

        return await _testingStoreManager.Store(@ref);
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.Product"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.Product"/>.
    /// </returns>
    public async Task<Product> Product(Product? @ref = null) {
        @ref = DraftUtils.Product(@ref);

        if (@ref.Category.Id <= 0)
            await Category(@ref.Category);

        return await _testingStoreManager.Store(@ref);
    }

    /// <summary>
    ///     Stores a <see cref="SandboxEntities.Supplier"/>
    /// </summary>
    /// <returns>
    ///     A datasource stored <see cref="SandboxEntities.Supplier"/>.
    /// </returns>
    public async Task<Supplier> Supplier(Supplier? @ref = null) {
        @ref = DraftUtils.Supplier(@ref);

        return await _testingStoreManager.Store(@ref);
    }
}
