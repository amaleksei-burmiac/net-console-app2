using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class CheckIsEvenNumber
    {
        public bool IsEven(int number) { 
            return number % 2 == 0;
        }

        public string OutputCheckMessage(int number)
        {
            bool isEven = IsEven(number);
            return isEven ? $"число {number} - четное" : $"число {number} - нечетное";
        }

        public void CheckEvenNumber()
        {
            Console.WriteLine("Введите число для проверки на четность: ");
            string? userInput = Console.ReadLine();

            if (userInput != null)
            {
                int userInputNumber = Convert.ToInt32(userInput);
                string result = OutputCheckMessage(userInputNumber);

                Console.WriteLine(result);
            }
        }
    }
}
