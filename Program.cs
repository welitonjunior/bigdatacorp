using System;
using System.Linq;

namespace AppBigData
{
    class Program
    {

        public static string RunLength(string str)
        {
            string vari = str;
            string temp;
            char[] charS;
            int count;
            string retorno = "";

            while (vari.Length > 0)
            {
                temp = vari.Substring(0, 1);
                charS = temp.ToCharArray();
                count = vari.Count(s => s == charS[0]);
                vari = vari.Replace(temp, "");

                retorno += count + temp;
            }

            // code goes here  
            return retorno;

        }

        public static int LargestFour()
        {
            int[] arr = { 4, 5, -2, 3, 1, 2, 6, 6 };

            int[] newArr = arr.OrderByDescending(i => i).ToArray();

            int retorno = 0;


            if (newArr.Length > 3)
            {

                retorno = newArr[0] + newArr[1] + newArr[2] + newArr[3];

            }
            else
            {
                throw new Exception("array com menos de 4 posições");
            }

            // code goes here  
            return arr[0];

        }

        public static string PalindromicSubstring(string str)
        {
            string tNormal = str;
            string temp, retorno = "", ordenado = "";
            char[] arrStr;
            arrStr = tNormal.ToCharArray();
            Array.Sort(arrStr);
            int count = 0;

            foreach (var item in arrStr) { ordenado += item; }

            string repeticoes = RunLength(ordenado);

            while (repeticoes.Length > 0)
            {
                int quantidade = Int32.Parse(repeticoes.Substring(0, 1));
                string letra = repeticoes.Substring(1, 1);

                if (quantidade > 1)
                {

                    int primeira = tNormal.IndexOf(letra);
                    int segunda = tNormal.LastIndexOf(letra);

                    temp = tNormal.Substring(primeira, (segunda - primeira) + 1);

                    if ((temp.SequenceEqual(temp.Reverse())) && (temp.Length > count))
                    {
                        count = temp.Length;
                        retorno = temp;
                    }

                }

                repeticoes = repeticoes.Substring(2);

            }

            return String.IsNullOrEmpty(retorno) ? "A palavra não é um palíndromo" : retorno;
        }

        static void Main()
        {
            // keep this function call here
            //Console.WriteLine(RunLength(Console.ReadLine()));
            //Console.WriteLine(LargestFour());
            Console.WriteLine(PalindromicSubstring("hellosannasmith"));
        }

    }
}
