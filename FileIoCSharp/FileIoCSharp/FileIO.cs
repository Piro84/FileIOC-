using System;
using System.Collections.Generic;
using System.Text;

namespace FileIoCSharp
{
    class FileIO
    {
        

        
        using (StreamReader sr = File.OpenText(FilePath))
        {
            string currentLine = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}

