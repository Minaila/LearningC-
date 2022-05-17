using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class MicrsoftPage
    {
        public ChromeDriver Driver = new ChromeDriver();



        public void Open(string sites)
        {


            var navigate = Driver.Navigate();
            navigate.GoToUrl(sites); //works
            Thread.Sleep(2000);
        }
        public string IsUrlCompliant(string URL)
        {
            var date = DateTime.Now;
            if (Driver.Url == URL)
            {
                var result = date.ToString() +  " testul a avut succes";
                return result;
            }
            else
            {
                var result = date.ToString() + " test failed" + " ne asteptam la URLul " + URL + " dar in browser a fost gasit URLul  " + Driver.Url;
                return result;
            }
            
        }
        public int Add(int x, int y)
        {
            return(x+y);
        }

    }
}  
