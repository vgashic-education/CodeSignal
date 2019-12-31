using System;

namespace RemoveKFromList {
    class RemoveKFromList {
        static void Main(string[] args) {

            int[] arr = { 3, 1, 2, 3, 4, 5 };

            var linkedList = LinkedListFromArray(arr);

        }


        static ListNode<int> LinkedListFromArray(int[] arr) {

            ListNode<int> res = null;

            for (int i = 0; i < arr.Length; i++) {
                res = InsertNode(res, arr[i]);
            }

            return res;
        }


        static ListNode<int> InsertNode(ListNode<int>, int value) {

            ListNode<int> tmpNode = new ListNode<int>();

        }


        // Singly-linked lists are already defined with this interface:
        // class ListNode<T> {
        //   public T value { get; set; }
        //   public ListNode<T> next { get; set; }
        // }
        //
        ListNode<int> removeKFromList(ListNode<int> l, int k) {

            throw new NotImplementedException();

        }
    }


    class ListNode<T> {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    }
}
