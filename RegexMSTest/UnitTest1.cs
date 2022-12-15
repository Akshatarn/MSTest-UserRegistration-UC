using MSTestUserRegistration;
namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("91 8286828080")]    //pass
        [DataRow("91 9919292319")]   //pass
        [DataRow("91 0923252352")]     //fail
        [DataRow("919239323783 ")]    //fail
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.MobileNumber(userInput);      //UC4 Mobile no format 91 8286828080

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}