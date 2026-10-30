using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Insercion
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Busqueda
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
    }

    // Recorrido InOrder
    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }

    // Recorrido PreOrder
    public void PreOrder(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
    }

    // Recorrido PostOrder
    public void PostOrder(Node root)
    {
        if (root != null)
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}

// Programa principal
public class Program
{
    public static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("InOrder:");
        tree.InOrder(tree.Root);

        Console.WriteLine("\nPreOrder:");
        tree.PreOrder(tree.Root);

        Console.WriteLine("\nPostOrder:");
        tree.PostOrder(tree.Root);

        Console.WriteLine("\n\nBusqueda del 40:");

        if (tree.Search(tree.Root, 40))
            Console.WriteLine("El elemento existe");
        else
            Console.WriteLine("El elemento no existe");
    }
}