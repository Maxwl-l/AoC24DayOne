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

                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }

                for (int i = 0; i < lines.Count; i++)
                {
                    Console.WriteLine(lines[i]);
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
