using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpBasic
{

    class Program
    {
        public const string linksPath = "E:\\C#\\urlbaza.txt";
        public const string sitesPath = "E:\\C#\\websites.txt";
        public const string resultPath = "E:\\C#\\rapoarteTeste.txt";


        //Entry point of your program

        static void Main(string[] args)
        {
            var fileManager = new FileManager();
           
      
            var microsoftPage = new MicrsoftPage();
            var links = fileManager.Read(linksPath);
            var sites = fileManager.Read(sitesPath);
            microsoftPage.Open(sites);
            var isCompliant = microsoftPage.IsUrlCompliant(links);
            fileManager.Write(resultPath, isCompliant);
            //TODO - call the method to close the browser
           

            var suma = microsoftPage.Add(5, 8);

            Console.ReadLine();
        }
    }



    
}