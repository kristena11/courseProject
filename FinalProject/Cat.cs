using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Cat : Pet
    {
        public Cat()
        {
            Console.WriteLine(" Cat:");
        }

        public Cat(string name, long chip, DateTime arrivalDate, Boolean adoptedStatus)
            : base(name, chip, arrivalDate, adoptedStatus)
        {
            Console.WriteLine("Cat:");
        }
        public override void Noise()
        {
            Console.WriteLine("cat");
        }
    }
}
