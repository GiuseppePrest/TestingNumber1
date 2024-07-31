using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuseppe_CSharp_Practice
{
    internal class Chef
    {
        public void MakeARissoto() 
        {
            Console.WriteLine("I am making a Rissoto.");
        }

        public void MakeASoup()
        {
            Console.WriteLine("I have made you a soup.");
        }

        public virtual void MakeMeAGelato()
        {
            Console.WriteLine("I made you a gelato");
        }
            
            }
}
