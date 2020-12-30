using System;
using System.IO;
using System.Text;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Directory.GetCurrentDirectory();
            string csvFilename = "fifa2019.csv";
            string tsvFilename = "fifa2020.tsv";

            StringBuilder sB = new StringBuilder();
            using (System.IO.StreamReader rdr = new System.IO.StreamReader(Path.Combine(dir, csvFilename)))
            {
                int counter = 0;
                string line;
                while ((line = rdr.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    var csvLine = string.Join("\t", arr);
                    sB.Append(csvLine).Append("\n");
                    counter++;
                }
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(dir, tsvFilename)))
            {
                outputFile.Write(sB.ToString());
            }
        }

    }
}
