using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse
{
    public class Algorythms
    {
        public class Node
        {
            public string Value { get; set; }
            public List<Node> Children { get; set;} = new List<Node>();
        }

        public void FizzBuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i.ToString());
                if (i % 3 == 0) Console.Write("Fizz");
                if (i % 5 == 0) Console.Write("Buzz");
                Console.WriteLine();
            }
        }

        public void ReverseList()
        {
            var list = new List<int> { 1, 3, 4, 5, 73, 7, 34, 23, 7, 4, 3, 777 };

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            var reversed = list.AsEnumerable().Reverse();

            foreach (var item in reversed)
            {
                Console.Write($"{item} ");
            }
        }

        public void DFS()
        {
            var visited = new List<Node>();

            var root = new Node
            {
                Value = "A",
                Children = new List<Node> {
                    new Node { Value = "B1", Children = new List<Node>{
                        new Node {Value = "C1", Children = new List<Node>{
                            new Node {Value = "D1"},
                            new Node {Value = "D2"},
                            new Node {Value = "D3"},
                        } },
                        new Node {Value = "C2"},
                    } },
                    new Node { Value = "B2" },
                    new Node { Value = "B3", Children = new List<Node>{
                        new Node { Value = "C3", Children = new List<Node>{
                            new Node {Value = "D4"},
                            new Node {Value = "D5"},
                        } },
                        new Node { Value = "C4", Children = new List<Node>{
                            new Node {Value = "D6"},
                            new Node {Value = "D7"},
                        } },
                    } }
                }
            };

            VisitDFSNode(root, visited);
        }

        private void VisitDFSNode(Node node, List<Node> visited)
        {
            if (visited.Contains(node)) return;

            Console.WriteLine($"Visit - {node.Value}");

            foreach (var child in node.Children)
            {
                VisitDFSNode(child, visited);
            }
        }

        public void BFS()
        {
            var root = new Node
            {
                Value = "A",
                Children = new List<Node> {
                    new Node { Value = "B1", Children = new List<Node>{
                        new Node {Value = "C1", Children = new List<Node>{
                            new Node {Value = "D1"},
                            new Node {Value = "D2"},
                        } },
                        new Node {Value = "C2"},
                    } },
                    new Node { Value = "B2" },
                    new Node { Value = "B3", Children = new List<Node>{
                        new Node { Value = "C3", Children = new List<Node>{
                            new Node {Value = "D3"},
                            new Node {Value = "D4"},
                        } },
                        new Node {Value = "C4"},
                    } }
                }
            };

            var queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                Console.WriteLine($"Visit - {node.Value}");

                foreach (var item in node.Children)
                {
                    queue.Enqueue(item);
                }
            }
        }
    }
}
