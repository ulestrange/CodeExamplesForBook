namespace SwitchExample
{
    class Program
    {
        enum DayName
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {

            // read in a number between 1 and 7 representing days of the week
            // output the correspoding day name
            int dayNum;
            string message;



            Console.WriteLine("Enter day number : ");
            dayNum = int.Parse(Console.ReadLine());



            Console.WriteLine((DayName)dayNum);


            switch (dayNum)
            {
                case 1: // when dayNum has a value of 1 execute this case
                    message = DayName.Monday.ToString();
                    break;
                case 2:
                    message = "Tuesday";
                    break;
                case 3:
                    message = "Wednesday";
                    break;
                case 4:
                    message = "Thursday";
                    break;
                case 5:
                    message = "Friday";
                    break;
                case 6:
                    message = "Saturday";
                    break;
                case 7:
                    message = "Sunday";
                    break;

                default:
                    message = "error";
                    break;
            }




            Console.WriteLine(message);

        }

    }
}