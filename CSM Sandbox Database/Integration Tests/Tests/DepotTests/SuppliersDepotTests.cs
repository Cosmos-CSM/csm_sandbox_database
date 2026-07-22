using CSM_Database_Testing.Abstractions.Bases;

using CSM_Sandbox_Database;
using CSM_Sandbox_Database.Depots;
using CSM_Sandbox_Database.Entities;

namespace Integration_Tests.Tests.DepotTests;

/// <summary>
///     Integration tests for <see cref="SuppliersDepot"/>
/// </summary>
public class SuppliersDepotTests : DepotIntegrationTestsBase<Supplier, SuppliersDepot, SandboxDatabase> {
    public override Task Update_Single_Success() {
        throw new NotImplementedException();
    }

    protected override Supplier EntityFactory(string Entropy) {


    }
}
