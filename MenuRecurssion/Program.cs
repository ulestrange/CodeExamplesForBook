namespace MenuRecurssion
{
    internal class Program
    {

        static string choice = "";
        static void Main(string[] args)
        {

            string  input = Console.ReadLine()!;

            input = input.ToUpper();

       

            char[] chars = input.ToCharArray(); // turn the string into a character array

            // can edit the individual characters in the array here

            input = new String(chars); // turn the character array into a string.

            Console.WriteLine(input);

            Menu();

        }
        static void ProcessChoiceA()
        {
            Console.WriteLine("Doing A stuff");
            Menu();
        }
        static void ProcessChoiceB()
        {
            Console.WriteLine("Doing B stuff");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Please enter your choice");
            choice = Console.ReadLine()!.ToLower();

            if (choice != "exit")
            {
                if (choice == "a")
                {
                    ProcessChoiceA();
                }
                else if (choice == "b")
                {
                    ProcessChoiceB();
                }
                else
                {
                    Console.WriteLine("Bye");
                }
                                
            }
        }
    }
}