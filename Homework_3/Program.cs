// Задача 19
//
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (палиндром - число читается слева направо и справа налево одинаково)

// Console.Write("Введите пятизначное число: ");
// string str = Console.ReadLine();
// int i = str.Length;
// if(i<5)
// {
//     Console.WriteLine("ввели число неудовлетворяющее условиям");
// } else
//     {
//         if(i>5)
//         {
//             Console.WriteLine("ввели число неудовлетворяющее условиям");
//         } else
//             {
//                 if(str[0]==str[4] && str[1]==str[3])
//                 {
//                     Console.WriteLine("число является палиндромом");
//                 } else
//                     {
//                         Console.WriteLine("число не является палиндромом");
//                     }
//             }
//     }

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве 

    // Console.Write("Введите координату X1 первой точки: ");
    // double X1 = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Введите координату Y1 первой точки: ");
    // double Y1 = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Введите координату Z1 первой точки: ");
    // double Z1 = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Введите координату X2 второй точки: ");
    // double X2 = Convert.ToDouble(Console.ReadLine());   
    // Console.Write("Введите координату Y2 второй точки: ");
    // double Y2 = Convert.ToDouble(Console.ReadLine());
    // Console.Write("Введите координату Z2 второй точки: ");
    // double Z2 = Convert.ToDouble(Console.ReadLine());
    // double AB = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
    // Console.Write("Расстояние между точками равно: ");
    // Console.WriteLine(Math.Round(AB,2));
    
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите число N: ");
// double N = Convert.ToDouble(Console.ReadLine());
// for(double i = 1; i<=N; Console.Write(Math.Pow(i,3)), Console.Write(" "), i++ );