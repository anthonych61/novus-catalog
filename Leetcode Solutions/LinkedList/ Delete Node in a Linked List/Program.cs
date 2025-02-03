/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// Write a function to delete a node in a singly-linked list. You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
// It is guaranteed that the node to be deleted is not a tail node in the list.
 
// The solution is to copy the data from the next node to the node to be deleted and delete the next node. Something like this:
// It is important to note that this approach will only work if it is guaranteed that the given pointer does not point to the last node. 
// Because if it is the last node, then you don’t have a next node to copy the data from.
public class Solution {
    public void DeleteNode(ListNode node) {
        
        node.val = node.next.val;   //copy data from next node to node to be deleted  
        node.next = node.next.next;  //delete next node
    }
}