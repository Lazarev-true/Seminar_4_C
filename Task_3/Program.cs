// (Дополнительная, не обязательная задача): Назовём число «интересным» 
// если его произведение цифр делится на их сумму. Напишите программу, 
// которая заполняет массив на N «интересных» случайных целых чисел. 
// (Каждый эл-т массива должен быть сгенерирован случайно).

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int sum = 0;
int pr = 1;
int i = 0;
int a;

while(i < N)
{
   Random x = new Random();
   int value = x.Next();
   int num = value;

   while(num != 0)
   {
      a = num % 10;
      sum += a;
      pr *= a;
      num /= 10;
   }

   if((pr != 0) && (pr % sum == 0))
   {
      array[i] = value;
      i++;
   }
   else 
   {
      i += 0;
      pr = 1;
      sum = 0;
   }
   
}
var str = string.Join(" ", array);
Console.WriteLine(str);
