
using System;
using System.Xml.Linq;

namespace LAB1 { 
public class Task
    {
        public int Value1;
        public int Value2;
        public int Sum;
        public int doubleSum;
        public void DoubleSum() { 
         Sum = Value1 + Value2;
         doubleSum = (Value1 + Value2) * (Value1 + Value2) * (Value1 + Value2);
         Console.WriteLine("Double Sum: " + doubleSum);
        }
    }
    class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("What task do you want?");
        Console.WriteLine("1. Task 1");
        Console.WriteLine("2. Task 2");
        Console.WriteLine("3. Task 3");
        Console.WriteLine("4. Task 4");
        Console.WriteLine("5. Task 5");
        Console.WriteLine("6. Task 6");
        Console.WriteLine("7. Exit");

        int choice;
        bool isValidChoice = false;

        do
        {
            Console.Write("Enter number of task ");
            isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            if (!isValidChoice || choice < 1 || choice > 7)
            {
                Console.WriteLine("This task not exist");
                isValidChoice = false;
            }
        } while (!isValidChoice);

        switch (choice)
        {
            case 1:
                task1();
                break;
            case 2:
                task2();
                break;
            case 3:
                task3();
                break;
            case 4:
                task4();
                break;
            case 5:
                task5();
                break;
            case 6:
                task6();
                break;
            case 7:
                break;
        }
    }

    static void task1()
    {
        Console.WriteLine("Task 1");
        Console.Write("a = ");
        string? str = Console.ReadLine();
        float a = 0;
        if (str != null) a = float.Parse(str);
        double r = a / Math.Sqrt(3);
        Console.WriteLine("R =" + r);
    }

    static void task2()
    {
        Console.WriteLine("Task 2");
        int[] array = new int[3];

        float max = 0,A = 0, B = 0, C = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter sides of triangle (it should be positve)\nSide " + (i + 1) + " = ");
     
            array[i] = int.Parse(Console.ReadLine());
            max = Math.Max(max, array[i]);
        }
        max = A;

        int indexOfMax = Array.IndexOf(array, max);

        for (int i = 0; i < 3; i++) { 
        if (array[i] == array[indexOfMax]) { 
            
           }
        }
        //if ( ) {
        //    Console.WriteLine("Congratulations!! This is a right triangle");
        //}
        //else { 
        //    Console.WriteLine("This is not a right triangle");
        //}
    }


    static void task3()
    {
        Console.WriteLine("Task 3");
        Console.WriteLine("Enter points: ");
        Console.Write("X = ");
        var x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        var y = double.Parse(Console.ReadLine());

        if (x > 0 && x < 10 && y > 0 && y < 5)
            Console.WriteLine("Inside");
        else if (x < 0 || x > 10 || y < 0 || y > 5)
            Console.WriteLine("Outside");
        else
            Console.WriteLine("On the border");

    }
    static void task4()
    {
        Console.WriteLine("Task 4");
    }
    static void task5()
    {
        Console.WriteLine("Task 5");
        Console.WriteLine("Enter 2 value");
        Console.Write("1 = ");
        var value1 = int.Parse(Console.ReadLine());
        Console.Write("2 = ");
        var value2 = int.Parse(Console.ReadLine());

            var task = new Task();
            task.Value1 = value1;
            task.Value2 = value2;
            task.DoubleSum();
        }
    static void task6()
    {
        Console.WriteLine("Task6");
        Console.WriteLine("You have: (n+1)/(n*n+m*m+1)-(1/((m+1)*(n+1)))\nEnter N and M");
        Console.Write("N = ");
        var n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        var m = int.Parse(Console.ReadLine());

        float result = (((n + 1f) / (n * n + m * m + 1)) - (1f / ((m + 1) * (n + 1))));
        Console.WriteLine("Result: " + result);
    }
}
}