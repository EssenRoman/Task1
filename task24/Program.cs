int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i; // sum = sum + i
        }
    }
    return sum;
}

Console.WriteLine("Write number");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);

if(number < 1)
{
    Console.WriteLine("Incorrect");
    return;
}

Console.WriteLine($"Sum numbers {number} = {sumNumbers}");