using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Graph
{
    //public class Node
    //{
    //    public string Name { get; set; }
    //    public List<Node> Children { get; set; }
    //}
    public record Node(string Name, List<Node> Children);
}
