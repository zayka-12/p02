// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg} : ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int a = Prompt("Введите число ");
int CountDigit(int a)
{
    int count = 0; 
    while (a > 0)
    {
        a = a / 10;
        count++;
    }
    return count;
}
System.Console.WriteLine($"Цифр в числе {a} - {CountDigit(a)}");
