using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuseppe_CSharp_Practice
{
    internal class PersonPower
    {
        string Name { get; set; }
        string Gender { get; set; }
        int Power { get; set; }

        public PersonPower(string AName, string AGender, int APower)
        {
            Name = AName;
            Gender = AGender;
            Power = APower;
        }
            public bool AreYouStrong()
            {
                if (Power >= 10)
                {
                    return true;
                }
                return false;
            }
        }
    }

