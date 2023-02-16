using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class TreeNode<T>
    {
        public T data;
        public TreeNode <T> left { get; set; }
        public TreeNode <T> right { get; set; }
        public TreeNode(T data) 
        {
               this.data = data;
        }
    }
}
