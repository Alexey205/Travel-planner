using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Travelling;

namespace SmartTravelPlanner
{
    public partial class Form1 : Form
    {
        private CityGraph graph;
        private Traveler traveler;
        private string name;
        private string currentLocation;
        private string route;
        private string to;
        private int distance = 0;
        private int citiesCount = 0;


        public Form1()
        {
            InitializeComponent();

            // Закруглити всі GroupBox
            RoundCorners(grp_traveler_info, 15);
            RoundCorners(grp_path_finding, 15);
            RoundCorners(grp_current_route, 15);
            RoundCorners(grp_available_cities, 15);
        }

        private void RoundCorners(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Верхній лівий кут
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            // Верхня лінія
            path.AddLine(radius, 0, control.Width - radius, 0);
            // Верхній правий кут
            path.AddArc(control.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            // Права лінія
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            // Нижній правий кут
            path.AddArc(control.Width - radius * 2, control.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            // Нижня лінія
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            // Нижній лівий кут
            path.AddArc(0, control.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            // Ліва лінія
            path.AddLine(0, control.Height - radius, 0, radius);

            path.CloseFigure();
            control.Region = new Region(path);
        }
        private void SetupAutoComplete(TextBox textBox, List<string> cities)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(cities.ToArray());

            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
        }
        private void LoadAvailableCities()
        {
            list_available_cities.Items.Clear();

            if (graph == null)
            {
                label_cities_count.Text = "Total cities: 0";
                return;
            }

            List<string> cities = graph.GetAllCities();

            foreach (string city in cities)
            {
                list_available_cities.Items.Add(city);
            }

            label_cities_count.Text = $"Total cities: {cities.Count}";

            SetupAutoComplete(input_destination, cities);
            SetupAutoComplete(input_current_location, cities);
        }
        private void List_available_cities_Click(object sender, EventArgs e)
        {
            if (list_available_cities.SelectedItem != null)
            {
                string selectedCity = list_available_cities.SelectedItem.ToString();
                input_destination.Text = selectedCity;
                to = selectedCity;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_traveler_Click(object sender, EventArgs e)
        {
            name = input_traveler_name.Text;
            currentLocation = input_current_location.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(currentLocation))
            {
                MessageBox.Show("Fill all fields!", "Traveler error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            traveler = new Traveler(name);
            traveler.SetLocation(currentLocation);
            label_from_value.Text = currentLocation;
        }

        private void btn_load_map_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select Map File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;

                try
                {
                    graph = CityGraph.LoadFromFile(filepath);
                    label_map_status.Text = "loaded";
                    label_map_status.ForeColor = Color.LightGreen;
                    LoadAvailableCities();
                }
                catch (Exception ex)
                {
                    label_map_status.Text = "not loaded";
                    label_map_status.ForeColor = Color.DarkOrange;
                    MessageBox.Show("Check map file!", "Load map error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_load_traveler_Click(object sender, EventArgs e)
        {
            if (graph == null)
            {
                MessageBox.Show("Load map first!", "Planning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog.Title = "Select Traveler Data";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;

                try
                {
                    traveler = Traveler.LoadFromFile(filepath);
                    name = traveler.GetName();
                    currentLocation = traveler.GetLocation();
                    route = traveler.GetRoute();

                    label_from_value.Text = currentLocation;
                    input_traveler_name.Text = name;
                    input_current_location.Text = currentLocation;

                    string[] routeCities = route.Split(" -> ");
                    List<string> cityList = new List<string>(routeCities);
                    distance = graph.GetPathDistance(cityList);

                    citiesCount = traveler.GetStopCount();
                    to = cityList[cityList.Count() - 1];

                    input_destination.Text = to;
                    label_total_stops.Text = $"Total stops: {citiesCount}";
                    label_distance.Text = $"Distance: {distance} km";
                    input_route_display.Text = route;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Traveler load error!", "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_save_traveler_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(currentLocation))
            {
                MessageBox.Show("Create traveler first!", "Traveler error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(traveler.GetRoute()))
            {
                MessageBox.Show("Plan your trip first!", "Traveler error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Traveler Data";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;

                try
                {
                    traveler.SaveToFile(filepath);
                    MessageBox.Show("Success! Traveler data was saved", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save traveler data error!", "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_plan_route_Click(object sender, EventArgs e)
        {
            if (graph == null)
            {
                MessageBox.Show("Load map first!", "Planning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string from = currentLocation;
            to = input_destination.Text;
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Fill all fields!", "Planning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool planned = traveler.PlanRouteTo(to, graph);
            if (planned)
            {
                route = traveler.GetRoute();
                string[] routeCities = route.Split(" -> ");
                List<string> cityList = new List<string>(routeCities);
                distance = graph.GetPathDistance(cityList);

                citiesCount = traveler.GetStopCount();

                label_total_stops.Text = $"Total stops: {citiesCount}";
                label_distance.Text = $"Distance: {distance} km";
                input_route_display.Text = route;
            }
            else
            {
                MessageBox.Show("Route not found! Check location and destination", "Planning error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_clearRoute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(to))
            {
                to = null;
                input_destination.Text = "";
            }
            if(distance != 0)
            {
                distance = 0;
                label_distance.Text = $"Distance: {distance} km";
            }
            if (route != null)
            {
                route = null;
                input_route_display.Text = "No route planned";
            }
            if (citiesCount != 0)
            {
                citiesCount = 0;
                label_total_stops.Text = $"Total stops: {citiesCount}";
            }
        }
    }
}
