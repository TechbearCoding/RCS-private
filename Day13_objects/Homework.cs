using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_objects
{
    public class Homework
    {
        public static void Homework1()
        {
            List<String> list = new List<String>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet simbolu virkni!");
                String ievaditSimbolu = Console.ReadLine();
                list.Add(ievaditSimbolu);
            }

            WriteFile(list, false);
            ReadFile("data.txt");
        }

        public static void WriteFile(List<String> list, bool a)
        {
            String filename = "data.txt";
            try
            {

                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, filename);

                StreamWriter file = new StreamWriter(fullName, a);
                for (int i = 0; i < list.Count; i++)
                {
                    file.WriteLine(list[i]);
                }
                file.Flush();
                file.Dispose();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }


        public static void ReadFile(String filename)
        {
            List<String> result = new List<String>();
            try
            {

                String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String fullName = Path.Combine(desktopPath, filename);

                StreamReader sr = new StreamReader(fullName);

                String line = sr.ReadLine();

                while (line != null)
                {
                    result.Add(line);
                    line = sr.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(ex.Message);
            }

            WriteList(result);

        }


        public static void WriteList(List<String> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
