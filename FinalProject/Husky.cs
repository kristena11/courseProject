using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Husky : Dog
    {
        public Husky()
        {
            Console.WriteLine(" I am a Husky");
        }

        public Husky(string name, long chip, DateTime arrivalDate, Boolean adoptedStatus)
            : base(name, chip, arrivalDate, adoptedStatus)
        {
            Console.WriteLine("I am a Husky Chip:{Chip}\n Arrived:{ArrivalDate}\n Adopted: {AdoptedStatus}\n");
        }
        public override void Noise()
        {

        }
    }
}
