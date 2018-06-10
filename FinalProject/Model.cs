using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public delegate void TabbyAddedEventHander(Tabby newTabby);
    public delegate void SiameseAddedEventHander(Siamese newSiamese);
    public delegate void HuskyAddedEventHander(Husky newHuskyy);
    public delegate void ChiwawaAddedEventHander(Chiwawa newChiwawa);


    public class Model
    {
        //tabby list
        public event TabbyAddedEventHander TabbyAdded;

        public List<Tabby> TabbyList = new List<Tabby>();



        public void AddTabbyInList(Tabby tabby)
        {
            TabbyList.Add(tabby);

            if (TabbyAdded != null)
                TabbyAdded(tabby);
            Console.WriteLine("Tabby added!");
        }

        //siamese list
        public event SiameseAddedEventHander SiameseAdded;

        public List<Siamese> SiameseList = new List<Siamese>();
        public void AddSiameseInList(Siamese siamese)
        {
            SiameseList.Add(siamese);

            if (SiameseAdded != null)
                SiameseAdded(siamese);
            Console.WriteLine("siamese added!");
        }


        //Husky list
        public event HuskyAddedEventHander HuskyAdded;

        public List<Husky> HuskyList = new List<Husky>();
        public void AddHuskyInList(Husky husky)
        {
            HuskyList.Add(husky);

            if (HuskyAdded != null)
                HuskyAdded(husky);
            Console.WriteLine("Husky added!");
        }


        //chiwawa list
        public event ChiwawaAddedEventHander ChiwawaAdded;

        public List<Chiwawa> ChiwawaList = new List<Chiwawa>();
        public void AddChiwawaInList(Chiwawa chiwawa)
        {
            ChiwawaList.Add(chiwawa);

            if (ChiwawaAdded != null)
                ChiwawaAdded(chiwawa);
            Console.WriteLine("Chiwawa added!");
        }


        public void defaultPets()
        {
            Tabby tabby = new Tabby("sunshine", 22222222222222222, new DateTime(2016, 2, 24), false);
            AddTabbyInList(tabby);
            Tabby tabby2 = new Tabby("Dolly", 22222222222222222, new DateTime(2016, 2, 24), false);
            AddTabbyInList(tabby2);

            Chiwawa chiwawa = new Chiwawa("tony", 33333333333333333, new DateTime(2016, 2, 24), false);
            AddChiwawaInList(chiwawa);

            Siamese siamese = new Siamese("felix", 44444444444444444, new DateTime(2016, 3, 11), false);
            AddSiameseInList(siamese);

            Husky husky = new Husky("fluffs", 55555555555555555, new DateTime(2016, 2, 24), false);
            AddHuskyInList(husky);

        }

    }


    }
