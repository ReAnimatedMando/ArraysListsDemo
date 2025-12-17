using System.Collections.Generic;

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

        // var names = new string[] { "Aaron", "Seth", "Cruz" }; // create and initialize array names
        //
        // for (int i = 0; i <= names.Length - 1; i++) // starting at index 0, while i is less than or equal to array length - 1 to get indexes. increment by one through every loop iteration
        // {
        //     Console.WriteLine(names[i]); // write i (counter) to the console
        // }
        //
        // for (int i = names.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(names[i]);
        // }
        
        // Lists
        // Lists have a size that can change all you need

        // List<int> numbersList = new List<int>() { 22, 3, 444, 5, 6 }; // created and initialized with values
        //
        // numbersList.Add(1000); // add value at end of List
        // numbersList.Remove(numbersList[2]); // remove item at given index
        //
        // foreach (int number in numbersList) // foreach loop to go through list items
        // {
        //     Console.WriteLine(number); // write items to console
        // }

        var ourClass = new List<string>()
            { "Seth", "Aaron", "Alex", "Audrey", "Clara", "Nelli", "Ava", "Boba", "Mack", "Maddy" };
        
        // List have a property similar to length... it is called Count
        // Console.WriteLine(ourClass.Count); // get length of List
        // Console.WriteLine(ourClass.Count - 1); // get last index of list

        for (int i = 0; i < ourClass.Count; i++)
        {
            Console.WriteLine(ourClass[i]);
        }

        var numbersCopy = numbers.ToList(); // convert array to list

        var convertBack = numbersCopy.ToArray(); // convert back to array
    }
}