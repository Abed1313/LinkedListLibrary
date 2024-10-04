Description of the Include Method
 
Whiteboard [Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/Include.jpg)

The Include method checks whether a specified value exists within a linked list. Here’s a detailed breakdown of how the method functions:

Parameter:

The method takes a single integer parameter, data, which represents the value to be searched for within the linked list.
Initialization:

A pointer named current is initialized to the head of the linked list. This pointer will be used to traverse the list.
Traversal:

The method enters a while loop that continues as long as the current pointer is not null (indicating that there are still nodes to check).
Inside the loop, it checks whether the Data field of the current node matches the value of data.
Found Case:

If a match is found, the method prints a message indicating that the list includes the specified data and returns immediately, terminating the method.
Not Found Case:

If the loop completes without finding the data (i.e., current becomes null), the method prints a message indicating that the specified data was not found in the list.
Summary
In summary, the Include method provides a straightforward mechanism for checking the presence of a value in a linked list. It traverses the list from the head to the end, comparing each node’s data with the specified value. If the value is found, it outputs a corresponding message; otherwise, it indicates that the value is not present. The method operates with a time complexity of O(n), where n is the number of nodes in the list, as it may need to traverse all nodes in the worst-case scenario.
