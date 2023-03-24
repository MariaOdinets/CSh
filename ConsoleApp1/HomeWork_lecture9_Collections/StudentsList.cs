using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_homeworks.HomeWork_lecture9_Collections
{
    public class StudentsList
    {
        static Dictionary<int, string> list = new Dictionary<int, string>()
        {
                    {1,"Misha"},
                    {2,"Dasha"},
                    {3,"Anatoli"},
                    {4,"Alex"},
                    {5,"Ivan"},
                    {6,"Anya"},
                    {7,"Lena"},
                    {8,"Yana"},
                    {9,"Lera"},
                    {10,"Pasha"}
        };

        public static void Print()
        {
            foreach (var person in list)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
    }
}