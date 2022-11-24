/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
   
int randomNumber = GetRandomNumberInRange(10000, 99999);
Console.WriteLine(randomNumber);
int firstDigit = randomNumber / 10000; 
int lastDigit = randomNumber % 10;
if (firstDigit == lastDigit)
{
    int secondDigit = (randomNumber/1000) % 10;
    int prelastDigit = (randomNumber/10) % 10;
    if (secondDigit == prelastDigit) Console.WriteLine("число является палиндромом");
    else 
    {
        Console.WriteLine("число не является палиндромом");
    }
}
else
{
    Console.WriteLine("число не является палиндромом");
}
