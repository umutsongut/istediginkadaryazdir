﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İstediginMetniİstediginKadarYazdir
{
    class Program
    {
        static void Main(string[] args)
        {
            //istediğiniz metni istediğiniz kadar yazdırabilmek//
            int i;
            string metin;
            int deneme = 0;
            int t;

            Console.Write("Yazdırmak İstediğiniz Metni Girin: ");
            metin = Console.ReadLine();

            Console.Write("Metni Kaç Kez Tekrarlamak İstiyorsunuz?");
            t = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= t; i++)
            {
                deneme++;
                Console.WriteLine($"{deneme}.Deneme, {metin}");
            }
        }
    }
}
