// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму
// и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4



int number = new Random().Next(10, 10000);
System.Console.WriteLine(number);
int max = 0;
while (number > 0) ;
{
    int a = number % 10;
    if (max < a) ;
    max = a;
    number = number / 10;
}

