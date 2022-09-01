// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A 
// в натуральную степень B. Не использовать 
// функцию Math.Pow()

Console.WriteLine("Введите целое число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В");
int B = Convert.ToInt32(Console.ReadLine());

int num = 1;

for (int i = 1; i <= B; i++)
{
    num *= A;
}
Console.WriteLine($"{A}, {B} -> {num}");
