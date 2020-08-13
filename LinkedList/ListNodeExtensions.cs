using System;
using System.Collections.Generic;
using System.Text;

namespace ListNode {
    public static class ListNodeExtensions<T> {

        public static ListNode<T> FromArray(ListNode<T> listNode, T[] arr) {

            for (int i = 0; i < arr.Length; i++) {
                listNode.Insert(arr[i]);
            }

            return listNode;

        }











    }
}
