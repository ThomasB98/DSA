

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int size;
            size = decleareSize();
            int[] arr= new int[size];
            initializeArray(arr);

            bool flag = true;

            while (true)
            {
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Insert at start of Array");
                Console.WriteLine("2: Insert at end of Array");
                Console.WriteLine("3: Insert at anywere in Array");
                Console.WriteLine("4: Delete at start of Array");
                Console.WriteLine("5: Delete at end of Array");
                Console.WriteLine("6: Delete at anywere in Array");
                Console.WriteLine("7: Is Array full");
                Console.WriteLine("8: Find an empty space");
                Console.WriteLine("9: Display Array");

                int option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 0:
                        Console.WriteLine("Exite");
                        flag = false;
                        break;

                    case 1:
                        Console.WriteLine("Insert at start of Array");
                        insertAtStart(arr);
                        break;

                    case 2:
                        Console.WriteLine("Insert at end of Array");
                        insertAtLast(arr);
                        break;

                    case 3:
                        Console.WriteLine("Insert at anywere in Array");
                        insertAnywere(arr);
                        break;
                    case 4:
                        Console.WriteLine("Deleting first element of array");
                        arr[0] = 0;
                        Console.WriteLine("Deletion succesfull");
                        break;
                    case 5:
                        Console.WriteLine("Deleting last element of array");
                        arr[arr.Length-1] = 0;
                        Console.WriteLine("Deletion succesfull");
                        break;
                    case 6:
                        Console.WriteLine("enter position");
                        int posi=int.Parse(Console.ReadLine());
                        if (posi<=arr.Length)
                        {
                            Console.WriteLine("Deleting "+ posi+" element of array");
                            posi--;
                            arr[posi] = 0;
                            Console.WriteLine("Deletion succesfull");
                        }
                        else
                        {
                            Console.WriteLine("Invalid postion");
                        }
                        break;
                       
                

                    case 7:
                        bool fullOrNot=IsArrayFull(arr);
                        if (fullOrNot)
                        {
                            Console.WriteLine("Array is full");
                        }
                        else
                        {
                            Console.WriteLine("Array is not completely filled");
                        }
                        break;

                    case 8:
                        int value=FindEmptyIndex(arr);
                        if (value==-1)
                        {
                            Console.WriteLine("No empty space found");
                        }
                        else
                        {
                            Console.WriteLine("Position "+(value+1) +" is empty");
                        }
                        break;
                    case 9:
                        display(arr);
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
                
            }

        }

        private static void display(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("");
        }

        private static void insertAnywere(int[] arr)
        {
            Console.WriteLine("enter position where you want to insert");
            int length=int.Parse(Console.ReadLine());

            if (arr[length-1] != 0)
            {
                Console.WriteLine("At position " + length + " " + arr[length-1] + " all ready present ");
                bool flag2 = true;
                while (flag2)
                {
                    Console.WriteLine("press 1 to Override");
                    Console.WriteLine("press 2 to Exitr");
                    int yes_no = int.Parse(Console.ReadLine());
                    switch (yes_no)
                    {
                        case 1:
                            Console.WriteLine("Enter Value");
                            arr[length-1] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            flag2 = false;
                            break;
                        case 2:
                            flag2 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Value");
                arr[length-1] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        private static void insertAtLast(int[] arr)
        {
            int length = arr.Length - 1;
            if (arr[length] != 0)
            {
                Console.WriteLine("At position " + arr.Length + " " + arr[arr.Length - 1] + " all ready value present ");
                bool flag2 = true;
                while (flag2)
                {
                    Console.WriteLine("press 1 to Override");
                    Console.WriteLine("press 2 to Exitr");
                    int yes_no = int.Parse(Console.ReadLine());
                    switch (yes_no)
                    {
                        case 1:
                            Console.WriteLine("Enter Value");
                            arr[length] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            flag2 = false;
                            break;
                        case 2:
                            flag2 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Value");
                arr[length] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        private static void initializeArray(int[] arr)
        {
            for (int i = 0;i<arr.Length;i++)
            {
                arr[i] = 0;
            }
        }

        private static void insertAtStart(int[] arr)
        {
            if (arr[0] != 0)
            {
                Console.WriteLine("At position "+1+" " + arr[0] +" all ready value present ");
                bool flag2 = true;
                while (flag2)
                {
                    Console.WriteLine("press 1 to Override");
                    Console.WriteLine("press 2 to Exitr");
                    int yes_no=int.Parse(Console.ReadLine());
                    switch(yes_no)
                    {
                        case 1:
                            Console.WriteLine("Enter Value");
                            arr[0] = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            flag2 = false;
                            break;
                        case 2:
                            flag2= false;
                            break;
                        default :
                            Console.WriteLine("Invalid selection");
                            break ;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter Value");
                arr[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            
        }

        public static bool IsArrayFull(int[] array)
        {
            foreach (var item in array)
            {
                if (item == 0) // Assuming 0 is the default or "empty" value
                {
                    return false;
                }
            }
            return true;
        }

        public static int FindEmptyIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) // Assuming 0 is the default or "empty" value
                {
                    return i; // Return the index of the first empty element
                }
            }
            return -1; // Return -1 if no empty element is found, meaning the array is full
        }

        static int decleareSize()
        {
            int size = 0;
            Console.WriteLine("Enter Size of Array");
            bool ans = int.TryParse(Console.ReadLine(), out size);
            if (ans) {
                return size;
            }
            else
            {
                decleareSize();
            }
            return size;
        }
    }
}
