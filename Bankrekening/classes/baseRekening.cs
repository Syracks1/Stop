using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bankrekening.classes
{
    public class baseRekening
    {
        private int rekeningnummer;
        private string naam;
        private int saldo;
        private static int volgendNummer = 1;

        public baseRekening left;
        public int Rekeningnummer { get; set; }
        public string Naam { get; set; }
        public int Saldo { get { return saldo; } set { saldo = value; } }

        public baseRekening(string naam)
        {
            Naam = naam;
            Saldo = 0;
            Rekeningnummer = volgendNummer;
            volgendNummer++;
        }

        public baseRekening()
        {
            //Hier volgt normaal code, maar dit is een voorbeeld
        }

        public override string ToString()
        {
            return string.Concat(Saldo, " ", Naam);
        }

        public void WriteFile()
        {
            string pad = @"E:\verplaats\map1\" + "Bank" + ".txt";

            try
            {
                if (File.Exists(pad))
                {
                    //Console.WriteLine("bestaat al met de naam: " + pad);
                    //MessageBox.Show("bestaat al met de naam: " + pad);
                    using (StreamReader reader = File.OpenText(pad))
                    {
                        string text = "";
                        if((text = reader.ReadLine()) == null)
                        {
                            ToString();
                        }
                        while ((text = reader.ReadLine()) != null)
                        {
                            //Console.WriteLine("Dit is de text in het bestand: " + text);
                            MessageBox.Show("Dit is de text in het bestand: " + text);
                        }
                        
                    }
                    //reader.Close();
                }

                else
                {
                    File.Create(pad);
                    //Console.WriteLine("file gemaakt met de naam " + pad);
                    MessageBox.Show("file gemaakt met de naam" + pad);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //reader.Close();
            }
        }

        public int NeemOp(int bedrag)
        {
            Saldo = Saldo - bedrag;

            return Saldo;
        }

        public int currentSaldo()
        {
            return Saldo;
        }

        public int Add(int request)
        {
            Saldo = Saldo + request;

            return Saldo;
        }

        public int Take(int request)
        {
            if (Saldo - request < 0)
            {
                MessageBox.Show("You can't go below 0");
                return this.Saldo;
            }
            else
            {
                return NeemOp(request);
            }

        }

    }
}
