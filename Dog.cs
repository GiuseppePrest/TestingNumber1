using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuseppe_CSharp_Practice
{
    internal class Dog
    {
        public string Name;
        public string EyeColour;
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void SayYourName()
        {
            Console.WriteLine(Name);
        }


        public void SayYourEyeColour()
            {
                Console.WriteLine(EyeColour);
        }

    }
}
