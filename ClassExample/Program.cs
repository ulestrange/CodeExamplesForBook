namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? number;
            bool? question;
            char? myChar;

            string input = Console.ReadLine()!;

            Console.WriteLine(input.ToUpper());

            if (input != null)
            {
                Console.WriteLine(input.ToUpper());
            }
            Console.WriteLine(input.ToUpper());

        }
    }
}

//            question = false;
//            myChar = '3';

//            if ((bool)question)
//            {
//                Console.WriteLine(myChar);
//            }
//            Console.WriteLine(number);

//            Console.WriteLine("Hello, World!");
//        }
//    }
//}