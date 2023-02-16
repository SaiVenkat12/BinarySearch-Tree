using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            binarySearch.insert(56);
            binarySearch.insert(30);
            binarySearch.insert(70);
            binarySearch.insert(22);
            binarySearch.insert(60);
            binarySearch.insert(40);
            binarySearch.insert(95);
            binarySearch.insert(65);
            binarySearch.insert(11);
            binarySearch.insert(3);
            binarySearch.insert(16);
            binarySearch.insert(63);
            binarySearch.insert(67);
            binarySearch.displayTree(binarySearch.root);
            Console.WriteLine("\nTotal Number of elements =" + binarySearch.Size());          
            Console.ReadLine();
        }
    }
}
