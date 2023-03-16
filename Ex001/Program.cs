/* ## Задача 2: 
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. */
using static Library2;
using static Library3;
using static Library4;

int[,] array = new int[10,10];

//Console.WriteLine(array.GetLength(1));

array = FillArray(array);

PrintArray(array);
Console.WriteLine();

// Оксана
array = Metod3(array); // оба индекса чётные, и замените эти элементы на их квадраты.

PrintArray(array);