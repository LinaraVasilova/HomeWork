// Домашняя работа. Семинар 3
// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int num,r,sum=0,i;
// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
// for(i=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(i==sum)
// Console.Write($"да");
// else
// Console.Write($"нет");
// } else
// Console.Write("Введите пятизначное число! ");

// int num, r, sum=0, t;
// Console.Write("Введите число: ");
// num = Convert.ToInt32(Console.ReadLine());
// for(t=num; num!=0; num=num/10)
// {
//     r=num % 10;
//     sum = sum*10+r;
// }
// if(t==sum)
//     Console.Write("{0} это палиндром", t);
// else
//     Console.Write("{0} это НЕ палиндром", t);


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double getDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)  + Math.Pow(zb - za, 2));
// }
// Console.Write("Введите координату X первой точки: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z первой точки: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату X второй точки: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z второй точки: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Расстояние между точками: " + Math.Round(getDistance(xa, ya, za, xb, yb, zb), 2));




// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void cubeTable(int n)
// {
//     int currentNumber = 1;
//     while (currentNumber <= n)
//     {
//         Console.WriteLine(currentNumber + " - " + (currentNumber * currentNumber*currentNumber));
//         currentNumber ++;
//     }
// }
// Console.Write ("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n>0)
//     cubeTable(n);
// else
//     Console.Write ("Введите число больше 0 ");


// Домашняя работа. Семинар 5
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] result = new int[size];

//     for(int i=0; i < result.Length; i++)
//         result[i] = rnd.Next(minValue, maxValue + 1);
    
//     return result;
// }


// void FindEven(int[]newArray)
// {
//     int even = 0;
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if (newArray[i] % 2 == 0)
//         even = even +1;
//     }
//     Console.Write($"Количество четных числе в массиве: {even}");
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random(); // переменная генератор случайных чисел
//     int[] result = new int[size];
//     for(int i=0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }


// void FindOdd(int[] MyArray)
// {
//     int odd = 0;
//     for(int i = 1; i < MyArray.Length; i=i+2)
//     {
//         odd=odd+MyArray.Length; i=i+2;
        
//     }
//    Console.WriteLine($"Сумма чисел на нечетных позициях {odd}");
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// using static System.Console;
// Clear();
// Write("Введите размер массива: ");
// int length=int.Parse(ReadLine()!);
// Write("Введите минимальное значение массива: ");
// int min= int.Parse(ReadLine()!);
// Write("Введите максимальное значение массива: ");
// int max= int.Parse(ReadLine()!);
// int[]Array = GetArray(length, min, max);
// WriteLine($"[{string.Join(",", Array)}]);
// FindDifference(Array, max, min);

// int[] GetArray(int size, int minValue, maxValue)
// {
//     Random rnd = new Random();
//         int[] result = new int[size];
//     for(int i=0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void FindDifference(int[] MyArray, int minVal, int maxVal)
// {
//     for(int i = 0; i < MyArray.Length; i=++)
//     {
//         if(MyArray[i]<minVal)
//         {
//             minVal=MyArray[i];
//         }
//         if(MyArray[i]>maxVal)
//         {
//             maxVal=MyArray[i];
//         }
//     }
//    Console.WriteLine($"Разница {maxVal-minVal}");
// }