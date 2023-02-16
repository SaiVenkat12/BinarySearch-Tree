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
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();
            binarySearch.insert(56);
            binarySearch.insert(30);
            binarySearch.insert(70);
            binarySearch.displayTree(binarySearch.root);
            Console.ReadLine();
        }
    }
}
