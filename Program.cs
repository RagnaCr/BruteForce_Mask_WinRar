using System;
using System.Diagnostics;
using System.IO;
using static BruteForce_Mask_WinRar.Brute;
using System.Threading;

namespace BruteForce_Mask_WinRar
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\LPayr\Desktop\111.rar";
            GetBrut(ThreeConBrutForce(), path);
        }
        static void SpeedTest()
        {
            string[] c = ThreeLetterBrutForce();
            Stopwatch f = new Stopwatch();
            f.Start();
            foreach (string item in c)
            {
                Console.Write(item + " ");
            }
            f.Stop();
            Console.WriteLine("THIS " + f.ElapsedMilliseconds);
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            s.Stop();
            Console.WriteLine("THIS " + s.ElapsedMilliseconds);
        }
        static void GetBrut(string[] pass, string path, out bool res)
        {
            res = false;
            Process p = new Process();
            string[] comands = { "@echo off", @"cd /D C:\Program Files\WinRAR", $"RAR p -p123 {path}" };
            for (int i = 0; i < pass.Length; i++)
            {
                comands[2] = $"RAR p -p{pass[i]} {path}";
                File.WriteAllLines(@"test.bat", comands);

                p.StartInfo.FileName = "test.bat";
                p.StartInfo.Arguments = "test.bat";
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();

                string output;
                while ((output = p.StandardOutput.ReadLine()) != null)
                {
                    if (output.Contains("Готово"))
                    {
                        res = true;
                        Console.WriteLine($"\n\nPassword - {pass[i]}\n");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine(output);
                        return;
                    }
                }
                p.Close();
            }
        }
        static void GetBrut(object obj)
        {
            string[] pass;
            string path;
            Brute brute = (Brute)obj;
            pass = brute.pass;
            path = brute.path;

            Process p = new Process();
            string[] comands = { "@echo off", @"cd /D C:\Program Files\WinRAR", $"RAR p -p123 {path}" };
            for (int i = 0; i < pass.Length; i++)
            {
                comands[2] = $"RAR p -p{pass[i]} {path}";
                File.WriteAllLines(@"test.bat", comands);

                p.StartInfo.FileName = "test.bat";
                p.StartInfo.Arguments = "test.bat";
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();

                string output;
                while ((output = p.StandardOutput.ReadLine()) != null)
                {
                    if (output.Contains("Готово"))
                    {
                        Console.WriteLine($"\n\nPassword - {pass[i]}\n");
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine(output);
                        return;
                    }
                }
                p.Close();
            }
        }
        static void GetBrut(string[] pass, string path)
        {
            Process p = new Process();
            string[] comands = { "", @"cd /D C:\Program Files\WinRAR", $"RAR p -p123 {path}" };
            for (int i = 0; i < pass.Length; i++)
            {
                Console.WriteLine(pass[i]);
                comands[2] = $"RAR p -p{pass[i]} {path}";
                File.WriteAllLines(@"test.bat", comands);

                p.StartInfo.FileName = "test.bat";
                p.StartInfo.Arguments = "test.bat";
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                
                string output;
                while ((output = p.StandardOutput.ReadLine()) != null)
                {
                    Console.WriteLine(output);
                    if (output.Contains("Готово"))
                    {
                        Console.WriteLine($"\n\nPassword - {pass[i]}\n");
                        return;
                    }
                }
                p.Close();
            }
        }
        
    }
}
