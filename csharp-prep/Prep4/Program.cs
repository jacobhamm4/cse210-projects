using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string i = Console.ReadLine();
        int n = int.Parse(i);

        n = -1;
        while (n != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finsihed.");
            Console.Write("Enter Number: ");
            string op = Console.ReadLine();
            int userNumber = int.Parse(op);
            numbers.Add(userNumber);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"the average is: {average}");

        // Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}