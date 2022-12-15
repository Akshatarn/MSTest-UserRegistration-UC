using MSTestUserRegistration;
namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("abc@bl.com")]    //pass
        [DataRow("abc.xyz@bl.co.in")]   //pass
        [DataRow("abc123@gmail.a")]     //fail
        [DataRow("abc.@gmail.com")]    //fail
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.EmailId(userInput);      //UC3 Email ID testing .

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}