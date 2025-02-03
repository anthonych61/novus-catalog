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
    public ListNode DeleteDuplicates(ListNode head) {
        
        ListNode current = head;

        if(head == null)
        {
            return null;
        }
        else
        {
            while(current.next != null)
            {                  
                if(current.val == current.next.val)
                {
                    current.next = current.next.next; //if same delete next node
                }
                else
                {
                    current = current.next;     //advance if no deletion
                }                
            }
            
        }
        
        return head;
        
    }
}