using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day13_objects
{
    public class FIleIO
    {
        public static void ReadFile()
        {
            try
            {
                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, "test.txt");

                StreamReader sr = new StreamReader(fullName);
                // //Users//username//Desktop
                String line = sr.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
