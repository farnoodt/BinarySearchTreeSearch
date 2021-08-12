using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Search
    {
        public bool BinarySearchTreeSearch(Node root, int item)
        {
            if (root == null)
                return false;
            if (root.data == item)
                return true;
            else if (root.data > item)
                return BinarySearchTreeSearch(root.left, item);
            else
                return BinarySearchTreeSearch(root.right, item);

            return false;
        }
    }
}
