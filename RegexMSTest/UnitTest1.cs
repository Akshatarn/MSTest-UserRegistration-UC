using MSTestUserRegistration;
namespace RegexMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("abc@yahoo.com")]    //pass
        [DataRow("abc-100@yahoo.com")]   //pass
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        [DataRow("abc", "abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void TestFirstName(string userInput)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            bool output = UserDetails.EmailSample(userInput);   

            //Assert
            Assert.AreEqual(output, true);
        }
    }
}