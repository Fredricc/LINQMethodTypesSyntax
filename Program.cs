namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using LINQ : Query syntax type.");
            //Step 1: Creat the data source
            List<int> numberList = new List<int> { 1, 2, 3, 5, 6, 7, 8 };

            //Step 2: Creat the query
            var query = from n in numberList
                        where n <= 3
                        select n;

            IEnumerable<int> query2 = numberList.Where(i => i <= 3);

            //Step 3: Execute query
            foreach (var nn in query)
            {
                Console.WriteLine(nn);
            }
            Console.WriteLine("Using LINQ : Method syntax type.");

            foreach (var ii in query2)
            {
                Console.WriteLine(ii);
            }
        }
    }
}