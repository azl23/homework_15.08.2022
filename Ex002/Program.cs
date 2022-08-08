// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int number = new Random().Next(10, 100);
System.Console.WriteLine(number); 
int number1 = number % 10;
int number2 = number / 10;
if(number1 > number2){
    System.Console.WriteLine(number1);
}
else
{
System.Console.WriteLine(number2);
}
