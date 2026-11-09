using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoadMapping
{
    public class FormMethods:InitialiseGraph
    {
        public FormMethods() 
        { }

        //a function which returns the list, roadList
        public List<string> GetRoadList()
        {
            return roadList;
        }

        //a function which returns the list, featureList
        public List<string> GetFeatureList()
        {
            return featureList;
        }

        //a function which returns the filename of featureList.txt
        public string GetFeatureFile() 
        {
            return featureFileName;
        }
        
        //a function which returns the filename of roadList.txt
        public string GetRoadFile() 
        {
            return roadFileName;
        }

        //a function to overwrite the file, and add the lines in the list
        public void OverwriteFile(string fileName, List<string> list)
        {
            //overwriting the current file
            File.Create(fileName).Close();

            //adds all the other lines to the new file
            foreach (string line in list.ToList())
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(line);
                }
            }
        }

        //a function to return the information given in a line
        public string[] SearchInList(List<string> list, string search)
        {
            //going through each line in list to find line
            foreach (string line in list.ToList())
            {
                string[] lineInfo = line.Split("|");
                if (lineInfo[0] == search)
                {
                    return lineInfo;
                }
            }
            return null;
        }

        //a procedure which removes a requested line from a list
        public void DeleteFromList(List<string> list, string item)
        {
            //going through each line in list to delete requested line
            foreach (string line in list.ToList())
            {
                string[] lineInfo = line.Split("|");
                if (lineInfo[0] == item)
                {
                    list.Remove(line);
                }
            }
        }

        //a function which works out the estimated timing of a road
        public int RoadTimeEstimate(string distance, string speedLimit)
        {
            //conversion to metric
            double speedMetric = double.Parse(speedLimit) * 1.609;

            double hourTimeDouble = double.Parse(distance) / speedMetric;
            double minuteTimeDouble = hourTimeDouble * 60;
            int timeInt = Convert.ToInt32(minuteTimeDouble);

            return timeInt;
        }

        //a function which returns true if the string is all numbers
        public bool IsFloat(string input)
        {
            Regex floatOnly = new Regex(@"^[-]?[0-9]+(\.[0-9]*)?$");
            
            if (floatOnly.IsMatch(input))
            {
                return true;
            }
            return false;
        }
    }
}
