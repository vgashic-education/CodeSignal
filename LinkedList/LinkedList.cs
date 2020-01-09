using System;
using System.Collections.Generic;

namespace LinkedList {
    public static class LinkedList {

        public class ListNode<T> {

            public T value { get; set; }

            public ListNode<T> next { get; set; }


            #region methods

            public ListNode<T> InsertNodeToEnd(ListNode<T> root, T value) {

                ListNode<T> tmpNode = new ListNode<T>();
                tmpNode.value = value;
                tmpNode.next = null;

                ListNode<T> ptr;

                // if root is empty
                if (root == null) {
                    root = tmpNode;
                } else {
                    ptr = root;

                    while (ptr.next != null) {
                        ptr = ptr.next;
                    }

                    ptr.next = tmpNode;
                }

                return root;

            }

            #endregion
        }



        public static ListNode<int> LinkedListFromArray(int[] arr) {

            // add first node
            ListNode<int> res = new ListNode<int>() { value = arr[0], next = null };

            // skip first because it's already added
            for (int i = 1; i < arr.Length; i++) {
                res.InsertNodeToEnd(res, arr[i]);
            }

            return res;
        }

        
        
        public static int[] ToArray (this ListNode<int> linkedList) {

            if (linkedList == null) {
                return new int[0];
            }

            List<int> list = new List<int>();

            while (linkedList != null) {
                list.Add(linkedList.value);
                linkedList = linkedList.next;
            }

            return list.ToArray();

        }

    }
}
