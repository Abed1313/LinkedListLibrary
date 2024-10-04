Linked List - InsertFirst Method
 
Whiteboard [Link](https://github.com/Abed1313/LinkedListLibrary/blob/master/StudyLinkedList/assest/InsertFirst.jpg)

Overview
This repository demonstrates the InsertFirst method in a singly linked list. The method allows you to insert a new node with a specified data value at the beginning of the linked list.

Method Definition
public void InsertFirst(int data)
{
    Node newNode = new Node()
    {
        Data = data,
        Next = Head
    };
    Head = newNode;
}

How It Works
The InsertFirst method performs the following steps:

Create a new node: A new instance of the Node class is created. This node will hold the data provided as a parameter.
Set node data: The data property of the new node is assigned the value of data passed to the method.
Link new node to the list: The Next pointer of the new node is set to point to the current head of the list. This connects the new node to the existing list.
Update the head: The head of the list is updated to be the newly created node, making it the new first element of the list.
Before and After Example
Assuming the linked list initially looks like this:

Head -> Node1 -> Node2 -> Node3 -> NULL

After calling InsertFirst(5):
Head -> NewNode(5) -> Node1 -> Node2 -> Node3 -> NULL

Example Use Case:

// Assuming LinkedList is the class containing InsertFirst method
LinkedList list = new LinkedList();
list.InsertFirst(5);  // Inserting 5 at the start of the list
list.InsertFirst(10); // Inserting 10 at the start of the list

