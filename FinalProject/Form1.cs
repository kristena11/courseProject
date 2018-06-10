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
    public partial class Form1 : Form
    {

        private Model m_modelObj;
        public Form1(Model modelObj)
        {
            
            InitializeComponent();

            m_modelObj = modelObj;


            List<Tabby> tabbyList = m_modelObj.TabbyList;
            
            List<Siamese> siameseList = m_modelObj.SiameseList;
            
            List<Husky> huskyList = m_modelObj.HuskyList;
            
            List<Chiwawa> chiwawaList = m_modelObj.ChiwawaList;



            //tree code

            //add husky list
            List<TreeNode> node8 = new List<TreeNode>();
            foreach (var item in huskyList)
            {
                node8.Add(new TreeNode(item.name));
            }

            TreeNode[] husky = node8.ToArray();

            //add chiwawa list
            List<TreeNode> node9 = new List<TreeNode>();
            foreach (var item in chiwawaList)
            {
                node9.Add(new TreeNode(item.name));
            }

            TreeNode[] chiwawa = node9.ToArray();

            //dog breed
            TreeNode node2 = new TreeNode("Husky", husky);
            TreeNode node3 = new TreeNode("Chiwawa", chiwawa);
            TreeNode[] dog = new TreeNode[] { node2, node3 };

            //dog parent
            TreeNode treeNode = new TreeNode("Dogs", dog);
            treeView1.Nodes.Add(treeNode);

            //add tabby list
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (var item in tabbyList)
            {
                nodes.Add(new TreeNode(item.name));
            }

            TreeNode[] tabby = nodes.ToArray();

            //add siamese list
            List<TreeNode> node7 = new List<TreeNode>();
            foreach (var item in siameseList)
            {
                node7.Add(new TreeNode(item.name));
            }

            TreeNode[] siamese = node7.ToArray();

            //cat breed
            TreeNode node4 = new TreeNode("Siamese", siamese);
            TreeNode node5 = new TreeNode("Tabby", tabby);
            TreeNode[] cat = new TreeNode[] { node4, node5 };

            //cat parent
            treeNode = new TreeNode("Cats", cat);
            treeView1.Nodes.Add(treeNode);


           

        }



       
        private void Form1_Load(object sender, EventArgs e)
        {
                       

            //petCount.Text = "Pets Available : " + Pet.petCount;
            
        }

        private Image ImageUrl(object p)
        {
            throw new NotImplementedException();
        }

        private void petList_Click(object sender, EventArgs e)
        {
            
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void petSelectBtn_Click(object sender, EventArgs e)
        {
           /* foreach (Object obj in listBox1.SelectedItems)
            {

                PetInfoForm aPetInfoForm = new PetInfoForm(obj);
                aPetInfoForm.Closed += (s, args) => this.Close();
                aPetInfoForm.Show();
            }*/

        }

        private void addDetailsBtn_Click(object sender, EventArgs e)
        {
            string animalType = comboBoxAnimalType.SelectedItem.ToString();
            this.Hide();
            PetInfoForm aPetInfoForm = new PetInfoForm(animalType, m_modelObj);
            aPetInfoForm.Closed += (s, args) => this.Close();
            aPetInfoForm.Show();
           
            
            
        }

        public void treeView1_NodeMouseClick(object sender, TreeViewEventArgs e)
        {
            TreeNode clickedNode = e.Node;
            AnimalSelectLabel.Text = clickedNode.ToString();
            //AdoptForm aAdoptForm  = new AdoptForm(name, m_modelObj);

            //aAdoptForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Report aReport = new Report(m_modelObj);

            aReport.Show();

        }
    }
}
