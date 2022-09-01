// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе, которые являются делителями этого числа. 
// (для получения цифр числа операцию приведения числа к строке 
// не использовать)

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int num;
int sum = 0;
int value = number;

while(value != 0)
{
    num = value % 10;
    if(num != 0 && number % num == 0)
    {
        sum += num;
    }
    value /= 10;
}

Console.WriteLine($"{number} -> {sum}");