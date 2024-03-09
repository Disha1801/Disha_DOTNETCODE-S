using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanLibrary._0_CSharp_Basics
{
    
        public class Class_Indexer
        {
            //Indexer syntax
            private string[] flowerName = new string[10];
            public string[] arr;
            public string this[int i]
            {
                get
                {
                    return flowerName[i];
                }
                set
                {
                    flowerName[i] = value;
                }
            }
        }
    }


