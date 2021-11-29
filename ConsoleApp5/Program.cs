using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result *= 3;
                Console.WriteLine(result);

                Islemler instance = new();
                Console.WriteLine(instance.Expo(3,4));

                string ifade = "Hasan Can TURAL";
                bool sonuc= ifade.CheckSpaces();
                if (sonuc)
                {
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                    Console.WriteLine(ifade.MakeUppercase());
                    Console.WriteLine(ifade.MakeLowercase());

                    int[] dizi = {9,3,6,2,1,5,0};
                    dizi.SortArray();
                    dizi.EkranaYazdiz();
                }
            }
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2)
                return sayi;

            return Expo(sayi, üs - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("--",dizi);
        }

        public static string MakeUppercase(this string param) 
        {
            return param.ToUpper();
        }

        public static string MakeLowercase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdiz(this int[] param)
        {
            foreach( int item in param)
            {
                Console.Write(item);
            }
        }
    }
}
