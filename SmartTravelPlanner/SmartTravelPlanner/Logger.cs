using System;
using System.Collections.Generic;
using System.IO;

namespace Travelling
{
    public class Logger<T>
    {
        private List<T> logs;

        public Logger()
        {
            logs = new List<T>();
        }

        public void Add(T log)
        {
            logs.Add(log);
        }

        public void Flush(string filepath)
        {
            foreach (T log in logs)
            {
                File.AppendAllText(filepath, log + "\n");
            }
            logs.Clear();
        }
    }
}