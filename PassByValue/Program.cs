namespace PassByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            int[] anArray = { 1, 2, 3 };

            string myString = null;

        //    myString = myString == null ? "" : myString;


            myString.ToUpper();

            sampleMethod(a, anArray);

            Console.WriteLine(a);
            Console.WriteLine(anArray[0]);

            string cat = "cat";

            ChangeString(cat);

            Console.WriteLine(cat);

            string test = "hello this is a sentance what happens when I split it";

            string[] newStrings = test.Split(' ');


            newStrings = test.Split(' ', 3);

            int[] test2 = { 1, 2, 3, 4, 5 };

            WriteEveryElement(test2);
            WriteEveryElement2(test2);
        }

        static void WriteEveryElement(int[] myArray)
        {
            int i = 0;

            foreach (int number in myArray)
            {
                myArray[i] = number * 2;
                Console.WriteLine(number);
                i++;              
            }
        }

        static void WriteEveryElement2(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.WriteLine(myArray[i]);
                
            }

        }

        static void ChangeString(string input)
        {
            input = input + input;
        }

        static void sampleMethod(int number, int[] setOfNumbers)
        {
            number = 3;
            setOfNumbers[0] = 100;
            setOfNumbers = new int[] { 20, 30, 40 };
        }
    }
}