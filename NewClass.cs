using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    interface ICateF
    {
        string Family;
        int Age;
        int Speed; 
    }
    
    public class NewClass
    {
        public static void Main(string[] args)
        {
            ICateF CTF = new White();
            ((White)CTF).Move;
        }
        
    }

    class White : ICateF
    {
        int Price = 5,000;

        public void Move()
        {
            Console.WriteLine($"We move to fly at {Price}");
        }
    }
}