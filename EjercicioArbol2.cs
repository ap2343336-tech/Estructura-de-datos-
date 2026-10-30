
using System;
using System.Collections.Generic;

// Clase para representar cada nodo del arbol
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

// Clase con los recorridos del arbol binario
public class TreeTraversals
{
    // 1. Recorrido Preorden (Root, Left, Right)
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Left, Root, Right)
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Recorrido Posorden (Left, Right, Root)
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. Recorrido BFS por niveles (Queue FIFO)
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Crear el arbol binario
        Node root = new Node(10);

        root.Left = new Node(5);
        root.Right = new Node(15);

        root.Left.Left = new Node(3);
        root.Left.Right = new Node(7);

        root.Right.Left = new Node(12);
        root.Right.Right = new Node(20);

        // Crear objeto de recorridos
        TreeTraversals traversal = new TreeTraversals();

        // Ejecutar los recorridos
        Console.WriteLine("Recorrido PreOrder:");
        traversal.PreOrder(root);

        Console.WriteLine("\n\nRecorrido InOrder:");
        traversal.InOrder(root);

        Console.WriteLine("\n\nRecorrido PostOrder:");
        traversal.PostOrder(root);

        Console.WriteLine("\n\nRecorrido LevelOrder (BFS):");
        traversal.LevelOrder(root);

        Console.WriteLine();
    }
}
