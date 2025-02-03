/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
         
        ListNode tmp = node.next;
        node.val = tmp.val;     //copy data from next node to node to be deleted      
        node.next = tmp.next;   //delete next node
        tmp = node;
        
    }
}