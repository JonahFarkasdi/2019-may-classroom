using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            My_Data aVariable;

            My_Data anInstance = new My_Data();

            if(aVariable == null)
            {
                Console.WriteLine("aVariable has nothing in it");
            }

            if(anInstance == null)
            {
                Console.WriteLine("anInstance has nothing in it");
            }
            Console.ReadLine();
        }//main
    }//class program
}//namespace
