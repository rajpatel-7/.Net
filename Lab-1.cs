// See https://aka.ms/new-console-template for more information

//1. (A) Write a program to print your name, address, contact number & city. 

//String Add = "xyz";
//String Name="xyz";
//String Contact = "123456789";
//String City= "xyz";


//Console.WriteLine("your Add is "+Add);
//Console.WriteLine("your Add is " + Name);
//Console.WriteLine("your Add is " + Contact);
//Console.WriteLine("your Add is " + City);

//2. (A) Write a program to get two numbers from user and print those two numbers.

//Console.WriteLine("Enter first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("First number is: " + num1);
//Console.WriteLine("Second number is: " + num2);

//3. (A) Write program to prompt a user to input his/her name and country name and then output will be shown as given: Hello from 
//country

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your country name: ");
//string country = Console.ReadLine();
//Console.WriteLine("Hello " + name + " from " + country);

//4. (A) Write a program to calculate the size of the area in square-feet based on Speci ed length and width.

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int area = num1 * num2;
//Console.WriteLine("The area is: " + area + " square feet");

//5. (A) Write a program to calculate area of Square, Rectangle and Circle.

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int area1 = num1 * num1;
//int area2 = num1 * num2;
//double area3 = 3.14 * num1 * num1;
//Console.WriteLine("The area of Square: " + area1 + " square feet");
//Console.WriteLine("The area of Rectangle: " + area2 + " square feet");
//Console.WriteLine("The area of Circle: " + area3 + " square feet");

//6. (B) Write a program to calculate Celsius to Fahrenheit and vice-versa using function.
//using System;

//class Program
//{
//    static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    static double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }

//    static void Main()
//    {
//        Console.WriteLine("Choose conversion:");
//        Console.WriteLine("1. Celsius to Fahrenheit");
//        Console.WriteLine("2. Fahrenheit to Celsius");
//        Console.Write("Enter your choice (1 or 2): ");
//        int choice = Convert.ToInt32(Console.ReadLine());

//        if (choice == 1)
//        {
//            Console.Write("Enter temperature in Celsius: ");
//            double celsius = Convert.ToDouble(Console.ReadLine());
//            double fahrenheit = CelsiusToFahrenheit(celsius);
//            Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
//        }
//        else if (choice == 2)
//        {
//            Console.Write("Enter temperature in Fahrenheit: ");
//            double fahrenheit = Convert.ToDouble(Console.ReadLine());
//            double celsius = FahrenheitToCelsius(fahrenheit);
//            Console.WriteLine($"{fahrenheit}°F = {celsius:F2}°C");
//        }
//        else
//        {
//            Console.WriteLine("Invalid choice.");
//        }
//    }
//}


//7. (B) Write a program to nd out Simple Interest using function. (I = PRN / 100)

//using System;
//class Program
//{
//    static double CalculateSimpleInterest(double principal, double rate, double time)
//    {
//        return (principal * rate * time) / 100;
//    }
//    static void Main()
//    {
//        Console.Write("Enter Principal Amount: ");
//        double principal = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter Rate of Interest: ");
//        double rate = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter Time (in years): ");
//        double time = Convert.ToDouble(Console.ReadLine());
//        double simpleInterest = CalculateSimpleInterest(principal, rate, time);
//        Console.WriteLine($"The Simple Interest is: {simpleInterest}");
//    }
//}

//8. (B) Write a program to create a Simple Calculator for two numbers (Addition, Multiplication, Subtraction, Division) [Also using
//if…else &Switch Case]
//using System;
//class SimpleCalculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Choose an operation:");
//        Console.WriteLine("1. Addition");
//        Console.WriteLine("2. Subtraction");
//        Console.WriteLine("3. Multiplication");
//        Console.WriteLine("4. Division");
//        Console.Write("Enter your choice (1-4): ");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        double result;
//        switch (choice)
//        {
//            case 1:
//                result = num1 + num2;
//                Console.WriteLine($"Result: {num1} + {num2} = {result}");
//                break;
//            case 2:
//                result = num1 - num2;
//                Console.WriteLine($"Result: {num1} - {num2} = {result}");
//                break;
//            case 3:
//                result = num1 * num2;
//                Console.WriteLine($"Result: {num1} * {num2} = {result}");
//                break;
//            case 4:
//                if (num2 != 0)
//                {
//                    result = num1 / num2;
//                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
//                }
//                else
//                {
//                    Console.WriteLine("Error: Division by zero is not allowed.");
//                }
//                break;
//            default:
//                Console.WriteLine("Invalid choice.");
//                break;
//        }
//    }
//}

//9. (C) Write a program to Swapping without using third variable.
//using System;
//class SwapWithoutThirdVariable
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Before Swapping: num1 = {num1}, num2 = {num2}");

//        num1 = num1 + num2;
//        num2 = num1 - num2;
//        num1 = num1 - num2;
//        Console.WriteLine($"After Swapping: num1 = {num1}, num2 = {num2}");
//    }
//}

//10. (C)Write a program to nd maximum numbers from given 3 numbers using ternary operator.
//using System;
//class MaxOfThreeNumbers
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter first number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter second number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter third number: ");
//        int num3 = Convert.ToInt32(Console.ReadLine());
//        int max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);

//        Console.WriteLine($"The maximum number is: {max}");
//    }
//}












