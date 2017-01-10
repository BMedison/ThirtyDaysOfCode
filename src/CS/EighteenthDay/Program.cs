using System;
using System.Collections.Generic;
using System.IO;

namespace EighteenthDay
{
    public class Solution
    {
        private Stack<char> _stack = new Stack<char>();
        private Queue<char> _queue = new Queue<char>();
        //Write your code here
        public void PushCharacter(char c)
        {
            _stack.Push(c);
        }

        public void EnqueueCharacter(char c)
        {
            _queue.Enqueue(c);
        }

        public char PopCharacter()
        {
            return _stack.Pop();
        }

        public char DequeueCharacter()
        {
            return _queue.Dequeue();
        }

        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.PushCharacter(c);
                obj.EnqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.PopCharacter() != obj.DequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
            Console.ReadLine();
        }
    }
}
