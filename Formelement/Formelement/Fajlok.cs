using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formelement
{
   class Fajlok
    {
        static public void Save(string fileofname, string inputstr)
        { 
            StreamWriter writefile = new StreamWriter(fileofname, true, Encoding.Unicode);
            writefile.WriteLine(inputstr);
            writefile.Close();
        }
        static public string Open(string fileofname)
        {
            string text = string.Empty;
            StreamReader readfile = new StreamReader(fileofname);
            while (!readfile.EndOfStream)
            {
                text += readfile.ReadLine() + "\n";
            }
            readfile.Close();
            return text;
        }
    }
}
