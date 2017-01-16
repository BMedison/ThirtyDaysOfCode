using System;
using Xunit;

using BST;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Test
    {
        [Fact]
        public void InsertDataToBSTTest()
        {
            //Given
            BinarySearchTree bst = new BinarySearchTree();
            //3 5 2 1 4 6 7
            Node node;
            node = bst.Add(3);
            node = bst.Add(5);            
            node = bst.Add(2);            
            node = bst.Add(1);            
            node = bst.Add(4);            
            node = bst.Add(6);            
            node = bst.Add(7);            
            Assert.Equal(3, node.data);
        }

        [Fact]
        public void GetHeightTest()
        {
            BinarySearchTree bst = new BinarySearchTree();
            //3 5 2 1 4 6 7
            Node node;
            node = bst.Add(3);
            node = bst.Add(5);            
            node = bst.Add(2);            
            node = bst.Add(1);            
            node = bst.Add(4);            
            node = bst.Add(6);            
            node = bst.Add(7);            
            Assert.Equal(3, bst.GetHeight(node));
        }
    }
}
