using System;

namespace BST
{
    public class BinarySearchTree
    {
        private Node _root = null;
        private Node Insert(Node root, int data)
        {
            if(root == null)
            {
                return new Node(data);
            }

            Node cur;
            if(data <= root.data)
            {
                cur = Insert(root.left, data);
                root.left = cur;
            } else
            {
                cur = Insert(root.right, data);
                root.right = cur;
            }

            return root;
        }

        public Node GetRoot()
        {
            return _root;
        }
        public Node Add(int data)
        {
            _root = this.Insert(_root, data);
            return _root;
        }

        public int GetHeight(Node root)
        {
          //Write your code here
          if(root == null) {
              return -1;
          }
          int leftDepth = GetHeight(root.left);
          int rightDepth = GetHeight(root.right);
              
          return (leftDepth > rightDepth ? leftDepth : rightDepth) + 1;
        }
    }
}
