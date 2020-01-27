using System;
using System.Collections.Generic;
using System.IO;

namespace StrutturaDati
{
    class Program
    {
        private static string line;

        static void Main(string[] args)
        {
            const string FILEWRITE = "newfile.txt";
            const string FILEREAD = "file.txt";
            List<double> doubleList = new List<double>();
            using (StreamReader r = new StreamReader(FILEREAD))
            {
                while ((line = r.ReadLine()) != null)
                {
                    double d = double.Parse(line);
                    doubleList.Add(d);
                }
            }
            using (StreamWriter w = new StreamWriter(FILEWRITE))
            {
                for (int i = doubleList.Count - 1; i >= 0; i--)
                {
                    w.WriteLine(doubleList[i]);
                }
            }
        }
    }
}
