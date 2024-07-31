using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giuseppe_CSharp_Practice
{
    internal class Watch
  {
        public string WatchType { get; set; }
        private string WatchSize { get; set; }


        public Watch(string AWatchType, string AWatchSize)
        {
            watchType = AWatchType;
            WatchSize = AWatchSize;
        }

        public string watchType
        {
            get { return WatchType; }
            set {
                if (value == "Digital" || value == "Not Digital" || value == "NR" )
                {
                    WatchType = value;
                }
                else 
                {
                    WatchType = "NR";
                }
            }
        }
    }
    }


