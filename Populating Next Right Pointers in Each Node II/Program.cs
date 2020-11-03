using System;

namespace Populating_Next_Right_Pointers_in_Each_Node_II
{

    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(0);
            root.left= new Node(2);
            root.right= new Node(4);
            root.left.left = new Node(1);
            root.right.left= new Node(3);
            root.right.right= new Node(-1);
            root.left.left.left = new Node(5);
            root.left.left.right = new Node(1);
            root.right.left.right = new Node(6);
            root.right.right.right = new Node(8);
            Connect(root);
        }

        static Node Connect(Node root)
        {
            Node head = null;
            Node prev = null;
            Node cur = root;
            while (cur != null)
            {
                while (cur != null)
                {
                    if (cur.left != null)
                    {
                        if (prev != null)
                            prev.next = cur.left;
                        else
                            head = cur.left;
                        prev = cur.left;
                    }

                    if (cur.right != null)
                    {
                        if (prev != null)
                            prev.next = cur.right;
                        else
                            head = cur.right;
                        prev = cur.right;
                    }
                    cur = cur.next;
                }
                cur = head;
                head = null;
                prev = null;
            }
            return root;
        }
    }
}
