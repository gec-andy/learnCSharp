using System;

namespace _01_01_数据结构之单链表的实现
{
    class Program
    {
        static void Main(string[] args)
        {
            var linked = new LinkedNode();
            linked.AddNode(new Node(1));
            linked.AddNode(new Node(2));

            linked.PrintNodes();

            Console.ReadKey();
        }
    }

    public class Node
    {
        public int Id { get; private set; }
        public Node NextNode { get; set; }
        public Node(int id) { this.Id = id; }
    }
    public class LinkedNode
    {
        private readonly Node[] nodes = new Node[10];
        private Node node = null;
        private int nodeIndex = 0;
        public void AddNode(Node node)
        {
            if (this.nodeIndex < this.nodes.Length)
            {
                this.node = node;
                if (this.node.Id < node.Id)
                {
                    this.node.NextNode = node;
                    this.nodes[this.nodeIndex] = this.node.NextNode;
                }
                else
                {
                    this.nodes[this.nodeIndex] = node.NextNode;
                }
            }
            this.nodeIndex++;
            foreach (var item in this.nodes)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
        public void PrintNodes()
        {
            foreach (var item in this.nodes)
            {
                if (item!=null)
                    Console.WriteLine(item.Id);
            }
        }
    }
}
