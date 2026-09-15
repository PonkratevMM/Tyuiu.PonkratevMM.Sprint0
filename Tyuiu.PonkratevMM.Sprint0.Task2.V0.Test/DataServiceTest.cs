using Tyuiu.PonkratevMM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PonkratevMM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Матвей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет123, Матвей", res);

        }
    }
}
