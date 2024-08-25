
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
public class MyClass
{
  public static int Sum(params int[] numbers)
    {
        int sum = 0; // Fixed variable name to lowercase 'sum'
        foreach (var num in numbers)
        {
            sum += num; // Corrected logic: add num to sum
        }
        return sum;
    }

}
class Test
{
    public static void Main(string[] args)
    {
        /*
        // Initialize the array with a size of 2
        string[] names = new string[2] { "mk", "gu" };

        // Initialize another array without specifying size
        string[] name = { "mk", "gu", "ggg" };

        // Corrected loop to use names.Length to dynamically get the array size
        for (int index = 0; index < names.Length; index++)
        {
            Console.WriteLine(names[index]);
        }

        // Corrected the variable name to match the array being accessed
        for (int inde = 0; inde < name.Length; inde++)
        {
            Console.WriteLine(name[inde]);
        }

        // Corrected the foreach loop syntax and logic
        foreach (string nameItem in names)
        {
            Console.WriteLine(nameItem);
        }
    }
   
    int[] numbers= {10,-20,30};

    int sum = 0;

foreach (int number in numbers){
    if(number>0){
        Console.WriteLine(number);
    }
}
        // {
        //     sum = sum+number;

        // }
        //     Console.WriteLine(sum);
        
         
int [,] matrix ={{1,2,3},{4,5,6}};
for (int row=0;row<2;row++){
    for(int col=0;col<3;col++)
    {
     Console.Write(matrix [row,col]);
    }
Console.WriteLine();

}
 
 // Declare a jagged array with 3 rows
        int[][] jaggedArray = new int[][]{
              // Initialize each row with different lengths
        new [] { 1, 2 },
        new [] { 1, 2, 5, 6 },
        new [] { 1, 2, 4 },
        new [] { 1, 2, 6, 3, 8 }

        };
        
      

        // Loop through each row of the jagged array
        foreach(var row in jaggedArray ){
            foreach (var item in row)
            {
                Console.Write($"{item}");
            }
            Console.WriteLine();
        }
        // {
        //     // Loop through each element in the current row
        //     for (int col = 0; col < jaggedArray[row].Length; col++)
        //     {
        //         // Print the element followed by a space
        //         Console.Write($"{jaggedArray[row][col]} ");
        //     }
        //     // Print a new line after each row
        //     Console.WriteLine();
        // }

        Console.ReadKey();  
 
 try
        {
            Console.Write("How many elements do you want: ");
            int size = int.Parse(Console.ReadLine());

            if (size <= 0)
            {
                Console.WriteLine("The array size must be a positive number.");
                return;
            }

            int[] numbers = new int[size];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Maximum element of the array: {max}");
            Console.WriteLine($"Minimum element of the array: {min}");
            Console.WriteLine($"Sum of the array: {sum}");
            Console.WriteLine($"Avg of the array: {(float)sum/numbers.Length}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        

        int[] numbers= {3,4,5,6,7};
        Console.WriteLine($"Length of the array:{numbers.Length}");
        Console.WriteLine($"Length of the array:{numbers.Rank}");
        Console.WriteLine ($"Maximum value of arrya:"+numbers.Max());
        Console.WriteLine ($"Minimum value of arrya:"+numbers.Min());
        Console.WriteLine ($"Maximum value of arrya:"+numbers.Sum());
        Console.WriteLine ($"Maximum value of arrya:"+numbers.Average());

Console.Write($"Before Sorrting");
PrintArray(numbers);

Array.Sort(numbers);
Console.Write($"after Sorrting:");
PrintArray(numbers);

Array.Reverse (numbers);
Console.Write($"after Reversing :");
PrintArray(numbers);

int index = Array.IndexOf(numbers, 8);
Console.WriteLine($"Index of value of 8:{index}");

bool exists = Array.Exists(numbers,number => number ==6);
Console.WriteLine($"does array contain value of 5:{exists}");

int[]copy = new int[numbers.Length ];
Array.Copy(numbers,copy,numbers.Length);
Console.Write($"Copied array:");
PrintArray(copy);
Array.Clear(copy,0,copy.Length);

PrintArray(copy);
Console.ReadKey();
    }   

    public static void PrintArray(int[] numbers){
        foreach(var item in numbers){
            Console.Write($"{item}");
        }
        Console.WriteLine();

        */
        Console.WriteLine(MyClass.Sum(10, 20));            // Output: 30
        Console.WriteLine(MyClass.Sum(10, 20, 39));        // Output: 69
        Console.WriteLine(MyClass.Sum(10, 20, 20, 40));    // Output: 90
        Console.WriteLine(MyClass.Sum(10, 20, 39, 50, 40)); // Output: 159
    }
}
