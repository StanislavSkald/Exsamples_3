// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb >= 10000 && numb < 100000)
{
    int numb1 = numb / 10000;
    int numb2 = numb % 10000 / 1000;
    int numb4 = numb % 100 / 10;
    int numb5 = numb % 10;
    if (numb1 == numb5 && numb2 == numb4)
    Console.WriteLine("Данное число являеться палиндромом");
    else Console.WriteLine("Данное число не являеться палиндромом");
}
else Console.WriteLine("Данное число не являеться пятизначным");