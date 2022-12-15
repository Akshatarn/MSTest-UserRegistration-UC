using MSTestUserRegistration;
namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Abc")]
        [DataRow("Abcd")]
        [DataRow("Ab")]
        [DataRow("abc")]
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.LastName(userInput);

            //Assert
            Assert.AreEqual(output, true);

        }
    }
}