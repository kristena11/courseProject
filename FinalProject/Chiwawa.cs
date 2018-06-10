using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Chiwawa : Dog
    {
        public Chiwawa()
        {
            Console.WriteLine(" I am a Chiwawa");
        }

        public Chiwawa(string name, long chip, DateTime arrivalDate, Boolean adoptedStatus)
            : base(name, chip, arrivalDate, adoptedStatus)
        {
            Console.WriteLine("I am a Chiwawa Chip:{Chip}\n Arrived:{ArrivalDate}\n Adopted: {AdoptedStatus}\n");
        }
        public override void Noise()
        {

        }
    }
}
