using System;
using static LinkedList.LinkedList;

namespace RemoveKFromList {

    /*
    Note: Try to solve this task in O(n) time using O(1) additional space,
    where n is the number of elements in the list, since this is what you'll be asked to do during an interview.

    Given a singly linked list of integers l and an integer k, remove all elements from list l that have a value equal to k.

    Example

    For l = [3, 1, 2, 3, 4, 5] and k = 3, the output should be
    removeKFromList(l, k) = [1, 2, 4, 5];
    For l = [1, 2, 3, 4, 5, 6, 7] and k = 10, the output should be
    removeKFromList(l, k) = [1, 2, 3, 4, 5, 6, 7].
    */

    class RemoveKFromList {
        static void Main(string[] args) {

            int[] arr = { 3, 1, 2, 3, 4, 5 };

            var linkedList = LinkedListFromArray(arr);

            removeKFromList(linkedList, 3);

            //Console.ReadLine();

        }


        





        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        static ListNode<int> removeKFromList(ListNode<int> l, int k) {

            ListNode<int> rootNode = l;

            // skip first elements if they are equal to k
            while (rootNode != null && rootNode.value == k) {
                rootNode = rootNode.next;
            }

            ListNode<int> currentNode = rootNode;

            // 
            while (currentNode != null) {

                if (currentNode.next != null && currentNode.next.value == k) {
                    currentNode.next = currentNode.next.next;
                } else {
                    currentNode = currentNode.next;
                }
            }

            return rootNode;

        }
    }


    
}
