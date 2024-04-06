using Types_For_Tasks;

namespace Add_Two_Numbers;

public class AddTwoNumbersClass
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

