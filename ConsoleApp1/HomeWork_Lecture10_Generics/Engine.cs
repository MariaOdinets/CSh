using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_Lecture10_Generics
{
    abstract class Engine
    {
        public string Type { get; set; }
        public string FuelType { get; set; }
        protected Engine() 
        {
            
        }
    }
}