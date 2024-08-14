namespace searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 3, 5, 8, 7, 1, 2, 4 };

            bool flag = true;

            while (flag)
            {

                Console.WriteLine("Select and searching method");
                Console.WriteLine("");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Linear search");
                Console.WriteLine("2.Binary search");

                int opti=int.Parse(Console.ReadLine());

                switch(opti)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine("Linear search");
                        LinearSearch ls = new LinearSearch(arr);
                        ls.LinearSearchIMPL();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Binary search");
                        BinarySearch binarySearch = new BinarySearch(arr);
                        binarySearch.BinarySearchImpl();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }


        }
    }
}
