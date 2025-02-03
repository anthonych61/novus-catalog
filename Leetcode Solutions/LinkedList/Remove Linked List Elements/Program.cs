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
 
// Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        
        while(head != null && head.val == val) head = head.next;
     
        ListNode current = head;
        
        while(current != null && current.next != null) 
        {            
            if(current.next.val == val) { //compare each node with next node
         
                current.next = current.next.next;   //if same delete next node
            }
            else
            {                
                current = current.next; //advance if no deletion
            }                
        }
         
        return head;
        
    }
}