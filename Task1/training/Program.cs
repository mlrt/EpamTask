using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
namespace training
{
    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\d+\.\d+\,\d+\.\d+");
            Match match = regex.Match("43.54,25.2");
            string q = "43.54,25.2";
            if (q == match.Value)
            {
                Console.WriteLine("Ok");
            }
            
            
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
            //}
        }
    }
}


