﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt3
{
    class Values
    {
        private static string thePathToTheFolder;

        public string ThePathToTheFolder
        {
            get { return thePathToTheFolder; }

            set
            {
                if (value != null)
                {
                    thePathToTheFolder = value;
                }
                else
                {
                    Console.WriteLine("Error! File is empty");
                }
            }
        }
    }
}
  
