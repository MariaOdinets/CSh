﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6.Clinic
{
    internal class Surgeon : Doctor
    {
        public Surgeon() 
        {

        }    
        public override void Treat()
        {
            Console.WriteLine("Medical conclusion: I suggest to cut this off");
        }
    }
}