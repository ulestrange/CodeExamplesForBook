
namespace ValidationDemo
{
    class Program
    {

        // una made a change

        static void Main(string[] args)
        {
            string inputString;

            // keep asking user for their age until we are happy with value entered        
            do
            {
                Console.Write("Enter your age : ");
                inputString = Console.ReadLine()!;
            }
            while (!IsValidData(inputString));
            // from here we can proceed with normal processing          
        }

        /// <summary>
        /// takes a string and returns true if the string is valid
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>

        static bool IsValidData(string inputString)
        {
            int num;
            if (int.TryParse(inputString, out num) && (IsWithinRange(num, 18, 21)))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Input must be a number between 18 and 21 inclusive");

                return false;
            }
        }



        static bool IsWithinRange(int number, int min, int max)
        {
            return (number >= min && number <= max);
        }


    }
}

