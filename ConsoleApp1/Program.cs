using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node checker = new Node(30);

            tree.AddItem(50);
            tree.AddItem(45);
            tree.AddItem(55);
            tree.AddItem(60);
            tree.AddItem(30);
            tree.AddItem(5);
            Console.WriteLine(tree.SearchForNode(tree.root, checker));
            Console.ReadLine();

        }
    }
}


