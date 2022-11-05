using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_.NET.PersonModels
{

    
    public class Person
    {

        public string ? NamePerson { get; set; }
        public int YearsOld { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Hello I'm {NamePerson},\nand my years old is {YearsOld}");
        }
    }
}