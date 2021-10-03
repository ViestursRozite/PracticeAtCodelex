using Microsoft.VisualStudio.TestTools.UnitTesting;
using CozaLozaWoza;

namespace UnitTestsArithmetics
{
    [TestClass]
    public class ClasslessFunctionsArithmeticsTests3
    {
        
        [TestMethod]
        public void CozaLozaWoza_InNothing_OutputsCorrectStringUpTo110thPosition()
        {
            //Arrange
            string expected = "1 2 Coza 4 Woza Coza Loza 8 Coza Woza 11 \n" +
                "Coza 13 Loza CozaWoza 16 17 Coza 19 Woza CozaLoza 22 \n" +
                "23 Coza Woza 26 Coza Loza 29 CozaWoza 31 32 Coza \n" +
                "34 WozaLoza Coza 37 38 Coza Woza 41 CozaLoza 43 44 \n" +
                "CozaWoza 46 47 Coza Loza Woza Coza 52 53 Coza Woza \n" +
                "Loza Coza 58 59 CozaWoza 61 62 CozaLoza 64 Woza Coza \n" +
                "67 68 Coza WozaLoza 71 Coza 73 74 CozaWoza 76 Loza \n" +
                "Coza 79 Woza Coza 82 83 CozaLoza Woza 86 Coza 88 \n" +
                "89 CozaWoza Loza 92 Coza 94 Woza Coza 97 Loza Coza \n" +
                "Woza 101 Coza 103 104 CozaWozaLoza 106 107 Coza 109 Woza \n";
            //Act
            string actual = Program6.CozaLozaWoza();
            //Assert 
            Assert.AreEqual(expected, actual, true);
        }
    }
}
