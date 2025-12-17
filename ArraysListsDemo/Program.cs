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

        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
        
        // Arrays have a property called "Length" that shows the number of items in the Array
        // Console.WriteLine(numbers.Length); // returns length of array
        // Console.WriteLine(numbers.Length - 1); // returns last index

        var names = new string[] { "Aaron", "Seth", "Cruz" }; // create and initialize array names

        for (int i = 0; i <= names.Length - 1; i++) // starting at index 0, while i is less than or equal to array length - 1 to get indexes. increment by one through every loop iteration
        {
            Console.WriteLine(names[i]); // write i (counter) to the console
        }

        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }
    }
}