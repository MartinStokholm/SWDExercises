using System;
namespace ArrayGeneratorApp
{
    public interface ISortingStrategy
    {
        void Sort(int[] array);
    }
    public class InsertionSort : ISortingStrategy
    {
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
        }
    }
    public class BubbleSortStrategy : ISortingStrategy
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
    public class DisplayArray
    {
        public void Display(int[] array)
        {
            foreach (int element in array)
            {
                Console.WriteLine($"number is {element}");
            }
        }
    }
    public class SuperSorter 
    {
        public SuperSorter(ISortingStrategy sortingStrategy)
        {
            SortingStrategy = sortingStrategy;
        }
        private ISortingStrategy _sortingStrategy;
        public ISortingStrategy SortingStrategy 
        { 
            get { return _sortingStrategy; } 
            set { _sortingStrategy = value; } 
        }
        public void Sort(int[] array)
        {
            _sortingStrategy.Sort(array);
        }
    }
    public class ArrayGenerator
    {
        public int[] Generate(int size, int seed)
        {
            // Create int array with size param
            int[] array = new int[size];
            // Create random number generator using seed param
            Random r = new Random(seed);
            // Fill the array with random numbers
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next() % 500+1;
            }
            return array;
        }
    }
    public class App
    {
        public static void Main(string[] args)
        {
            ArrayGenerator ag = new ArrayGenerator();
            DisplayArray da = new DisplayArray();
            SuperSorter ss = new SuperSorter(new BubbleSortStrategy());
            
            // Generate random numbers for array
            int[] array = ag.Generate(5, 42069);  
            System.Console.WriteLine("Unsorted array...");
            da.Display(array); 

            // Sort array with bubble sort strategy
            System.Console.WriteLine("Sorting array... With bubble sort");
            ss.Sort(array);
            da.Display(array);

            // generate new values for array
            array = ag.Generate(5, 17174);  
            System.Console.WriteLine("Unsorted array... new values");
            ss.Sort(array);
            da.Display(array);

            // Sort array with insertion sort strategy
            System.Console.WriteLine("Sorting array... With insertion sort");
            ss.SortingStrategy = new InsertionSort();
            ss.Sort(array);
            da.Display(array);
        }        
    }
}

