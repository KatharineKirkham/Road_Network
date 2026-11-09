using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMapping
{
    public class Node
    {
        public float X { get; set; }
        public float Y { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
        public Node(string inputName, string inputType, float x, float y)
        {
            X = x;
            Y = y;
            Name = inputName;
            Type = inputType;
        }
    }
}
