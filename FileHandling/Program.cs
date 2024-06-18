namespace FileHandling
{
    internal class Program
    {



        /// <summary>
        /// This method takes the name of a file and reads in a set of
        /// records from that file. It keeps a running total of the salary in each
        /// record and returns that.
        /// If there is a file handling error the error is printed to the console and
        /// -1 is returned.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A running total of the salary</returns>
        static int CSV_Demo(string path)
        {
            string? lineIn;
            int salary;
            int totalSalaries = 0;





            try
            {

                using (StreamReader sr = File.OpenText(path))
                {

                    lineIn = sr.ReadLine(); // get first record 

                    while (lineIn != null) // keep going until we get to the end signalled by a null 

                    {
                        string[] fields = lineIn.Split(','); // split input using ','


                        totalSalaries = totalSalaries + int.Parse(fields[3]);


                        lineIn = sr.ReadLine(); // get the next record 

                    }
                }
                return totalSalaries;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found {ex.Message}");
                return -1;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"opps {ex.Message}");
            //    return -1;
            //}
        }





        static void Main(string[] args)
        {
            string path = @"..\..\..\demo.txt";

            string path2 = @"..\..\..\employee.txt";

            Console.WriteLine(CSV_Demo(path2));

            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine("Ireland, \n Ireland");
            //    sw.WriteLine("Together standing tall");
            //    sw.WriteLine("Shoulder to shoulder");
            //    sw.WriteLine("We'll answer Ireland's call!");

            //}



            using (StreamReader sr = File.OpenText(path))
            {
                string? lineIn = sr.ReadLine();

                while (lineIn != null)
                {
                    Console.WriteLine(lineIn);
                    lineIn = sr.ReadLine();
                }
            }



        }
    }
}