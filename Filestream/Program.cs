using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cijfer = rnd.Next(1, 5);
            string pad = @"E:\verplaats\map1\" + cijfer + ".txt";

            try
            {
                if(File.Exists(pad))
                {
                    Console.WriteLine("bestaat al met de naam: " + pad);
                    using (StreamReader reader = File.OpenText(pad))
                    {
                        string text = "";
                        while ((text = reader.ReadLine()) != null)
                        {
                            Console.WriteLine("Dit is de text in het bestand: " + text);
                        }
                    }
                }

                else
                {
                    File.Create(pad);
                    Console.WriteLine("file gemaakt met de naam " + pad);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
