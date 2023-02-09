using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Graph
{
    //var root = new Node("A", new List<Node> {
    //    new Node("B1", new List<Node> {
    //        new Node("C1", new List<Node> {
    //            new Node("D1", new List<Node> { }),
    //            new Node("D2", new List<Node> { }),
    //            new Node("D3", new List<Node> { }),
    //        }),
    //        new Node("C2", new List<Node> { }),
    //    }),
    //    new Node("B2", new List<Node> {}),
    //    new Node("B3", new List<Node> {
    //        new Node("C3", new List<Node> {
    //            new Node("D4", new List<Node> { }),
    //            new Node("D5", new List<Node> { }),
    //        }),
    //        new Node("C4", new List<Node> {
    //            new Node("D6", new List<Node> { }),
    //            new Node("D7", new List<Node> { }),
    //        }),
    //    }),
    //});

    //var graphService = new GraphService();
    //graphService.DFS(root);

    public class GraphService
    {
        public void DFS(Node root)
        {
            var visited = new List<Node>();

            VisitNode(root, visited);
        }

        private void VisitNode(Node node, List<Node> visited)
        {
            if (visited.Contains(node)) return;

            Console.WriteLine($"Node: {node} - visited");

            visited.Add(node);

            foreach (var child in node.Children)
            {
                VisitNode(child, visited);
            }
        }

    }
}
