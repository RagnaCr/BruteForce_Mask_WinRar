using System;
using System.Linq;

namespace BruteForce_Mask_WinRar
{

    class Brute
    {
        public string[] pass;
        public string path;
        public Brute(string[] pass, string path)
        {
            this.pass = pass;
            this.path = path;
        }
        static char[] GetLetters()
        {
            // по 26 букв, 97-122 65-90
            char[] let = new char[52];
            for (int i = 0; i < 52; i++)
            {
                if (i >= 26) { let[i] = (char)(i + 71); continue; }
                let[i] = (char)(i + 65);

            }
            return let;
        }
        static string[] NumsLetters()
        {
            string[] a = OneLetterBrutForce();
            string[] b = OneBrutForce();
            string[] c = a.Concat(b).ToArray();
            return c;
        }
        public static string[] OneConBrutForce()
        {
            return NumsLetters();
        }
        public static string[] TwoConBrutForce()
        {
            string[] a = NumsLetters();
            string[] pass = new string[a.Length * a.Length];
            int count = 0;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    pass[count] = $"{a[j]}{a[i]}";
                    count++;
                }
            }
            return pass;
        }
        public static string[] ThreeConBrutForce()
        {
            string[] a = NumsLetters();
            string[] pass = new string[a.Length * a.Length * a.Length];
            int count = 0;
            for (int k = 0; k < a.Length; k++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        pass[count] = $"{a[k]}{a[j]}{a[i]}";
                        count++;
                    }
                }
            }
            return pass;
        }
        public static string[] FourConBrutForce()
        {
            string[] a = NumsLetters();
            string[] pass = new string[a.Length * a.Length * a.Length * a.Length];
            int count = 0;
            for (int r = 0; r < a.Length; r++)
            {
                for (int k = 0; k < a.Length; k++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        for (int i = 0; i < a.Length; i++)
                        {
                            pass[count] = $"{a[r]}{a[k]}{a[j]}{a[i]}";
                            count++;
                        }
                    }
                }
            }
            return pass;
        }
        public static string[] OneLetterBrutForce()
        {
            char[] a = GetLetters();
            string[] pass = new string[52];
            for (int i = 0; i < a.Length; i++)
            {
                pass[i] = a[i].ToString();
            }
            return pass;
        }
        public static string[] TwoLetterBrutForce()
        {
            string[] a = OneLetterBrutForce();
            int count = 0;
            string[] pass = new string[52 * 52]; // a(54) b(54)
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    pass[count] = $"{a[j]}{a[i]}";
                    count++;
                }
            }
            return pass;
        }
        public static string[] ThreeLetterBrutForce()
        {
            string[] a = OneLetterBrutForce();

            int count = 0;
            string[] pass = new string[52 * 52 * 52]; // a(52)(52) bb(52)
            for (int k = 0; k < a.Length; k++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        pass[count] = $"{a[k]}{a[j]}{a[i]}";
                        count++;
                    }
                }
            }

            return pass;
        }
        public static string[] OneBrutForce()
        {
            string[] pass = new string[10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                pass[count] = $"{i}";
                count++;
            }
            return pass;
        }
        public static string[] TwoBrutForce()
        {
            string[] pass = new string[100];
            int count = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    pass[count] = $"{j}{i}";
                    count++;
                }
            }
            return pass;
        }
        public static string[] ThreeBrutForce()
        {
            string[] pass = new string[1000];
            int count = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        pass[count] = $"{k}{j}{i}";
                        count++;
                    }
                }
            }
            return pass;
        }
        public static string[] FourBrutForce()
        {
            string[] pass = new string[10000];
            int count = 0;
            for (int r = 0; r < 10; r++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            pass[count] = $"{r}{k}{j}{i}";
                            count++;
                        }
                    }
                }
            }
            return pass;
        }
        public static string[] FiveBrutForce()
        {
            string[] pass = new string[100000];
            int count = 0;
            for (int g = 0; g < 10; g++)
            {
                for (int r = 0; r < 10; r++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                pass[count] = $"{g}{r}{k}{j}{i}";
                                count++;
                            }
                        }
                    }
                }
            }

            return pass;
        }
        public static void Puts(string[] a)
        {
            for (int i = 1; i <= a.Length; i++)
            {
                Console.Write(a[i - 1] + " ");
                if (i % 40 == 0) { Console.WriteLine(); }
            }
            Console.WriteLine();
        }
    }
}
