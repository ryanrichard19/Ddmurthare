using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTableChecker.Library
{
    public class Element
    {
        private string Name { get; set; }
        private string Symbol { get; set; }

        public Element(string n, string s)
        {
            Name = n;
            Symbol = s;
        }

        public bool CheckElementRule()
        {
            bool check = false;
            if (Symbol.Length > 1)
            {
                var tempName = Name;
                var letters = Symbol.ToArray();
                if (char.IsUpper(letters[0]))
                {
                    if (Name.ToLower().IndexOf(char.ToLower(letters[0])) > -1)
                    {
                        tempName = Name.Substring(Name.ToLower().IndexOf(char.ToLower(letters[0]))+ 1, (Name.Length-1) - Name.ToLower().IndexOf(char.ToLower(letters[0])));
                        if (tempName.IndexOf(letters[1]) > -1)
                            check = true;
                    }
                }
            }
            return check;
        }
    }
}
