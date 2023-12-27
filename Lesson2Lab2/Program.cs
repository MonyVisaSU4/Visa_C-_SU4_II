using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string gender;
            string address;
            int tell;
            Console.WriteLine("------Input_data-------");
            Console.Write("ID:");
            id=int.Parse(Console.ReadLine());
            Console.Write("Name:");
            name=Console.ReadLine();
            Console.Write("Gender:");
            gender=Console.ReadLine();
            Console.Write("Address:");
            address=Console.ReadLine();
            Console.Write("Please Tell:");
            tell = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------Report_User------------------------");
            Console.WriteLine("ID:" +id);
            Console.WriteLine("Name:" +name);
            Console.WriteLine("Gender:" +gender);
            Console.WriteLine("Address:" +address);
            Console.WriteLine("Please Tell:" +tell);
            Console.WriteLine("-----------------------------------------------------------");
            
            
        }
    }
}
