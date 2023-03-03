
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("1 - Программа для задания двумерного массива размером m×n, заполненного случайными вещественными числами.");
Console.WriteLine("2 - Программа, которая принимает на вход элемент и указывает его позицию  в двумерном массиве.");
Console.WriteLine("3 - Программа для задания двумерного массива из целых чисел и нахождения среднее арифметического элементов в каждом столбце.");
int numberOfTask = Prompt("Введите номер задачи");

     
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_47();
                break;

                case 2:
                Console.Clear();
                Task_50();
                break;

                case 3:
                Console.Clear();
                Task_52();
                break;

                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }
static int Prompt(string message)// Метод запроса числа.
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void Task_47() // Метод для задания двумерного массива размером m×n, заполненного случайными вещественными числами.
{
double[,] array = new double[3, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Random random = new Random();
            array[i, j] = Math.Round(random.NextDouble() * 100, 2); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1 
            //Math.Round( number), 2) округление вещественного числа до заданного знака после запятой
            Console.Write(array[i, j] + " ");
        }
    }
}

void Task_50() // Метод, который принимает на вход элемент и указывает его позицию  в двумерном массиве,
//заполненного случайными числами.
{
Console.WriteLine("Введите значение элемента: ");
int ViewerNumber = Convert.ToInt32(Console.ReadLine());

//FillArray(int[,] arr)
    //{
        int[,] arr = new int[new Random().Next(3,10), new Random().Next(4,10)];
       for (int i = 0; i < arr.GetLength(0); i++)
        {  
            Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(0, 10);
                Console.Write(arr[i, j] + " ");
            }
        }   
    //}

void Viewer(int[,] arr, int ViewerNumber)
{    
  int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] == ViewerNumber)
            {
              Console.WriteLine($"Искомый элемент находится на позиции: {i}, {j}");
            }
            else
            {
              count++;
            }
        }
    }
    if (count == arr.GetLength(0)*arr.GetLength(1))
    Console.WriteLine("Искомого значения нет!");
}

//FillArray(arr);
Console.WriteLine();
Viewer(arr,ViewerNumber);

}

void Task_52() // Метод для задания двумерного массива из целых чисел и 
//нахождения среднее арифметического элементов в каждом столбце.
{
    int[,] arr = new int[new Random().Next(3,10), new Random().Next(4,10)];
       for (int i = 0; i < arr.GetLength(0); i++)
        {  
            Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(0, 10);
                Console.Write(arr[i, j] + " ");
            }
        }   
        
int x = 0;
int sum = 0;
int Viewer1(int[,] arr)
{    
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = x;
        sum += arr[i,j]; 
    }
    return sum;
}

Viewer1(arr);
Console.WriteLine();
Console.WriteLine(sum);

}


// {
//     int[,] arr = new int[new Random().Next(3,10), new Random().Next(4,10)];
//        for (int i = 0; i < arr.GetLength(0); i++)
//         {  
//             Console.WriteLine();
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 arr[i, j] = new Random().Next(0, 10);
//                 Console.Write(arr[i, j] + " ");
//             }
//         }   

// doudle sum = 0;
// int Viewer1(int[,] arr)
// {    
    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int j = 0;
//         sum += arr[i,j]; 
//     }
//     return sum;
// }

// Viewer1(arr);
// Console.WriteLine();
// Console.WriteLine(sum);

// }