using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Xml.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using RoadMapping;

namespace RoadMapping
{
    public partial class MapForm : Form
    {
        private AddRoadForm addRoadForm;
        private AddFeatureForm addFeatureForm;
        private EditForm editForm;
        private DeleteForm deleteForm;
        private InitialiseGraph mapGraph;
        private RouteFinder routeFinder;

        private bool showQuickestRoute;

        private double westernLongitude;
        private double lowestLatitude;
        //private double easternLongitude;
        //private double highestLatitude;

        private int length;
        private int width;

        public MapForm()
        {
            InitializeComponent();
            mapGraph = new InitialiseGraph();

            showQuickestRoute = false;

            //the map is set to show anything within these coordinates
            westernLongitude = -0.3;
            lowestLatitude = 52;
            //easternLongitude = 0.7;
            //highestLatitude = 52.8;

            //MENUSTRIP = 162 PIXELS WIDE
            //formLength = 800 pixels
            //formWidth = 1162 pixels
            //mapWidth = 1000 pixels

            //length and width of form
            length = this.Size.Height;
            width = this.Size.Width;
        }

        private void MapForm_Paint(object sender, PaintEventArgs e)
        {
            //drawing each node in the vertex list
            foreach (Node node in mapGraph.nodeList)
            {
                if (node != null)
                {
                    DrawNode(e, node);
                }
            }

            //draws a highlighted route if selected
            if (showQuickestRoute == true)
            {
                string startPoint = point1TextBox.Text;
                string endPoint = point2TextBox.Text;

                QuickestRoute(e, startPoint, endPoint);
            }

            //draws every road
            Pen normalPen = new Pen(Color.Black, 3);
            foreach (string roadLine in mapGraph.roadList)
            {
                string[] roadInfo = roadLine.Split("|");
                Node node1 = mapGraph.GetNodeFromString(roadInfo[1]);
                Node node2 = mapGraph.GetNodeFromString(roadInfo[2]);

                DrawEdge(e, node1, node2, normalPen);
            }
        }

