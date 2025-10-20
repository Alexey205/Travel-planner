using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Travelling
{
    public class Traveler //: ICloneable
    {
        private string name;

        public Traveler(string name)
        {
            this.name = name;
        }

        private string currentLocation = "";
        private List<string> cities = new List<string>();
        public string GetName()
        {
            return name;
        }
        public string GetLocation()
        {
            return currentLocation;
        }
        private static string upLetter(string city)
        {
            if (string.IsNullOrEmpty(city))
                return city;

            string result = "";
            bool first = true;
            bool capitalizeNext = false;

            foreach (char letter in city)
            {
                if (first)
                {
                    if ('a' <= letter && letter <= 'z')
                    {
                        result += (char)(letter - 32);
                    }
                    else
                    {
                        result += letter;
                    }
                    first = false;
                }
                else
                {
                    if (letter == ' ')
                    {
                        result += letter;
                        capitalizeNext = true;
                    }
                    else if (capitalizeNext && 'a' <= letter && letter <= 'z')
                    {
                        result += (char)(letter - 32);
                        capitalizeNext = false;
                    }
                    else if (capitalizeNext)
                    {
                        result += letter;
                        capitalizeNext = false;
                    }
                    else
                    {
                        result += letter;
                    }
                }
            }

            return result;
        }
        public void SetLocation(string location)
        {
            currentLocation = upLetter(location);
        }
        public void AddCity(string city)
        {
            if (city == null || city == "")
            {
                throw new Exception();
            }
            cities.Add(upLetter(city));
        }
        public string GetRoute()
        {
            return string.Join(" -> ", cities);
        }
        public void SaveToFile(string filePath)
        {
            string route = this.GetRoute();
            string[] routeArray;
            if (string.IsNullOrEmpty(route))
            {
                routeArray = new string[0];
            }
            else
            {
                routeArray = route.Split(" -> ");
            }

            string routeJson = "[\"" + string.Join("\", \"", routeArray) + "\"]";
            if (routeArray.Length == 0)
            {
                routeJson = "[]";
            }

            string data = "{\n" +
                  "  \"name\": \"" + this.name + "\",\n" +
                  "  \"currentLocation\": \"" + this.currentLocation + "\",\n" +
                  "  \"route\": " + routeJson + "\n" +
                  "}";

            File.WriteAllText(filePath, data);
        }
        public static Traveler LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            try
            {
                string json = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<JsonElement>(json);

                string name = data.GetProperty("name").GetString();
                string currentLocation = data.GetProperty("currentLocation").GetString();
                string[] route = data.GetProperty("route").Deserialize<string[]>();

                Traveler traveler = new Traveler(name);
                traveler.SetLocation(currentLocation);
                foreach (string city in route)
                {
                    traveler.AddCity(city);
                }

                return traveler;
            }
            catch (Exception)
            {
                throw new FileLoadException("Invalid travel data");
            }
        }
        public void SortRoute()
        {
            cities.Sort();
        }
        public bool HasCity(string city)
        {
            string upCity = upLetter(city);
            return cities.Contains(upCity);
        }
        public void ClearRoute()
        {
            cities.Clear();
        }
        public int GetStopCount()
        {
            return cities.Count;
        }
        public bool RemoveCity(string city)
        {
            return cities.Remove(upLetter(city));
        }
        public string GetNextStop()
        {
            if (cities.Count == 0) return null;
            return cities[0];
        }
        public string this[int index]
        {
            get
            {
                return cities[index];
            }
        }
        public bool PlanRouteTo(string destination, CityGraph map)
        {
            string start = null;
            if (currentLocation != null && currentLocation != "")
            {
                start = currentLocation;
            }
            else if (GetStopCount() > 0)
            {
                start = this[0];
            }
            else
            {
                Console.WriteLine("No route!");
                return false;
            }
            List<string> shortestPath = map.FindShortestPath(start, destination);

            if (shortestPath == null || shortestPath.Count == 0)
            {
                return false;
            }

            ClearRoute();
            foreach (string city in shortestPath)
            {
                AddCity(city);
            }

            return true;
        }

        public override string ToString()
        {
            return "Traveler: " + name + " | " + "Location: "
            + currentLocation + " | " + "Route: " + GetRoute();
        }
        public static bool operator ==(Traveler a, Traveler b)
        {
            if ((a.GetName() == null && b.GetName() == null)) return true;
            else if ((a.GetName() != null && b.GetName() == null) || (a.GetName() == null && b.GetName() != null)) return false;

            if (a.GetLocation() == null && b.GetLocation() == null) return true;
            else if ((a.GetLocation() != null && b.GetLocation() == null) || (a.GetLocation() == null && b.GetLocation() != null)) return false;

            if (a.GetName() == b.GetName() && a.GetLocation() == b.GetLocation()) return true;
            else return false;
        }
        public static bool operator !=(Traveler a, Traveler b)
        {
            return !(a == b);
        }
        // public object Clone()
        // {
        //     Traveler clone = new Traveler(name);
        //     clone.currentLocation = this.currentLocation;
        //     clone.cities = new RouteManager<string>(this.cities);
        //     return clone;
        // }
    }
}