namespace Recurssion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(  Factorial(5));
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial2(5));
            Console.WriteLine(Factorial2(3));
            Console.WriteLine(Factorial2(2));
        }


        static int Factorial2 (int number)
        {
            if (number == 1)
            {
                return number;
            }
            else
            {
                return number * Factorial2(number - 1);
            }
        }

        
        static int Factorial (int number)
        {
            int answer = 1;
            for (int i = number; i > 0; i--)
            {
                answer = answer * i;
            }

            return answer;
        }
    }
}