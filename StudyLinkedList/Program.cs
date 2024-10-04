using System.Collections.Generic;

namespace StudyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList linkedList = new LinkedList();
            linkedList.InsertLast(5);
            linkedList.InsertLast(7);
            linkedList.InsertLast(5);
            linkedList.InsertLast(2);
            linkedList.InsertLast(9);
            linkedList.InsertLast(8);

            //Console.WriteLine(linkedList.FindMinValue());
            //Console.WriteLine(linkedList.MaximumValue());


            LinkedList linkedList2 = new LinkedList();
            linkedList2.InsertLast(1);
            linkedList2.InsertLast(2);
            linkedList2.InsertLast(3);
            linkedList2.InsertLast(5);
            linkedList2.InsertLast(2);

            //bool result = linkedList.IsPalindrome();

            //Console.WriteLine(result ? "The linked list is a palindrome." : "The linked list is NOT a palindrome.");


            //Console.WriteLine("List 1:");
            //linkedList.DisplayList();

            //Console.WriteLine("List 2:");
            //linkedList2.DisplayList();

            //LinkedList mergedList = new LinkedList();
            //mergedList.Head = mergedList.MergeSortRecersion(linkedList.Head, linkedList2.Head);

            //Console.WriteLine("Merged List:");
            //mergedList.DisplayList();


            //linkedList.InsertAtPosition(2, 8);
            //linkedList.DisplayList();

            //linkedList.RotateLeft(2);
            //linkedList.DisplayList();

            //Console.WriteLine(linkedList.IsSorted());
            //linkedList.Include(8);


            //int[] linkedListData = linkedList.GetLinkedListData(linkedList);

            //// Output the linked list data
            //Console.WriteLine("Linked List Data:");
            //foreach (int data in linkedListData)
            //{
            //    Console.WriteLine(data);
            //}

            //linkedList.DisplayList();
            ////linkedList.MidelValue();
            //linkedList.DeleteSpecifiedData(4);
            //linkedList.RemoveFirst();
            //linkedList.RemoveLast();

            //linkedList.DisplayList();
            //linkedList.ReveselList();

            //Console.WriteLine();
            //linkedList.DisplayList();

            //List<int> ints = new List<int>();

            //Console.WriteLine(linkedList.MaximumValue());
            //Console.WriteLine(linkedList.FindMinValue());
            ////Console.WriteLine(linkedList.Find(8));

            //Console.WriteLine(linkedList.Sorted());
            //Console.WriteLine(linkedList.IsEmpty());
            //Console.WriteLine(linkedList.DetectCycle());

            //linkedList.DeleteDuplicates();
            //linkedList.DisplayList();


            //LinkedList linkedList1 = new LinkedList();
            //linkedList1.InsertLast(1);
            //linkedList1.InsertLast(2);
            //linkedList1.InsertLast(3);
            //linkedList1.InsertLast(4);
            //linkedList1.InsertLast(5);

            //linkedList1.DisplayList();
        }
    }
}
