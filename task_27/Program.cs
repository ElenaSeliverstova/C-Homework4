// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSum (int numA)
{
    int sum = 0;
    int num = numA;
    while (num > 0) 
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма цифр в числе = " + FindSum(numA));

