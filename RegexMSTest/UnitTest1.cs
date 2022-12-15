using MSTestUserRegistration;
namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Abc45678")]    //pass
        [DataRow("Abcd567890")]   //pass
        [DataRow("1234567")]     //fail
        [DataRow("Abc123")]    //fail   //fail
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.SpecialCharacter1(userInput);   

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}