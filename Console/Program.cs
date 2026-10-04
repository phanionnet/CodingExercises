using System;
namespace ConsoleAppExercises
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine("Hello, Console App Exercises!");
            while (true)
            {   
                System.Console.WriteLine("Choose an exercise to run(or type 'exit' to quit):");
                System.Console.WriteLine("1. Two Sum Problem");      
                System.Console.WriteLine("2. Maximum Profit from Stock Prices");  
                System.Console.WriteLine("3. Remove Duplicates from Sorted Array");    
                System.Console.WriteLine("4. Find Missing Number");                  
                System.Console.WriteLine("5. Create Linked List");                  
                var choice = System.Console.ReadLine();
                if (choice?.ToLower() == "exit")
                {
                    break;
                }       
          
                switch (choice)
                {   
                    case "1":
                        System.Console.Write("Enter a list of numbers separated by commas (e.g., 2,7,11,15):");
                        var input = System.Console.ReadLine();
                        int[] parsedNums = Array.ConvertAll((input ?? throw new InvalidOperationException("No numbers were entered.")).Split(','), int.Parse);
                        System.Console.Write("Enter the target sum:");
                        var parsedTarget = int.Parse(System.Console.ReadLine() ?? throw new InvalidOperationException("No target sum was entered."));
                        var result = Exercises.TwoSum(parsedNums, parsedTarget);
                        if (result.Length > 1 )            
                        {
                        System.Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
                        }
                        else
                        {
                        System.Console.WriteLine("No two sum solution found.");
                        }                    
                        break;
                    case "2":
                        System.Console.Write("Enter a list of prices separated by commas:");
                        var prices = System.Console.ReadLine();
                        int[] parsedPrices = Array.ConvertAll((prices ?? throw new InvalidOperationException("No prices were entered.")).Split(','), int.Parse);
                        var maxProfit = Exercises.MaxProfit(parsedPrices);
                        System.Console.WriteLine($"Maximum profit: {maxProfit}");
                        break;
                    case "3":
                        System.Console.Write("Enter a list of numbers separated by commas (e.g., 1,1,2,3,3):");
                        var numbers = System.Console.ReadLine();
                        int[] numberarray = Array.ConvertAll((numbers ?? throw new InvalidOperationException("No numbers were entered.")).Split(','), int.Parse);
                        var newLength = Exercises.RemoveDuplicates(numberarray);
                        System.Console.WriteLine($"New length: {newLength}");
                        break;
                        case "4":
                        System.Console.Write("Enter a list of numbers separated by commas:");
                        var missingNum = System.Console.ReadLine();
                        int[] missingNumbers = Array.ConvertAll((missingNum ?? throw new InvalidOperationException("No numbers were entered.")).Split(','), int.Parse);
                        int missedNumber = Exercises.MissingNumber(missingNumbers);
                        System.Console.WriteLine($"Missing number: {missedNumber}");
                        break;
                    case "5":
                        System.Console.Write("Enter Node values by seperate with Comma e.g 3,4,1,):");
                        var nodeValues =  System.Console.ReadLine();
                        int[] nodeArray = Array.ConvertAll((nodeValues ?? throw new InvalidOperationException("No numbers were entered.")).Split(','), int.Parse);
                        var head = Exercises.CreateLinkedList(nodeArray);
                        System.Console.WriteLine("Linked list created.");
                        Exercises.PrintLinkedList(head);
                        break;
                    default:
                        System.Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}             



