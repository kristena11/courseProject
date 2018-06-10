using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Pet
    {

        #region Fields
        protected long chip;
        protected DateTime ArrivalDate;
        public string name;
        protected bool AdoptedStatus;
        public static int petCount = 0;
       

        #endregion End of Fields

        #region Constructors 
        public Pet()
        {
            chip = 0;
            AdoptedStatus = false;
            petCount++;
        }
        public Pet(string name, long chip, DateTime arrivalDate, Boolean adoptedStatus)
        {
            this.chip = chip;
            ArrivalDate = arrivalDate;
            AdoptedStatus = adoptedStatus;
            this.name = name;
            petCount++;
            
        }
        #endregion End of Constructors

        #region Properties



        public int PetCount
        {
            get
            {
                return petCount;
            }
        }
        public long Chip
        {
            get
            {
                return chip;
            }
            set
            {
                if (value > 0)
                    chip = value;
                else
                    chip = 0;
            }
        }

        public DateTime arrivalDate { get; set; }

       

        public Boolean adoptedStatus { get; set; }



        #endregion End Properties

        #region Methods

        public bool UpdateStatus() => adoptedStatus = true;
        public int UpdateInventory() => petCount = petCount - 1;
        public abstract void Noise();

        // public override string ToString()
        // {
        //     return $"{Model}\n MRSP:${Mrsp}\n Vin:{Vin}\n Delivered:{DeliveryDate}\n Sold: {soldStatus}\n";
        //  }
        #endregion End of Methods
    }
}
