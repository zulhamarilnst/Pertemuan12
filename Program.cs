using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN10
{
     class Program
    {
        static void Main(string[] args)
        {
            //Make a Array
            string[] arrName = {"Erik", "wely", "sony"};
            string[] arrNim = {"1234", "1235", "1235"};
            int[] arrNilai = {75, 80, 95};

            //Tabel for array
            Console.WriteLine("NO       Nim        Name        Score");
            Console.WriteLine("=====================================");

            //for a array
            for (int i = 0; i < arrName.Length; i++)
                    {
                        Console.WriteLine($"{(i + 1).ToString().PadRight(8)} {arrNim[i]} {arrName[i].PadLeft(10)} {arrNilai[i].ToString().PadLeft(11)}");
                    }

        }
    }

}