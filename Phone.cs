using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuseppe_CSharp_Practice
{
    internal class Phone
    {

        public string PhoneType;
        public long PhoneNumber;
        public Phone(string aPhoneType, long aPhoneNumber)
        {
            PhoneType = aPhoneType;
            PhoneNumber = aPhoneNumber;
        }





        public void SayYourPhone()
        {
            Console.WriteLine(PhoneType);
        }

    }
 
}
