namespace TypeStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double taxRate = 0.4;

            decimal salary = 1000000;

            decimal tax = salary * (decimal)taxRate;

            int number = 3;

            string message = "number is " + number;

            string input = Console.ReadLine();

            number = int.Parse(input);


            int[] numbers = { 1, 2, 3, 4, 2, 3, 4, 5, 1, 2 };

            Console.WriteLine(Array.IndexOf(numbers, 5));

            Array.Sort(numbers);

            Console.WriteLine(Array.IndexOf(numbers, 5));

            Array.Reverse(numbers);

            Console.WriteLine(Array.IndexOf(numbers, 5));

            Array.Sort(numbers);

            int max = Array.IndexOf(numbers, 3);

        }
    }
}