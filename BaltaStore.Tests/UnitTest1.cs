using BaltaStore.Domain.StoreContext.Entities;

namespace BaltaStore.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var c = new Customer(
            "Ismael",
            "Gabri",
            "231245",
            "ismaelgabri03@hotmail.com",
            "1233214",
            "Rua dos Devs");

        var order = new Order(c);
        
    }
}