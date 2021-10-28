using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoETL;
namespace Verisk
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadLines("ScriptTask.txt");

            var sb = new StringBuilder();

      

            using (var output = new StreamWriter("ScriptConv2.csv"))

            {                   
              foreach (var line in input)
                {
                   {
                        var values = line.Split(new char[] { '\t', ',' }, 8, StringSplitOptions.RemoveEmptyEntries);
                        sb.Clear()                        
                            .Append(values[0]).Append(',')
                            .Append(values[1]).Append(',')                    
                            .Append(values[2]).Append(',')
                            .Append(values[3]).Append(',')
                            .Append(values[4]).Append(',')
                            .Append(values[5]).Append(',')
                            .Append(values[6]).Append(',')
                            .Append(values[7]);

                        output.WriteLine(sb.ToString());
                        sb.Replace("    ", ",");
                    }
                }
            }

            string path = @"E:\Verisk Task2\Verisk\bin\Debug\ScriptTask.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
         
            StringBuilder builder = new StringBuilder();

        foreach (string line in lines)

        {
            var temp = line.Split(',');
            builder.AppendLine(string.Join(",", temp[0], temp[0]));
            sb.AppendLine(string.Join(",", temp[0], temp[0]));
        }

        using (var output = new StreamWriter("TestingJason.json"))
            {              
                var input2 = File.ReadLines("ScriptConv2.csv").Take(6);  
                StringBuilder sb2 = new StringBuilder();
                using (var p = ChoCSVReader.LoadLines(input2).WithFirstLineHeader())
                {
                    using (var w = new ChoJSONWriter(sb2))
                        w.Write(p);
                }

                Console.WriteLine(sb2.ToString());
                System.IO.File.WriteAllText(@"D:TestFile.json", sb2.ToString());
                Console.ReadLine();
                //new StreamWriter("TestingJason.json");
            }
           

        }
        
       




    }


   

}
