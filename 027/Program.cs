// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine()!);

int Sum(int number)
{
    for(int i = 1, sum = 0;  ; i++)
     {
     int a = number %10;

     sum = sum + a;

     number /= 10;

     if (number == 0)
    
      return sum;
     }
    
}
 var result = Sum(number);

 Console.WriteLine("\n" + "Сумма = " + result);















