using System.Data;

namespace part1
{
    internal class Program
    {
        static int count;
        static int sum;

        static void Main(string[] args)
        {

            ProcessInput();

        }
        static void ProcessInput()
        {

            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine()!);

            count++;
            sum = sum + number;
              

            Console.WriteLine("Do you wish to enter another number? y/Y > ");
            string userChoice = Console.ReadLine()!.ToLower();
            if (userChoice == "y")
            {
                ProcessInput();
            }

            else if (userChoice == "n")
            {
                PrintStats();
            }

        }

        /// <summary>
        /// This method displays the printing screen for the students' stats
        /// </summary>
        static void PrintStats()
        {
            Console.WriteLine($"Sum is {sum} and count is {count}");
        }
    }
}