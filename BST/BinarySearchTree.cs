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
        public int count = 0;
        public void insert(T item)
        {
            if (root == null)
            {
                root = new TreeNode<T>(item);
                count++;
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
                        count++;
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
                        count++;
                        break;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        public int Size()
        {
            return count;
        }
        public TreeNode<T> Search(T data, TreeNode<T> root)
        {
           if(root==null)
            {
                return null;
            }
            else if (data.CompareTo(root.data) < 0)
            {
                return Search(data, root.left);
            }
           else if (data.CompareTo(root.data) > 0)
            {
                return Search(data, root.right);
            }
            else
            {
                return root;
            }
        }
        public void isExists(T data, TreeNode<T> root)
        {
            TreeNode<T> node = Search(data, root);
            if (node != null)
            {
                
                Console.WriteLine("Element Found :" + node.data);
            }
            else
                Console.WriteLine("Element {0} is not Found ", data);
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
        public int size(TreeNode<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSize = size(root.left);
            int rightSize = size(root.right);
            return leftSize + rightSize + 1;
        }

    }
}
