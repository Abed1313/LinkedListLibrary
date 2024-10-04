Whiteboard [Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/FindMinValue.jpg)
 
 The FindMinValue method is designed to find and return the minimum value in a singly linked list. Here’s a detailed breakdown of its implementation:

Explanation:
Check for Empty List:

The method begins by checking if the Head of the list is null. If it is, an InvalidOperationException is thrown with the message "The list is empty." This ensures that the method cannot proceed with an empty list.
Initialize Pointers:

A pointer called current is initialized to point to the Head of the linked list. This pointer will be used to traverse the list.
An integer variable minValue is initialized with the value of the Data of the Head node, assuming the head contains the minimum value initially.
Traverse the List:

A while loop (while (current.Next != null)) iterates through the nodes of the linked list until it reaches the last node (when current.Next is null).
Update Minimum Value:

Inside the loop, an if statement checks if the Data of the current node is less than minValue. If it is, minValue is updated to the current node's Data.
Move to Next Node:

After checking the current node, the method advances the current pointer to the next node (current = current.Next).
Return Minimum Value:

After traversing the entire list, the method returns minValue, which now holds the smallest value found in the list.
Key Points:
Purpose: To find and return the minimum value in the linked list.
Logic: The method iterates through each node in the list while maintaining the minimum value found so far.
Time Complexity: O(n), where n is the number of nodes in the linked list. The method visits each node exactly once.
Space Complexity: O(1), as it uses a fixed amount of additional space regardless of the list size.
Potential Improvements:
Handling Edge Cases: The method already handles the edge case of an empty list by throwing an exception, which is a good practice.
