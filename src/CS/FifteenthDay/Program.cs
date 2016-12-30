using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenthDay
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
        public static Node insert(Node head, int data)
        {
            //Complete this method
            Node node = head;
            if (node == null)
            {
                node = new Node(data);
                head = node;
                return head;
            }else
            {
                while (node.next != null)
                {
                    node = node.next;
                }
            }

            node.next = new Node(data);
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {
            Node head = null;
            int T = Int32.Parse("4");
            int data = 0;
            data = Int32.Parse("2");
            head = Program.insert(head, data);
            data = Int32.Parse("3");
            head = Program.insert(head, data);
            data = Int32.Parse("4");
            head = Program.insert(head, data);
            data = Int32.Parse("1");
            head = Program.insert(head, data);
            Program.display(head);
        }
    }
}
