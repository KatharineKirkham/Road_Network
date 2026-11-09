using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace RoadMapping
{
    public partial class InitialiseGraph: Graph
    {
        public List<string> roadList;
        public List<string> featureList;
        protected string featureFileName;
        protected string roadFileName;
        public InitialiseGraph() 
        {
            roadList = new List<string>();
            featureList = new List<string>();

            featureFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FeatureList.txt");
            roadFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "RoadList.txt");
            InitialiseNodes(featureFileName);
            InitialiseEdges(roadFileName);
        }
        
        //a function which finds the road connecting two points
        public string FindRoad(string point1, string point2)
        {
            foreach (string line in roadList)
            {
                string[] info = line.Split("|");
                //if the road contains both points
                if ((info[1] == point1 || info[2] == point1) && (info[1] == point2 || info[2] == point2))
                {
                    return line;
                }
            }
            return "";
        }
        
        //a procedure which adds each of the nodes in the text file to the graph
        private void InitialiseNodes(string fileName)
        {
            //adds information to list so information can be found out later
            CopyFileToList(fileName, featureList);

            foreach (string featureLine in featureList)
            {
                string[] featureInfo = featureLine.Split("|");
                float xCoordinate = float.Parse(featureInfo[2]);
                float yCoordinate = float.Parse(featureInfo[3]);

                //adds the node to nodeList
                InsertNode(featureInfo[0], featureInfo[1], xCoordinate, yCoordinate);
            }
        }

        //a procedure which copies the timing of the roads between two points into the graph
        private void InitialiseEdges(string fileName)
        {
            //adds information to list so information can be found out later
            CopyFileToList(fileName, roadList);

            foreach (string roadLine in roadList)
            {
                string[] roadInfo = roadLine.Split("|");
                string node1 = roadInfo[1];
                string node2 = roadInfo[2];
                int estimatedTime = Convert.ToInt32(roadInfo[5]);
                
                //adds the edge into the graph
                InsertEdge(node1, node2, estimatedTime);
            }
        }

        //a procedure which copies the line in the text file to an array
        private void CopyFileToList(string fileName, List<string> list)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
        }        
    }
}
