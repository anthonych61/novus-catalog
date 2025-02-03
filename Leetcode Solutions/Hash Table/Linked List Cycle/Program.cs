/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

// Given head, the head of a linked list, determine if the linked list has a cycle in it.
// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
// Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
// Return true if there is a cycle in the linked list. Otherwise, return false.

// Complexity Analysis:  
// Time complexity: O(n). 
// Only one traversal of the loop is needed.
// Auxiliary Space: O(n). 
// n is the space required to store the value in hashmap.
public class Solution {
    public bool HasCycle(ListNode head) {
        
        HashSet<ListNode> hs = new HashSet<ListNode>(); 
        while(head != null)
        {
            // If this node is already traverse
            // it means there is a cycle
            if(hs.Contains(head))
                return true;
            
            // If we are seeing the node for
            // the first time, insert it in hash
            hs.Add(head);
            head = head.next;
        }        
        return false;
        
    }
}