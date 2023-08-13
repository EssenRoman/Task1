//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Write nunber, day of week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(This is weekend) -> yes");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("this is not day of week");
  }
  else Console.WriteLine("(This day is not weekend) -> no");
}

CheckingTheDayOfTheWeek(dayNumber);