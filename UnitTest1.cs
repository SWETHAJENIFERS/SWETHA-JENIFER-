using APIDEMO.Controllers;

namespace APITEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int id = 1;
            string expectedOutput = "value1";
            UserController users = new UserController();
            var result = users.Get(id);
            Assert.AreEqual(result, expectedOutput);
        }
    }
}