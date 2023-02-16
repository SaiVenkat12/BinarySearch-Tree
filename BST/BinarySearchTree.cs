using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class BinarySearchTree<T> where T: IComparable<T>
    {

        public TreeNode<T> root;
        public void insert(T item)
        {
            if (root == null)
            {
                root = new TreeNode<T>(item);
            }
            TreeNode<T> temp = root;
            while (temp != null)
            {
                if (item.CompareTo(temp.data) < 0)
                {
                    if (temp.left != null)
                    {
                        temp = temp.left;
                    }
                    else
                    {
                        temp.left = new TreeNode<T>(item);
                        break;
                    }
                }
                else if (item.CompareTo(temp.data) > 0)
                {
                    if (temp.right != null)
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        temp.right = new TreeNode<T>(item);
                        break;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        public void displayTree(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }            
            displayTree(root.left);
            System.Console.Write(root.data + " ");
            displayTree(root.right);
        }
    }
}
