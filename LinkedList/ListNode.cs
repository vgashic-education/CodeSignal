using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListNode
{

    public class ListNode<T>
    {
        public ListNode(T value)
        {
            _value = value;
        }


        public ListNode()
        {

        }


        private T _value;
        public T Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }


        private ListNode<T> _next;

        public ListNode<T> Next
        {
            get
            {
                return _next;
            }

            set
            {
                _next = value;
            }
        }


        #region methods

        public ListNode<T> InsertNodeToEnd(T value)
        {
            ListNode<T> self = this;

            ListNode<T> tmpNode = new ListNode<T>();
            tmpNode.value = value;
            tmpNode.next = null;

            ListNode<T> ptr;

            // if root is empty
            if (self == null)
            {
                self = tmpNode;
            }
            else
            {
                ptr = self;

                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }

                ptr.next = tmpNode;
            }

            return self;

        }


        public ListNode<T> LinkedListFromArray(T[] arr)
        {

            // add first node
            ListNode<T> res = new ListNode<T>() { value = arr[0], next = null };

            // skip first because it's already added
            for (int i = 1; i < arr.Length; i++)
            {
                res.InsertNodeToEnd(arr[i]);
            }

            return res;
        }


        public T[] ToArray()
        {
            ListNode<T> self = this;

            if (self == null)
            {
                return new T[0];
            }

            List<T> list = new List<T>();

            while (self != null)
            {
                list.Add(self.value);
                self = this.next;
            }

            return list.ToArray();

        }


        /// <summary>
        /// This method creates a clone of existing linked list
        /// </summary>
        /// <returns></returns>
        public ListNode<T> Clone()
        {
            Dictionary<T, ListNode<T>> dictClone = new Dictionary<T, ListNode<T>>();

            var self = this;

            while (self != null)
            {
                dictClone.Add(self._value, self.next);
                self = self.next;
            }

            ListNode<T> listClone = new ListNode<T>();

            foreach (var item in dictClone)
            {
                listClone.value = item.Key;
                listClone.next = item.Value;
            }

        }


        public override string ToString()
        {
            return string.Join(',', this.ToArray());
        }


        #endregion
    }

}
