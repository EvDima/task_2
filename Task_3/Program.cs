//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 7 || n == 6)
    Console.WriteLine("Выходной!");
else
    Console.WriteLine("Будний день.");
