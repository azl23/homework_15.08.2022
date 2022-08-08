// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string messege)
{
    System.Console.Write(messege);           // Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int numb1;
int numb2;
int ost;
numb1 = Prompt("Введите первое число ");
numb2 = Prompt("Введите второе число ");
ost = numb1 % numb2;
if(ost == 0)
{
    System.Console.WriteLine("Кратно "); 
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {ost} "); 
}
