using System;
namespace ConsoleAppExercises
{
    public static class Exercises
    {     
            /// <summary>
            /// Two Sum Problem   
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="target"></param>
            /// <returns></returns>
             public static int[] TwoSum(int[] nums, int target)
                { 
                    var map = new Dictionary<int, int>();
                    for (int idx = 0; idx < nums.Length; idx++)
                    {
                        int complement = target - nums[idx];
                        if (map.TryGetValue(complement, out int previousIndex))
                        {
                            return new[] { previousIndex, idx };
                        }
                        map[nums[idx]] = idx;
                    }
                    return Array.Empty<int>();
                }

        /// <summary>
        /// Problem: Find maximum profit from one buy and one sell.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
            {
                int minPrice = int.MaxValue;
                int maxProfit = 0;

                foreach (int price in prices)
                {
                minPrice = Math.Min(minPrice, price);
                maxProfit = Math.Max(maxProfit, price - minPrice);
                }

            return maxProfit;
            }

/// <summary>
/// Removes duplicates from a sorted array in-place and returns the new length of the array.
/// </summary>
/// <param name="nums"></param>
/// <returns></returns>
      public static int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    int write = 1;

    for (int read = 1; read < nums.Length; read++)
    {
        if (nums[read] != nums[read - 1])
            nums[write++] = nums[read];
    }

    return write;
}
        
    
    
        /// <summary>
        /// Creates a linked list from an array of integers.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
          public class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        public static Node CreateLinkedList(int[] values)
        {
            if (values.Length == 0)
                return null;

            Node head = new Node(values[0]);
            Node current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current!.Next = new Node(values[i]);
                current = current.Next;
            }

            return head;
        }

        public static void PrintLinkedList(Node head)
        {
            Node current = head;
            while (current != null)
            {
                System.Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            System.Console.WriteLine("null");
        }

        public static int MissingNumber(int[] nums)
        {
        /// <summary>
        /// Finds the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n.
        /// </summary>          

            int length = nums.Length;
            int expected = length * (length + 1) / 2;
            int actual = nums.Sum();
            return expected - actual;

            // Alternative approach using the sum formula:
            // int lenght = nums.Length;
            // for (int i = 0; i < nums.Length; i++)
            //     {
            //         lenght ^= i;
            //         lenght ^= nums[i];
            // }
            // return lenght;
            }

    }
}

 
      

    