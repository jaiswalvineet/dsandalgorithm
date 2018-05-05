

using System;

namespace BinaryTree
{
    class Binary
    {
        static void Main(string[] arg)
        {
            BinaryTree tree = new BinaryTree();

            // This is not ideal way to create binary tree, ideally it should be managed by recursive programming 
            // Using this example to create binary tree ony for simplicity 
            tree.root = new Node(1);
            // Create root node 
            //          1
            //         / \
            //      null null
            tree.root.left = new Node(13);
            // Create left node 
            //          1
            //         / \
            //      13    null
            //     / \
            //   null null
            tree.root.right = new Node(23);
            // Create right node 
            //          1
            //         / \
            //      13    23
            //     / \   / \
            //   null null null
            tree.root.left.left = new Node(12);
            // Create inner left node 
            //          1
            //         / \
            //      13    23
            //     / \   / \
            //   12   null null
            //  / \
            //null null

            // transverse the data

            Console.WriteLine("root then left then right"); 
            Console.WriteLine("Pre Order transverse ");
            tree.PreOrder(tree.root);
            // 1 13 12 23

            Console.WriteLine("Left then right then root ");
            Console.WriteLine("Post Order transverse ");
            tree.PostOrder(tree.root);
            // 12 13 23 1

            Console.WriteLine("Left then root then right");
            Console.WriteLine("In Order transverse ");
            tree.InOrder(tree.root);
            // 12 13 1 23


            Console.ReadLine();
        }
    }


    /// <summary>
    /// Class containing the left child and right child of current node and its key value
    /// </summary>
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    /// <summary>
    /// A program which will introduce the binary tree
    /// </summary>
    class BinaryTree
    {
        public Node root;

        /// <summary>
        /// Constructor used for new node creation
        /// </summary>
        /// <param name="key"> value </param>
        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        /// <summary>
        ///  Constructor needed for initialization 
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Read in PreOrder fashion 
        /// root then left then right 
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(Node root)
        {
            if(root != null)
            {
                Console.WriteLine(root.key);
                PreOrder(root.left);
                PreOrder(root.right);
            }

        }

        /// <summary>
        /// Read in Post order 
        /// Left then right then root 
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(Node root)
        {
            if(root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.key);
            }
        }

        /// <summary>
        /// Read in In order 
        /// Left then root then right
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.WriteLine(root.key);
                InOrder(root.right);
            }
        }

    }

}
