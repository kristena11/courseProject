using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Dog : Pet
    {
        public Dog()
        {
            Console.WriteLine(" Dog:");
        }

        public Dog(string name, long chip, DateTime arrivalDate, Boolean adoptedStatus)
            : base(name, chip, arrivalDate, adoptedStatus)
        {
            Console.WriteLine("Dog:");
        }
        public override void Noise()
        {
            //Console.WriteLine("Dog");
        }
    }
}