        //a procedure which draws all the settlements on mapForm
        private void DrawNode(PaintEventArgs e, Node node)
        {
            string type = node.Type;
            string name = node.Name;

            //works out the position on the map in relation to the longitude/ latitude set at the edges
            int xPosition = Convert.ToInt32((node.X - westernLongitude) * 1000);
            int yPosition = length - Convert.ToInt32((node.Y - lowestLatitude) * 1000);

            Pen pen = new Pen(Color.Black, 1);

            switch (type)
            {
                //all cases need to be capitals
                case "City":
                    {
                        //creating label for the settlements
                        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                        label.Location = new Point(xPosition + 6, yPosition + 6);
                        label.Text = name;
                        label.Font = new Font("Segoe UI", 12);
                        label.Font = new Font(label.Font, FontStyle.Bold);
                        label.BackColor = Color.LightSteelBlue;

                        //label is fitted to text
                        label.AutoSize = true;
                        this.Controls.Add(label);

                        //drawing a marker
                        e.Graphics.DrawRectangle(pen, new Rectangle(xPosition, yPosition, 4, 4));

                        break;
                    }
                case "Town":
                    {
                        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                        label.Location = new Point(xPosition + 6, yPosition + 6);
                        label.Text = name;
                        label.Font = new Font("Segoe UI", 10);
                        label.BackColor = Color.LightSteelBlue;

                        //label is fitted to text
                        label.AutoSize = true;
                        this.Controls.Add(label);

                        //drawing a marker
                        e.Graphics.DrawRectangle(pen, new Rectangle(xPosition, yPosition, 4, 4));

                        break;
                    }
                case "Village":
                    {
                        System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                        label.Location = new Point(xPosition + 6, yPosition + 6);
                        label.Text = name;
                        label.Font = new Font("Segoe UI", 8);
                        label.BackColor = Color.LightSteelBlue;

                        //label is fitted to text
                        label.AutoSize = true;
                        this.Controls.Add(label);

                        //drawing a marker
                        e.Graphics.DrawRectangle(pen, new Rectangle(xPosition, yPosition, 4, 4));

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        //a procedure that draws the roads on the map form
        private void DrawEdge(PaintEventArgs e, Node node1, Node node2, Pen pen)
        {
            //working out positions on form
            int xPosition1 = Convert.ToInt32((node1.X - westernLongitude) * 1000);
            int yPosition1 = length - Convert.ToInt32((node1.Y - lowestLatitude) * 1000);

            int xPosition2 = Convert.ToInt32((node2.X - westernLongitude) * 1000);
            int yPosition2 = length - Convert.ToInt32((node2.Y - lowestLatitude) * 1000);

            //points of line
            PointF point1 = new PointF(xPosition1, yPosition1);
            PointF point2 = new PointF(xPosition2, yPosition2);

            e.Graphics.DrawLine(pen, point1, point2);
        }

        private void addRoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRoadForm = new AddRoadForm();
            //if form isn't opened, create a new one, else show the current one
            if (Application.OpenForms.OfType<AddRoadForm>().Count() == 0)
            {
                addRoadForm = new AddRoadForm();
                addRoadForm.Show();
            }
            else
            {
                addRoadForm.Focus();
            }
            this.Close();
        }

        private void addFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFeatureForm = new AddFeatureForm();
            //if form isn't opened, create a new one, else show the current one
            if (Application.OpenForms.OfType<AddFeatureForm>().Count() == 0)
            {
                addFeatureForm = new AddFeatureForm();
                addFeatureForm.Show();
            }
            else
            {
                addFeatureForm.Focus();
            }
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editForm = new EditForm();
            //if form isn't opened, create a new one, else show the current one
            if (Application.OpenForms.OfType<EditForm>().Count() == 0)
            {
                editForm = new EditForm();
                editForm.Show();
            }
            else
            {
                editForm.Focus();
            }
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteForm();
            //if form isn't opened, create a new one, else show the current one
            if (Application.OpenForms.OfType<DeleteForm>().Count() == 0)
            {
                deleteForm = new DeleteForm();
                deleteForm.Show();
            }
            else
            {
                deleteForm.Focus();
            }
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exits application
            Environment.Exit(0);
        }

        private void selectRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows the selectRouteGroupBox
            selectRouteGroupBox.Visible = true;
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            //calls the paint method to draw quickest route
            showQuickestRoute = true;
            Invalidate();
        }

        //a procedure which highlights the quickest route from one point to another
        private void QuickestRoute(PaintEventArgs e, string startPoint, string endPoint)
        {
            //clears the list box
            quickestRouteListBox.Items.Clear();
            routeFinder = new RouteFinder();
            Node startNode;
            Node endNode;
            
            //checks if the nodes can be found in the graph
            try
            {
                startNode = mapGraph.GetNodeFromString(startPoint);
                endNode = mapGraph.GetNodeFromString(endPoint);
            }
            catch
            {
                MessageBox.Show("Point couldn't be found");
                return;
            }

            //gets all the nodes in the quickest route
            List<Node> nodeRoute = routeFinder.Dijkstra(mapGraph, startNode, endNode);
            
            //gets the timing of the quickest route and adds it to the listbox
            int time = routeFinder.GetRouteTiming();
            string timeString = time.ToString() + " mins";
            quickestRouteListBox.Items.Add(timeString);

            //draws highlighted route
            Pen highlightPen = new Pen(Color.Gold, 10);

            for (int i = 0; i < nodeRoute.Count() - 1; i++)
            {
                //drawing the edges
                Node previousNode = nodeRoute[i];
                Node nextNode = nodeRoute[i + 1];
                DrawEdge(e, previousNode, nextNode, highlightPen);

                string roadLine = mapGraph.FindRoad(previousNode.Name, nextNode.Name);
                ShowRouteInfo(roadLine);

            }
            return;
        }

        //a procedure which shows the info on the roads
        private void ShowRouteInfo(string roadLine)
        {
            string[] roadInfo = roadLine.Split('|');

            //displays name of road, type of road and notes
            string roadString = $"{roadInfo[0]} {roadInfo[7]}";
            quickestRouteListBox.Items.Add(roadString);
        }
    }
}