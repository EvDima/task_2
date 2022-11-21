// 1) Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

namespace task_1
{
    class Program 
    { 
        static void Main() 
        {
            Console.Write("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int num_2 = a / 10 % 10;
            Console.WriteLine("Второе число из трех: " + num_2);
        }
    }
}