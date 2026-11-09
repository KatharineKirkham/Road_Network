using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMapping
{
    public class Graph
    {
        public int[,] adjMatrix;
        public Node[] nodeList;

        private int maxNodes = 60;
        private int nodeNumber;
        private int edgeNumber;

        public Graph()
        {
            adjMatrix = new int[maxNodes, maxNodes];
            nodeList = new Node[maxNodes];//makes a list of the nodes for the matrix

            //initially graph is empty
            nodeNumber = 0;
            edgeNumber = 0;
        }
        
        //a function which returns the number of nodes in the graph
        public int NodeNumber()
        {
            return nodeNumber;
        }

        //a function which returns the number of edges in the graph
        public int EdgeNumber()
        {
            return edgeNumber;
        }

        //a function which returns the index from vertexList of a node from string
        public int GetIndexFromString(string name)
        {
            for (int i = 0; i < nodeNumber; i++)
            {
                if (name == nodeList[i].Name)
                    return i;
            }
            return -1;
        }
        
        //a function which returns the index from vertexList of a node
        public int GetIndexFromNode(Node node)
        {
            for (int i = 0; i < nodeNumber; i++)
            {
                if (node == nodeList[i])
                    return i;
            }
            return -1;
        }

        //a function which returns the node from a string
        public Node GetNodeFromString(string name)
        {
            int index = GetIndexFromString(name);
            return nodeList[index];
        }

        //a function which returns the weight of an edge between two nodes
        public int EdgeWeight(string node1, string node2)
        {
            int index1 = GetIndexFromString(node1);
            int index2 = GetIndexFromString(node2);

            if (IsAdjacent(index1, index2) == true)
            {
                return adjMatrix[index1, index2];
            }
            else
            {
                return 0;
            }
        }

        //a function which returns the list of neighbours of a node
        public List<int> EdgeNeighbours(string node)
        {
            List<int> neighbours = new List<int>();
            int index = GetIndexFromString(node);

            for (int i = 0; i < nodeNumber; i++)
            {
                if (adjMatrix[index, i] > 0)
                {
                    neighbours.Add(i);
                }
            }
            return neighbours;
        }

        //a procedure to add another vertex to the matrix 
        protected void InsertNode(string name, string type, float x, float y)
        {
            nodeList[nodeNumber++] = new Node(name, type, x, y);
        }

        //a procedure which creates an edge between two vertices
        protected void InsertEdge(string node1, string node2, int weight)
        {
            int index1 = GetIndexFromString(node1);
            int index2 = GetIndexFromString(node2);


            if (index1 == index2 || adjMatrix[index1, index2] > 0)
            {

            }
            //if the indices aren't the same and an edge doesn't already exist
            else
            {
                adjMatrix[index1, index2] = weight;
                adjMatrix[index2, index1] = weight;
                edgeNumber++;
            }
        }

        //a function which returns true if there is a connection between two vertices
        private bool IsAdjacent(int index1, int index2)
        {
            if (adjMatrix[index1, index2] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
