using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace TestProject1
{
    public class TestIsEvenNumber
    {
        [Fact]
        public void TestEvenNumber() {
            CheckIsEvenNumber checkIsEvenNumber = new CheckIsEvenNumber();

            int checkNumber = 10;
            bool isEven = checkIsEvenNumber.IsEven(checkNumber);

            Assert.True(isEven);
            
            int checkNumberWithFailed = 33333;
            bool isEvenWithFailed = checkIsEvenNumber.IsEven(checkNumberWithFailed);

            Assert.False(isEvenWithFailed, "Число должно быть нечетным");
        }
    }
}
