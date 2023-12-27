using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson2Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string name = "Ko Tang eii na mo";
            string gender = "M";
            string address = "PP";
            int tell = 098424837;
            Console.WriteLine("-----Report_User-----");
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Please Tell Me:" + tell);
            Console.WriteLine("---------------------");
          
        }
    }
}

