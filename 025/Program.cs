// Программа которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число которое нужно возвести в степень");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень в которую нужно возвести число");
int number2 = int.Parse(Console.ReadLine()!);

int AtoB(int number1, int number2){

   var result = number1;
 
   for(int i = 2; i <= number2; i++)
     result *= number1;

    return result;
}

var result = AtoB(number1, number2);
Console.WriteLine("\n" + "Ответ " + result);