using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {


        public static void Main(string[] args)
        {
         



            string myName;
            Console.WriteLine( "Please enter your name and press enter. " );
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case : {0}", myName.ToUpper());
            Console.WriteLine(myNameUpperCase);
                 
           




        }
   

    
    }
}
