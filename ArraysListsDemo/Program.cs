namespace ArraysListsDemo;

class Program
{
    static void Main(string[] args)
    {
        // Arrays
        // Arrays have a set size that define at creation and that size cannot change
        int[] numbers = new int[] {22, 4, 1, 100, 4}; // initializing values at creation of array
        
        // assigning values after creation by indexing and adding values
        // numbers[0] = 4000;
        // numbers[1] = 23;
        // numbers[2] = 65;
        // numbers[3] = 22;
        // numbers[4] = 987;

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}