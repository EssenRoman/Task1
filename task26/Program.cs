// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int DigitCount(int num)
{
    int count = 0;
    if(num == 0) return 1;
    
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}


Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number {number} comprises {DigitCount(number)} signs.");

