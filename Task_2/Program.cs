// 2) Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3(int a) 
{
    int result = -1; 
    if (a >= 100) 
    {
      while (a > 999) 
      {
        a = a / 10;
      }
      result = a % 10;
    }
    return result; 
}
if (number3(number) == -1) 
Console.WriteLine("Третьей цифры нет");
else 
Console.WriteLine("Третья цифра: " + number3(number)); 