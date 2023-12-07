using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace assignment1;


internal class Program
{
    static void Main(string[] args)
    {
        int beer = 100;
        while (beer > 2)
        {
            Console.WriteLine(beer + " bottles of beer on the wall," + beer + " bottles of beer");
            beer--;
            Console.WriteLine("Take one down and pass it around, " + beer + " bottles of beer on the wall.");
        }
        Console.WriteLine(beer + " bottles of beer on the wall," + beer + " bottles of beer");
        beer--;
        Console.WriteLine("Take one down and pass it around, " + beer + " bottle of beer on the wall.");
        Console.WriteLine(beer + " bottle of beer on the wall," + beer + " bottle of beer");
        
    }
}