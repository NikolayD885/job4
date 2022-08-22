// Программа которая задает массив из 8 элементов и выводит их на экран

Console.Clear();

int[] CreateArray()
  {
    int[] array = new int[8];
    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 99);

    return array;
  }

  var array = CreateArray();

  for (int i = 0; i < 8; i++)
    Console.Write(" " +array[i]);