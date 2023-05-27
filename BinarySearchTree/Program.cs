namespace BinarySearchTree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            // Adding values to the BST
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);

            // The BST is now constructed with the given values

            Console.WriteLine("Binary Search Tree created and values inserted.");
        }
    }
}