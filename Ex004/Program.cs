// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Prompt(string messege)
{
    System.Console.Write(messege);           // Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}
int numb = Prompt("Введите число ");
if (numb %7 == 0 && numb % 23 == 0)
{
      System.Console.WriteLine("Да "); 
}
else
{
      System.Console.WriteLine("Нет "); 
}
