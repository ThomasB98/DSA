namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 3, 5, 8, 7, 1, 2, 4 };

            bool flag = true;

            while (flag)
            {

                Console.WriteLine("Select and Sorting method");
                Console.WriteLine("");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Bubble Sort");
                Console.WriteLine("2.Selection Sort");
                Console.WriteLine("3.Insertion Sort");
                Console.WriteLine("4.Merge Sort");
                int opti = int.Parse(Console.ReadLine());

                switch (opti)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine("Bubble Sort");
                        BubbleSort bs=new BubbleSort(arr);
                        bs.BubbleSortImpl();
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Selection Sort");
                        SelectionSort ss=new SelectionSort(arr);
                        ss.SelectionSortImpl();
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Insertion Sort");
                        InsertionSort ins=new InsertionSort(arr);
                        ins.InsertionSortImpl();
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("Merge Sort");
                        MergeSort mgs=new MergeSort(arr);
                        mgs.Sort();
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
