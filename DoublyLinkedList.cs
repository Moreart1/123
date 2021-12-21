using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1._1
{
    class DoubleLinkedList : ILinkedList
    {
        private Node head ;
        private Node tail ;
       
        public int Length {get;set;}


        public void AddNodeAfter(Node node, int value)
        {
            Node current = head.NextNode;
            while (current != tail && current != node)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                current.NextNode = new()
                {
                    Value = value,
                    PrevNode = current,
                    NextNode = current.NextNode
                };
            }
            else
            {
                throw new ArgumentException("Такого элемента нет в списке.", nameof(node));
            }
        }
        

        public void AddNode(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (tail==null)
            {
                head = newNode;
            }
            else
            {
                newNode.PrevNode = tail;
                tail.NextNode = newNode;
            }
            tail = newNode;
            Length++;
        }

        public Node FindNode(int searchValue)
        {
            Node current = head.NextNode;
            while (current != tail && current.Value != searchValue)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail)
            {
                current = current.NextNode;
                count++;
            }
            return count;

        }

        public void RemoveNode(int index)
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail && count < index)
            {
                current = current.NextNode;
                count++;
            }
            if (count == index)
            {
                RemoveNode(current);
            }
            else
            {
                throw new ArgumentException("Элемента с таким индексом нет в списке.", nameof(index));
            }
        }

        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;

            next.PrevNode = prev;
            prev.NextNode = next;
        }
        public void PrintList()
        {
            string list = "";
            Node current = head;
            while (current != null)
            {
                list += $"{current.Value}";
                current = current.NextNode;
            }
            Console.WriteLine(list);
        }
    }
}
