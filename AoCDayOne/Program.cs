using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCDayOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"C:\\MaxwellBilango\\CSharpCode\\AoCDayOne\\inputlist.txt");
                line = sr.ReadLine();

                List<string> lines = new List<string>();
                List<string> linesleft = new List<string>();
                List<string> linesright = new List<string>();

                while (line != null)
                {
                    string left = line.Substring(0, 5);
                    linesleft.Add(left);
                    string right = line.Substring(8);
                    linesright.Add(right);

                    lines.Add(line);

                    line = sr.ReadLine();
                }

                for (int i = 0; i < lines.Count; i++)
                {
                    Console.WriteLine(linesleft[i] + linesright[i]);
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            Console.ReadLine();
        }
    }
}
