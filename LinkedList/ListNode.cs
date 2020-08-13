using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListNode {

    public class ListNode<T> {
        public ListNode(T value) {
            _value = value;
        }


        public ListNode() {
        }


        private T _value;
        public T Value {
            get {
                return _value;
            }

            set {
                _value = value;
            }
        }


        private ListNode<T> _next;
        public ListNode<T> Next {
            get {
                return _next;
            }

            set {
                _next = value;
            }
        }


        #region methods

        public void Insert(T value) {

            ListNode<T> tempNode = new ListNode<T>();
            tempNode.Value = value;
            tempNode.Next = null;

            ListNode<T> pointerNode;

            pointerNode = this;

            // loop through linked list to the last element
            while (pointerNode.Next != null) {
                pointerNode = pointerNode.Next;
            }

            // add new node to the end of list
            pointerNode.Next = tempNode;


        }


        /// <summary>
        /// Print linked list nodes
        /// </summary>
        /// <param name="listNode"></param>
        /// <returns></returns>
        public string Print() {

            ListNode<T> temp = this;

            if (this == null) {
                return "";
            }

            StringBuilder sb = new StringBuilder();

            while (temp != null) {
                sb.Append($"{temp.Value}, ");
                temp = temp.Next;
            }

            return sb.ToString().Substring(0, sb.ToString().Length - 2);

        }


        #endregion

    }

}
