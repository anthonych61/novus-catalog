/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
       
        Stack<int> stk = new Stack<int>(); 
        ListNode current = head;
        
        while(current != null)
        {
            stk.Push(current.val);
            current = current.next;
        }
        
        while(head != null)
        {
            if(head.val != (int)stk.Pop()) 
                return false;
            
            head = head.next;
        }
        return true;
    }
}