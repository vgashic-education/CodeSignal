using System;
using static LinkedList.LinkedList;

namespace IsListPalindrome {
    class IsListPalindrome {
        static void Main(string[] args) {
            int[] arr = { 0, 1, 2, 3, 2, 1, 0 };

            ListNode<int> linkedList = LinkedListFromArray(arr);

            isListPalindrome(linkedList);
        }


        private static bool isListPalindrome(ListNode<int> l) {

            int[] arr = l.ToArray();

            for (int i = 0; i < arr.Length/2; i++) {
                if (arr[i] != arr[arr.Length-i-1]) {
                    return false;
                }
            }

            return true;

        }
    }
}
