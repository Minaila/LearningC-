using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
   public class FileManager
    {
        //public string ReadTxt()
        //{
        //    string text = File.ReadAllText("E:\\C#\\urlbaza.txt");
        //    return text;
        //}
        //public string ReadWebsite()
        //{
        //    string text = File.ReadAllText("E:\\C#\\websites.txt");
        //    return text;
        //}
        public string Read(string Path)
        {
            string text = File.ReadAllText(Path);
            return text;
        }
        public void Write(string resultPath, string result )
        {
            using (var writer = File.AppendText(resultPath))
            {
                writer.Write(result + Environment.NewLine) ;
            }
            //File.WriteAllText(resultPath, result);
        }
    }
}
