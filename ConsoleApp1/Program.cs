// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

// Суммирование массива чисел
int[] numbers = new int[] { 1, 10, 20, 30 };
int sum = numbers.Sum();
Console.WriteLine("Сумма чисел: " +  sum);

CheckIsEvenNumber checkIsEvenNumber = new CheckIsEvenNumber();
checkIsEvenNumber.CheckEvenNumber();
