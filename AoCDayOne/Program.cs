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
            int total;
            int finaltotal=0;
            try
            {
                StreamReader sr = new StreamReader(@"C:\\MaxwellBilango\\CSharpCode\\AoCDayOne\\inputlist.txt"); //Reading text file
                line = sr.ReadLine();

                List<string> linesleft = new List<string>();
                List<string> linesright = new List<string>();

                while (line != null)
                {
                    string left = line.Substring(0, 5); //Splitting each number from one line into a seperate list
                    linesleft.Add(left);
                    string right = line.Substring(8);
                    linesright.Add(right);


                    line = sr.ReadLine(); //Read next line
                }

                linesleft.Sort(); //Sorts each list into lowest to highest
                linesright.Sort();

                for (int i = 0; i < linesleft.Count; i++)
                {
                    int left = Int32.Parse(linesleft[i]); //Converts each number in both lists to an integer
                    int right = Int32.Parse(linesright[i]);
                    total = left - right;
                    int absolutetotal = Math.Abs(total); //Removes any negative totals
                    finaltotal = finaltotal + absolutetotal;
                }
                Console.WriteLine(finaltotal); //Calculates final total

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
