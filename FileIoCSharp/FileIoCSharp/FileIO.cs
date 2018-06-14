using System;
using System.IO;

namespace FileIoCSharp
{
    class FileIO
    {
        static void Main(string[] args)
        {
            int sum = 0;
            using (StreamReader sr = File.OpenText("D:\\repo\\FileIOC-\\FileIOC-\\FileIoCSharp\\FileIoCSharp\\Numbers.txt"))
            {
                if (sr.ToString() != null)
                {

                    string s = "";
                    do
                    {
                        s = sr.ReadLine();
                        int x = 0;
                        Int32.TryParse(s, out x);
                        sum += x;
                    } while (s != null);
                }
            }

            using (StreamWriter file = new System.IO.StreamWriter("D:\\repo\\FileIOC-\\FileIOC-\\FileIoCSharp\\FileIoCSharp\\Results.txt"))
            {
                file.WriteLine(sum);
            }
        }
    }
}
