using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html2cpp
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete(args[1]);
            Console.WriteLine("Creating " + args[1]);
            Console.WriteLine(" reading << " + Path.GetFullPath(args[0]));
            var lines = File.ReadAllLines(args[0]);
            var outlines = new List<string>();
            outlines.Add($"String {Path.GetFileName(args[2])} = ");
            foreach(var line in lines)
            {
                outlines.Add($"\"{line.Replace("\"","\\\"")}\\r\\n\"");
            }
            outlines.Add($";");
            File.WriteAllLines(args[1], outlines, Encoding.ASCII);
            Console.WriteLine(" writing >> " + Path.GetFullPath(args[1]));
        }
    }
}
