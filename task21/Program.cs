/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int x1 = getNumberFromUser("Введите x1:");
int y1 = getNumberFromUser("Введите y1:");
int z1 = getNumberFromUser("Введите z1:");


int x2 = getNumberFromUser("Введите x2:");
int y2 = getNumberFromUser("Введите y2:");
int z2 = getNumberFromUser("Введите z2:");


double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)); 
Console.WriteLine(length);

