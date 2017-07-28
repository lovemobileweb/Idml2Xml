using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idml;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections;

namespace Idml2Xml
{
    class Program
    {
        enum Color : int
        {
            Blue,
            Red,
            Green,
            Yellow,
            Orange
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Idml document tester");

            string[] testfiles = null;

            testfiles = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "testfiles"), "*.idml");

            Console.WriteLine("Found {0} documents.", testfiles.Length);

            foreach (string file in testfiles)
            {
                IdmlFile document = new IdmlFile();

                try
                {
                    document.Open(file);

                    Console.WriteLine("Document opened successfully: {0} ", Path.GetFileName(file));

                    string path = Path.Combine(Environment.CurrentDirectory, "testfiles\\Saved.xml");
                    document.SaveAsArticle(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Document failed to open: {0} ", Path.GetFileName(file));
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
