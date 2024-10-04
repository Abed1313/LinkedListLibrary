Description of the RotateLeft Method
 
Whiteboard [Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/RotateLeft.jpg)

The RotateLeft method rotates the linked list to the left by a specified number of positions, K. Here’s a detailed breakdown of how the method functions:

Parameter:

The method takes an integer parameter, K, which represents the number of positions to rotate the linked list to the left.
Initialization:

A pointer named current is initialized to the head of the linked list. This pointer will be used to access the nodes during the rotation process.
Rotation Logic:

The method enters a while loop that continues as long as K is not equal to zero. This loop will perform the rotation K times.
Inside the loop:
The InsertLast(current.Data) method is called, which presumably adds the data from the current node to the end of the linked list.
The DeleteSpecifiedData(current.Data) method is then called to remove the current node from its original position in the list.
The current pointer is updated to point to the next node (current.Next) in the list.
The K counter is decremented by one.
End of Rotation:

The loop continues until all K rotations are performed, effectively shifting the nodes to the left by K positions.
Summary
In summary, the RotateLeft method is designed to rotate the linked list to the left by a specified number of positions (K). It does this by repeatedly moving the current node’s data to the end of the list while simultaneously removing that node from its original position. The method operates with a time complexity of O(n * K), where n is the number of nodes in the list and K is the number of rotations, as it potentially traverses the list multiple times for each rotation.

Note: The implementation may not handle edge cases properly, such as when K is larger than the size of the list or if the list is empty, which could lead to unexpected behavior or errors. It might also be more efficient to use a different approach to achieve rotation without repeatedly deleting and inserting nodes.
