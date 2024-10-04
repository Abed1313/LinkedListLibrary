The MaximumValue method is designed to find and return the maximum value stored in a singly linked list. Here’s a detailed breakdown of how it works:
 
Whiteboard [Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/MaximumValue.jpg)

Explanation:
Check if the List is Empty:

The method first checks if the Head is null. If it is, it throws an InvalidOperationException with the message "The list is empty." This ensures that the method does not attempt to access properties of a non-existent node.
Initialize Pointers and Maximum Value:

A current pointer is initialized to the Head of the list to start traversing.
The variable maxValue is initialized to Head.Data, which assumes that the head node contains the maximum value initially.
Traverse the List:

The while loop (while (current.Next != null)) iterates through the list until the current node reaches the second-to-last node. This is important because the last node will need to be checked outside of this loop.
Inside the loop, it compares the Data of the current node to maxValue:
If current.Data is greater than maxValue, it updates maxValue to current.Data.
Check the Last Node:

After the loop, the last node's value is not checked because the loop stops when current.Next is null. To ensure the last node is included in the comparison, you would typically check current.Data one last time, but it is omitted in this implementation.
Return the Maximum Value:

Finally, the method returns the maxValue.
Key Points:
Purpose: To find and return the maximum value from a singly linked list.
Logic:
The method initializes the maximum value to the head node's data and traverses the list to update it as necessary.
Error Handling: It throws an exception if the list is empty, preventing errors that would arise from trying to access Head.Data when Head is null.
Time Complexity: The method runs in O(n) time, where n is the number of nodes in the list, since it traverses each node once.
Space Complexity: The space complexity is O(1) as it uses a fixed amount of extra space (for the current and maxValue variables).
