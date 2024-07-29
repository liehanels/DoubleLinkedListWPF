using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedListWPF
{
    internal class DoublyLinkedList : IEnumerable<Node>
    {
        private Node head;
        private Node tail;
        public Node First { get { return head; } }
        public Node Last { get { return tail; } }
        public int Length { get; private set; }

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerable GetEnumeratorReverse()
        {
            Node current = tail;
            while (current != null)
            {
                yield return current;
                current = current.Previous;
            }
        }
        public void AddLast(string data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
            }
            tail = newNode;
            Length++;
        }
        public void AddFirst(string data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            if(head == null)
            {
                tail = newNode;
            }
            else
            {
                newNode.Previous = newNode;
            }
            head = newNode;
            Length++;
        }
        public bool Contains(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public Node Find(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public Node FindLast(string value)
        {
            Node current = tail;
            while (current != null)
            {
                if(current.Data == value)
                {
                    return current;
                }
                current = current.Previous;
            }
            return null;
        }
        public bool Remove(string value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    if (current.Next == null) { tail = current.Previous; }
                    else { current.Next.Previous = current.Previous; }
                    if (current.Previous == null) { head = current.Next; }
                    else { current.Previous.Next = current.Next; }
                    current = null;
                    Length--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void RemoveFirst()
        {
            if (head != null) 
            { 
                head = head.Next; 
                if (head == null) { tail = null; }
                Length--;
            }
        }
        public void RemoveLast()
        {
            if (tail != null)
            {
                tail = tail.Previous;
                if (tail == null) { head = null; }
                Length--;
            }
        }
    }
}
