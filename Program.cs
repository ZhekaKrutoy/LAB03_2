using System;

    internal class Program
    {
      static void Main(string[] args)
        {
            Console.Write("Введите первую сторону треугольника: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            int number3 = int.Parse(Console.ReadLine());
            int B = number1 + number2 + number3 ; 
            double p = (number1 + number2 + number3)/2;
            double W = Math.Sqrt(p * (p - number1) * (p - number2) * (p - number3));  
            Console.WriteLine($"Периметр: {B}");
            Console.WriteLine($"Площадь: {W:F2}");
        }
    }