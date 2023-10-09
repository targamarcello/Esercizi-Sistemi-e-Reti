using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = new bool[5] { true, false, false, true, false };
            int[] dp = { 10, 10, 10, 10 };
            int conversione1, conversione2;
            conversione1 = ConvertBinarioToIntero(b);
            Console.WriteLine(conversione1);
            Console.WriteLine("------------------");
            conversione2 = ConvertDecimalePuntatoToIntero(dp);
            Console.WriteLine(conversione2);
            Console.ReadLine();
        }
        static int ConvertBinarioToIntero(bool[] b)
        {
            int convertito, v = 0;
            double conversione = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                if (b[i])
                {
                    conversione = conversione + (1 * Math.Pow(2, v));

                }
                v++;
            }
            Console.WriteLine(conversione);
            convertito = (int)conversione;
            return convertito;
        }

        static int ConvertDecimalePuntatoToIntero(int[] dp)
        {
            double convertito = 0;
            int v = 0;
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                convertito = convertito + (dp[i] * Math.Pow(256, v));
                v++;
            }
            Console.WriteLine(convertito);
            return (int)convertito;
        }
        static bool[] Convert_Numero_Decimale_To_Binario(long numero)
        {
            long resto;
            bool[] bit = new bool[32];
            int t = bit.Length - 1;
            do
            {
                resto = numero % 2;
                if (resto == 1)
                {
                    bit[t] = true;
                }
                else
                {
                    bit[t] = false;
                }
                t--;
                numero = numero / 2;
            } while (numero > 0);
            return bit;
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(long numero)
        {
            int[] dp = new int[4];
            int i = 0;
            long r;
            do
            {
                r = numero % 256;
                dp[i] = Convert.ToInt32(r);
                numero = numero / 256;
                i++;

            } while (numero > 0);
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine(dp[i]);
            }
            return dp;

        }
    }
}
