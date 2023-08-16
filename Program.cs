// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int[4];
// int even_numbers = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     Console.WriteLine(array[i]);

//     if(((array[i]% 100)/10)% 2==0)
//     {
//         even_numbers++;
//     }
//     if((array[i]/100)%2==0)
//     {
//         even_numbers++;
//     }
//     if((array[i])%2==0)
//     {
//         even_numbers++;
//     }
// }
// Console.WriteLine(even_numbers);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = new int[4];
// int num = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-99,100);
//     if(i%2==1)
//     {
//         num+=array[i];
//     }
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine(num);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[,] a = new double[5, 10];
// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 1; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; 
//         Console.Write("{0,6:F2}", a[i, j]);
//         double min = Int32.MaxValue;
//         double max = Int32.MinValue;

//         for (int z = 0; z < 5; z++)
//         {
//             if (a[i, j] > max)
//                 {
//                     max = a[i, j];
//                 }
//             if (a[i, j] < min)
//                 {
//                     min = a[i, j];
//                 }
//         }
//     }
//         Console.WriteLine();
// }
// Console.WriteLine(min);
// Console.WriteLine(max);