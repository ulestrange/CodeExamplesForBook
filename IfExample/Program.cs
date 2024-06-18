namespace IfExample
{
    internal class Program
    {

        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,

        }

        static bool CanVote(float age)
        {
            return (age >= 18);
        }

        static void Main(string[] args)
        {
            int[] inputs = { 2, 4, 5, 6, 9, 17, 18, 19, 59, 60, 61, 103 };
            int[] expectedOutputs = { 0, 0, 5, 5, 5, 5, 10, 10, 10, 6, 6, 6 };


            for (int i = 0; i < inputs.Length; i++)
            {
                int input = inputs[i];
                int expected = expectedOutputs[i];
                int actual = GetPriceFromAge2(input);

                Console.WriteLine($"input {input} output {actual} expected {expected}");
                Console.WriteLine($"Test Passed: {actual == expected}");

            }

            int[] inputs1 = { 0, 6, 0, 1 , 2, 3, 4,5, 6 , 3};
            int[] inputs2 = { 1, 9, 10, 11, 1, 9, 10, 11, 12 , 3};
            decimal[] expectedOutputs1 = { 2.4m, 0, 5, 5, 5, 5, 10, 10, 10, 6, 6, 6 };

            for (int i = 0; i < inputs1.Length; i++)
            {
                Days day = (Days) inputs1[i];
                int km = inputs2[i];
                decimal expected = expectedOutputs1[i];
                decimal actual = GetRentalPrice(day, km);

                Console.WriteLine($"day {day} km {km} output {actual} expected {expected}");
                Console.WriteLine($"Test Passed: {actual == expected}");

            }


            Console.WriteLine($"input 2 output {GetPriceFromAge(2)} expected 0");
            Console.WriteLine($"input 4 output {GetPriceFromAge(4)} expected 0");
            Console.WriteLine($"input 5 output {GetPriceFromAge(5)} expected 0");
            Console.WriteLine($"input 6 output {GetPriceFromAge(6)} expected 5");
            Console.WriteLine($"input 9 output {GetPriceFromAge(9)} expected 5");
            Console.WriteLine($"input 17 output {GetPriceFromAge(17)} expected 5");

            Console.WriteLine("Pleae enter age");

            int age = int.Parse(Console.ReadLine());
            int price;

            Console.WriteLine($"input 2 output {GetPriceFromAge(2)} expected 0");


            price = GetPriceFromAge(age);
            Console.WriteLine($"The price is {price}");
        }

        private static int GetPriceFromAge(int age)
        {
            int price;
            if (age < 5)
            {
                price = 0;
            }
            else if (age < 18)
            {
                price = 5;
            }
            else if (age >= 60)
            {
                price = 6;
            }
            else
            {
                price = 10;
            }

            return price;
        }

        private static int GetPriceFromAge2(int age)
        {
            int price = 10;
            if (age < 5)
            {
                price = 0;
            }
            if (age >= 5 && age < 18)
            {
                price = 5;
            }
            if (age >= 18 && age >= 60)
            {
                price = 6;
            }
            return price;
        }

        private static int GetPriceFromAge3(int age)
        {

            if (age < 5)
            {
                return 0;
            }
            if (age < 18)
            {
                return 5;
            }
            if (age >= 60)
            {
                return 6;
            }
            return 10;
        }

        private static decimal GetRentalPrice(Days day, int numberOfKm)
        {
            decimal charge = 2;

            if (numberOfKm > 1)
            {
                charge = 2 + (1.5m * (numberOfKm - 1));
            }

            if (numberOfKm > 10)
            {
                charge = charge * 0.9m;
            }

            if (day == Days.Sunday || day == Days.Saturday)
            {
                charge = charge * 1.2m;
            }

            return charge;

        }


        private static decimal GetRentalPrice2(Days day, int numberOfKm)
        {
           decimal charge = 0;

            if (numberOfKm == 1)
            {
                charge = 2;
            }

            if (numberOfKm > 1 && numberOfKm  <= 10 && (day == Days.Sunday || day == Days.Saturday))
            {
                charge = 2 + (1.5m * (numberOfKm - 1)) * 1.2m;
            }
            else if (numberOfKm > 1 && numberOfKm <= 10)
            {
                charge = charge = 2 + (1.5m * (numberOfKm - 1));
            }

            else if (numberOfKm > 10 && !(day == Days.Sunday || day == Days.Saturday))
            {
                charge = 2 + (1.5m * (numberOfKm - 1)) * 1.2m * 0.9m;
            }
            else if (numberOfKm > 10 && (day == Days.Sunday || day == Days.Saturday))
            {
                charge = 2 + (1.5m * (numberOfKm - 1))  * 0.9m;
            }



            return charge;

        }
    }
}

//age = 10;

//if (age < 5)
//{
//    price = 0;
//}
//if (age < 18)
//{
//    price = 5;
//}
//if (age >= 60)
//{
//    price = 6;
//}

//Console.WriteLine(price);


//Console.WriteLine("Please enter a temperature");

//int temperature = int.Parse(Console.ReadLine());

//string message = (temperature <= 0) ? "freezing" : "not freezing";

//Console.WriteLine(message);

