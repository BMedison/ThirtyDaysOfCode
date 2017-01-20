using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class Program
    {
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            return null;
        }

        public static  Node insert(Node head, int data)
        {
            Node p = new Node(data);
            
            
            if(head == null)
                head = p;
            else if(head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while(start.next != null)
                    start = start.next;
                start.next = p;
                
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while(start != null)
            {
                Console.Write(start.data + " ");
                start=start.next;
            }
        }

        public static void Main(string[] args)
        {
            Node head = null;

            head = insert(head, 1);
            head = insert(head, 2);
            head = insert(head, 2);
            head = insert(head, 3);
            head = insert(head, 3);
            head = insert(head, 4);
      	    head = removeDuplicates(head);
		    display(head);
        }
    }
}
