using System;

class Program
{
    static void Main()
    {
        Console.Write("Welcome to my Grade Calculator. Enter a numerical grade between 0 and 100: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Letter grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Letter grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Letter grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Letter grade: D");
        }
        else
        {
            Console.WriteLine("Letter grade: F");
        }
    }
}
