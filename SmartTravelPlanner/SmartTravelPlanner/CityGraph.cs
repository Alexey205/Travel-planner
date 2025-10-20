using System;
using System.Collections.Generic;
using System.IO;

namespace Travelling
{
    public class CityGraph
    {
        private Dictionary<string, List<(string city, int distance)>> adjacencyList;
        public CityGraph()
        {
            adjacencyList = new Dictionary<string, List<(string city, int distance)>>();
        }
        public List<string> GetAllCities()
        {
            List<string> cities = new List<string>();

            foreach (string city in adjacencyList.Keys)
            {
                cities.Add(city);
            }

            cities.Sort(); // Сортувати алфавітно
            return cities;
        }
        public static CityGraph LoadFromFile(string filepath)
        {
            CityGraph graph = new CityGraph();

            string[] data = File.ReadAllLines(filepath);

            foreach (string line in data)
            {
                string[] data_part = line.Split(',');
                string city_connection = data_part[0];
                int distance = int.Parse(data_part[1]);

                string[] cities = city_connection.Split('-');
                string cityA = cities[0];
                string cityB = cities[1];

                if (!graph.adjacencyList.ContainsKey(cityA))
                {
                    graph.adjacencyList[cityA] = new List<(string city, int distance)>();
                }
                graph.adjacencyList[cityA].Add((cityB, distance));

                if (!graph.adjacencyList.ContainsKey(cityB))
                {
                    graph.adjacencyList[cityB] = new List<(string city, int distance)>();
                }
                graph.adjacencyList[cityB].Add((cityA, distance));
            }

            return graph;
        }

        public List<string> FindShortestPath(string from, string to)
        {
            if (!adjacencyList.ContainsKey(from) || !adjacencyList.ContainsKey(to))
            {
                return new List<string>();
            }

            if (from == to)
            {
                return new List<string> { from };
            }


            var distances = new Dictionary<string, int>();
            var previous = new Dictionary<string, string>();
            var unvisited = new List<string>();

            foreach (string city in adjacencyList.Keys)
            {
                distances[city] = int.MaxValue;
                previous[city] = null;
                unvisited.Add(city);
            }

            distances[from] = 0;

            while (unvisited.Count > 0)
            {
                string current = null;
                int minDistance = int.MaxValue;

                //find min
                foreach (string city in unvisited)
                {
                    if (distances[city] < minDistance)
                    {
                        minDistance = distances[city];
                        current = city;
                    }
                }

                if (current == null || distances[current] == int.MaxValue)
                {
                    break;
                }

                unvisited.Remove(current);

                if (current == to)
                {
                    break;
                }

                // neighbors
                foreach (var neighbor in adjacencyList[current])
                {
                    if (!unvisited.Contains(neighbor.city))
                        continue;

                    int newDistance = distances[current] + neighbor.distance;

                    if (newDistance < distances[neighbor.city])
                    {
                        distances[neighbor.city] = newDistance;
                        previous[neighbor.city] = current;
                    }
                }
            }

            var path = new List<string>();
            string currentCity = to;

            while (currentCity != null)
            {
                path.Insert(0, currentCity);
                currentCity = previous[currentCity];
            }

            if (path.Count == 0 || path[0] != from)
            {
                return new List<string>(); // немає шляху
            }

            return path;

        }
        public int GetPathDistance(List<string> path)
        {
            if (path == null || path.Count == 0)
            {
                return 0;
            }
            if (path.Count == 1)
            {
                return 0;
            }

            int total = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                string currentCity = path[i];
                string next = path[i + 1];

                if (!adjacencyList.ContainsKey(currentCity))
                {
                    return 0;
                }

                foreach (var city in adjacencyList[currentCity])
                {
                    if (city.city == next)
                    {
                        total += city.distance;
                        break;
                    }
                }
            }
            return total;
        }

        public override string ToString()
        {
            string result = "";
            string[] lines = File.ReadAllLines("map.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string connection = parts[0];
                int distance = int.Parse(parts[1]);

                string[] cities = connection.Split('-');
                string cityA = cities[0];
                string cityB = cities[1];

                result += cityA + "-" + cityB + "," + distance + "\n";
                result += cityB + "-" + cityA + "," + distance + "\n";
            }
            return result.TrimEnd('\n');
        }
    }
}