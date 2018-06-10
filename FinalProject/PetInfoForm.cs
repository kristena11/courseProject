using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PetInfoForm : Form
    {
        Model m_model;
        public PetInfoForm(string animalType, Model modelObj)
        {
            
            InitializeComponent();
            m_model = modelObj;
            breedLable.Text = animalType;
            string cat = "Cat";
            animalTypeLable.Text = animalType;

            if (animalType.Contains(cat))
            {
                List<string> cats = new List<string>();
                cats.Add("Tabby");
                cats.Add("Siamese");
                comboBoxBreedSelection.DataSource = cats;

            }
            else
            {
                List<string> dog = new List<string>();
                dog.Add("Husky");
                dog.Add("Chiwawa");
                comboBoxBreedSelection.DataSource = dog;
            }
        }

        private void PetInfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addAnimalToList_Click(object sender, EventArgs e)
        {
            string breed = comboBoxBreedSelection.SelectedItem.ToString();
            DateTime arrivalDate = ArrivalDateTime.Value;
            string name = nameTextBox.Text;
            string c = chipTextBox.Text;
            long chip = Convert.ToInt64(c);
            Boolean adoptedStatus = false;
            string tabby = "Tabby";
            string siamese = "Siamese";
            string husky = "Husky";
            

            if (breed.Contains(tabby))
            {
                Console.WriteLine(" tabby  ");
                Tabby newTabby = new Tabby(name, chip, arrivalDate, adoptedStatus);
                m_model.AddTabbyInList(newTabby);
                this.Hide();
                Form1 aForm1 = new Form1(m_model);
                aForm1.Closed += (s, args) => this.Close();
                aForm1.Show();
            }
            else if (breed.Contains(siamese))
            {
                Console.WriteLine(" siamese  ");
                Siamese newSiamese = new Siamese(name, chip, arrivalDate, adoptedStatus);
                m_model.AddSiameseInList(newSiamese);
                this.Hide();
                Form1 aForm1 = new Form1(m_model);
                aForm1.Closed += (s, args) => this.Close();
                aForm1.Show();
            }
            else if (breed.Contains(husky))
            {
                Console.WriteLine(" husky  ");
                Husky newHusky = new Husky(name, chip, arrivalDate, adoptedStatus);
                m_model.AddHuskyInList(newHusky);
                this.Hide();
                Form1 aForm1 = new Form1(m_model);
                aForm1.Closed += (s, args) => this.Close();
                aForm1.Show();
            }
            else
            {
                Console.WriteLine(" chiwawa  ");
                Chiwawa newChiwawa = new Chiwawa(name, chip, arrivalDate, adoptedStatus);
                m_model.AddChiwawaInList(newChiwawa);
                this.Hide();
                Form1 aForm1 = new Form1(m_model);
                aForm1.Closed += (s, args) => this.Close();
                aForm1.Show();
            }
            
        }
    }
}
