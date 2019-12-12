using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void AddItem(int data)
        {
            Node node = new Node(data);

            // If no start node exists, set this as the start node
            if(root == null)
            {
                root = node;
                return;
            }

            // If there is already a value in the tree, recursively check for the proper spot to insert the new Node
            RecursiveAdd(root, node);            
        }

        public static void RecursiveAdd(Node original, Node data)
        {
            if(data.data < original.data)
            {
                if(original.right == null)
                {
                    original.right = data;
                }
                else
                {
                    RecursiveAdd(original.right, data);
                }
            }
            else
            {
                if (original.left == null)
                {
                    original.left = data;
                }
                else
                {
                    RecursiveAdd(original.left, data);
                }
            }

        }

        public string SearchForNode(Node original, Node nodeOfInterest)
        {
            if(original.data == nodeOfInterest.data)
            {
                return nodeOfInterest.data.ToString();
            }
            if (original == null)
            {
                return null;
            }
            if (original.data > nodeOfInterest.data)
            {
                return SearchForNode(original.right, nodeOfInterest);
            }
            else
            {
                return SearchForNode(original.left, nodeOfInterest);
            }
        }
    }
}
