using System.Net.Http.Headers;

namespace LeetCodeCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            Console.WriteLine("[{0}]", string.Join(", ", Task1.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine("[{0}]", string.Join(", ", Task1.TwoSum(new int[] { 3, 3 }, 6)));
            Console.WriteLine("[{0}]", string.Join(", ", Task1.TwoSum(new int[] { 3, 2, 4 }, 6)));
            Console.WriteLine("[{0}]", string.Join(", ", Task1.TwoSum(new int[] { 5, 2, 7 }, 12)));
            Console.WriteLine("[{0}]", string.Join(", ", Task1.TwoSum(new double[] { 188.5, 188.5, 187.5, 189.5 }, 377)));

            #endregion

            #region Task2

            Console.WriteLine(Task2.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).val); // 7 -> 0 -> 8
            Console.WriteLine(Task2.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.val); // 7 -> 0 -> 8
            Console.WriteLine(Task2.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4)))).next.next.val); // 7 -> 0 -> 8

            #endregion
        }
    }

    public static class Task1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        public static double[] TwoSum(double[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new double[] { i, j };
                    }
                }
            }
            return null;
        }
    }

    public static class Task2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0) // to keep running if we have a value in l1, l2 or carry
            {
                // two if statments because l1 and l2 can be of different sizes
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10); //digit
                sum /= 10; //carry
                result = result.next;
            }
            return head.next;
        }
    }

    public static class Task3
    {
        public static int LengthOfLongestSubstring(string s)
        {
            return 3;
        }

    }

    #region Types for tasks

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    #endregion
}