using RoadMapping;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMapping
{
    public class RouteFinder
    {
        private int overallCost;
        
        //a function which returns the list of the nodes with the shortest cost, using Dijkstra's algorithm
        public List<Node> Dijkstra(Graph graph, Node startNode, Node targetNode)
        {
            Node[] nodeList = graph.nodeList;
            int nodeNumber = graph.NodeNumber();

            //set all previous nodes indices to -1
            int[] previous = new int[nodeNumber];
            for (int i = 0; i < nodeNumber; i++)
            {
                previous[i] = -1;
            }

            //set all distances to max value
            int[] distances = new int[nodeNumber];
            for (int i = 0; i < distances.Count(); i++)
            {
                distances[i] = Int32.MaxValue;
            }

            //sets distance to 0 on start node
            int startIndex = graph.GetIndexFromNode(startNode);
            distances[startIndex] = 0;

            //enqueuing nodes to priority queue
            var priorityQueue = new Queue<string>();
            for (int i = 0; i < nodeNumber; i++)
            {
                string queueNode = nodeList[i].Name + "," + distances[i];
                priorityQueue.Enqueue(queueNode);
            }

            //update the queue to put the startNode first
            UpdateQueue(ref priorityQueue, startNode.Name, 0);

            while (priorityQueue.Count != 0)//while priority queue isn't empty
            {
                //gets the next node in the queue
                string nextPoint = priorityQueue.Dequeue();
                
                //splits name and distance into array
                string[] nodeInfo = nextPoint.Split(",");
                
                //finds index of next node
                string nodeName = nodeInfo[0];
                int indexNode = graph.GetIndexFromString(nodeName);
                
                //finds the distance to that node
                int distance = Convert.ToInt32(nodeInfo[1]);

                //finds list of all neighbours
                List<int> neighbours = graph.EdgeNeighbours(nodeName);

                //loops for all the edges a node has
                for (int i = 0; i < neighbours.Count(); i++)
                {
                    //gets index of the neighbour
                    int neighbourIndex = neighbours[i];
                    string neighbourNodeName = nodeList[neighbourIndex].Name;

                    //gets the weight of the edge between the two nodes
                    int weight = graph.EdgeWeight(nodeName, neighbourNodeName);
                    int neighbourDistance = 0;
                    
                    //if nodes connect, add the edge weight to the current distance
                    if (weight != 0)
                    {
                        neighbourDistance = distance + weight;
                    }

                    //if the neighbour distance is greater than its previous distance
                    if (distances[graph.GetIndexFromString(neighbourNodeName)] > neighbourDistance)
                    {
                        //update the distance
                        distances[neighbourIndex] = neighbourDistance;

                        //update the previous node
                        previous[neighbourIndex] = indexNode;

                        UpdateQueue(ref priorityQueue, neighbourNodeName, neighbourDistance);
                    }
                }
            }
            
            //creates a list of indices
            List<Int32> indices = new List<Int32>();
            int nextIndex = graph.GetIndexFromNode(targetNode);
            
            //gets time
            overallCost = distances[nextIndex];

            //while there is still a previous node
            while (nextIndex >= 0)
            {
                //add the previous index to the list
                indices.Add(nextIndex);
                nextIndex = previous[nextIndex];
            }

            indices.Reverse();

            //creates a list of nodes
            List<Node> result = new List<Node>();

            //find the node of each index from indices and add to result
            for (int i = 0; i < indices.Count(); i++)
            {
                Node node = nodeList[indices[i]];
                result.Add(node);
            }
            //return list of nodes
            return result;
        }
        
        //a function which returns the overall time of the quickest journey
        public int GetRouteTiming()
        {
            return overallCost;
        }

        //a procedure to update the priority queue when a node needs to be updated
        private void UpdateQueue(ref Queue<string> queue, string nodeName, int nodeDistance)
        {
            int count = queue.Count;

            //creates a temp array
            string[] temp = new string[count];

            //creates an array with just the distances
            int[] numbers = new int[count];

            //putting items in queue into array
            for (int i = 0; i < count; i++)
            {
                //dequeue the item, and split it
                string item = queue.Dequeue();
                string[] itemInfo = item.Split(",");

                //if item is same as node which has changed
                if (itemInfo[0] == nodeName)
                {
                    //add the new distance to the temp array
                    temp[i] = itemInfo[0] + "," + nodeDistance.ToString();
                    
                    //add the new distance to the numbers array
                    numbers[i] = nodeDistance;
                }
                else
                {
                    //add the item to the temp array
                    temp[i] = item;
                    //add the distance to the numbers array
                    numbers[i] = Convert.ToInt32(itemInfo[1]);
                }
            }

            SortArray(ref temp, numbers);

            //enqueue the items in the temp array
            for (int i = 0; i < count; i++)
            {
                string item = temp[i];
                queue.Enqueue(item);
            }
        }

        //a procedure to sort an array using insertion sort
        private void SortArray(ref string[] temp, int[] numbers)
        {
            for (int i = 1; i < numbers.Count(); i++)
            {
                int numValue = numbers[i];
                string tempValue = temp[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > numValue)
                {
                    numbers[j + 1] = numbers[j];
                    temp[j + 1] = temp[j];
                    j--;
                }
                numbers[j + 1] = numValue;
                temp[j + 1] = tempValue;
            }
        }
    }
}
