Whiteboard
[Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/DeleteDuplicates.jpg)
 The DeleteDuplicates method is designed to remove duplicate values from a singly linked list. Here's a detailed breakdown of how it works:

Explanation:
Initialize Current Pointer:

The method starts by initializing a pointer called current, which points to the Head of the linked list. This pointer is used to traverse the list.
Outer While Loop:

The outer while loop (while (current != null)) iterates through each node in the list. The current pointer represents the node whose duplicates will be removed.
Initialize Runner Pointer:

For each node represented by current, another pointer called runner is initialized to point to the same node as current. The runner pointer is used to check subsequent nodes for duplicates.
Inner While Loop:

The inner while loop (while (runner.Next != null)) checks all nodes that come after the current node. It continues as long as runner is not pointing to the last node.
Duplicate Check:

Inside the inner loop, the method checks if the data of the next node (runner.Next.Data) is equal to the data of the current node (current.Data).
If a duplicate is found:
The runner.Next pointer is updated to skip the duplicate node by pointing to the node after it (runner.Next = runner.Next.Next).
If no duplicate is found, the runner pointer moves to the next node (runner = runner.Next).
Move to Next Node:

After processing all duplicates for the current node, the method moves the current pointer to the next node in the list (current = current.Next).
Key Points:
Purpose: To remove duplicate values from the linked list, ensuring that each value appears only once.
Logic:
The method uses a two-pointer approach: current to track the node being checked and runner to check for duplicates in the remainder of the list.
Time Complexity: O(n²) in the worst case, where n is the number of nodes in the linked list, since for each node, it may traverse the remaining nodes to check for duplicates.
Space Complexity: O(1), as it uses a fixed amount of space regardless of the list size.
Potential Improvements:
Handling Edge Cases: If the list is empty (Head is null), the method will handle it gracefully due to the outer loop condition.
Sorting: If the linked list is sorted, you could potentially optimize the duplicate removal process to O(n) time complexity by only iterating through the list once and checking adjacent nodes.
