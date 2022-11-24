/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
   
int randomNumber = GetRandomNumberInRange(1, 9);
Console.WriteLine(randomNumber);
int firstDigit = 1; 
while (firstDigit <= randomNumber)
{
    int cub = firstDigit * firstDigit * firstDigit;
    Console.Write($"{cub}, ");
    firstDigit++;
}

