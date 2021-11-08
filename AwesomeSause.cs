using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class AwesomeSause
    {
        public List<string> Sauces { get; set; }

        public AwesomeSause()
        {
            Sauces = new List<string>();
        }

        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }

    }
}
