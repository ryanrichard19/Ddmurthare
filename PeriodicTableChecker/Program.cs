using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PeriodicTableChecker.Library;
using System.Text.RegularExpressions;

namespace PeriodicTableChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ToExit = false;
            var input = "";
            while (!ToExit)
            {
                Console.WriteLine("Please enter Element Name and Symbol seperated by a ','(commma) (eg. Spenglerium, Ee):");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    var inputArr = input.Split(',');
                    if ((inputArr.Count() == 2) && (Regex.IsMatch(inputArr[0].Trim(), @"^[a-zA-Z]+$")) && Regex.IsMatch(inputArr[1].Trim(), @"^[a-zA-Z]+$"))
                    {
                        var element = new Element(inputArr[0].Trim(), inputArr[1].Trim());
                        Console.WriteLine(input + " -> " + (element.CheckElementRule()).ToString().ToLower());
                    }
                    else
                    {
                        Console.WriteLine("Incorrect format entered. Only alphabets are allowed in Name and Symbol.");
                    }
                    ToExit = false;
                }
                else
                {
                    ToExit = true;
                }
            }
            
        }
    }
}
