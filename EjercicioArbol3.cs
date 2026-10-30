
using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        // Navegacion hacia el nodo a eliminar
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
            // Caso 1 y 2: Un solo hijo o sin hijos
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

            // Caso 3: Dos hijos
            // Obtener el Sucesor Inorden
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

public class Program
{
    public static void Main()
    {
        Node root = new Node(50);
        root.Left = new Node(30);
        root.Right = new Node(70);
        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);
        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        BSTDeletion bst = new BSTDeletion();

        Console.WriteLine("Arbol antes de eliminar:");

        PrintInOrder(root);

        root = bst.DeleteNode(root, 30);

        Console.WriteLine("\nArbol despues de eliminar:");

        PrintInOrder(root);
        Console.WriteLine();
    }

    public static void PrintInOrder(Node root)
    {
        if (root == null) return;

        PrintInOrder(root.Left);
        Console.Write(root.Data + " ");
        PrintInOrder(root.Right);
    }
}
