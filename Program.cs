
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// int palindrome(int num)
// {
//     int num2 =0;
//     int sum = 0;
//     if(num>9999 && num < 100000)
//     {
   
//         for(num2 = num; num!=0; num = num / 10 )
//         {
//         num2 = num % 10;
//         sum = sum * 10 + num2;
//         }
        
//     }
//     return sum;
// }

// bool PalindromeVisitatio (int num, int sum)
// {
//     if (num == sum)
//     return true;
//     else return false;
// }

// Console.WriteLine ("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PalindromeVisitatio (num, palindrome(num)));


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double FindDistance(double x1, double y1,double z1, double x2, double y2, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
// }

// Console.WriteLine("input X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input Z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input Z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());


// double distance = FindDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Distance between a and b is {distance}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Input N");
// int num = Convert.ToInt32(Console.ReadLine());

// int current =1;
// int  cubnum =0;
// while (current <= num)
// {
//     cubnum = current*current*current;
//     Console.Write(cubnum + " ");
//     current++;
// }
