using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_SimpleClass
{
    public partial class FrmClass : Form
    {
        Person[] animals = new Person[5];
        int numOfAnimals;
        public FrmClass()
        {
            InitializeComponent();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            numOfAnimals = 0;
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            animals[numOfAnimals] = new Person
            {
                Name = TxtName.Text,
                Age = Convert.ToInt32(TxtAge.Text)
            };
            numOfAnimals += 1;
            TxtName.Text = "";
            TxtAge.Text = "";
            BtnDisplay.PerformClick();
            
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            LbxDisplay.Items.Clear();

            for (int i = 0; i < numOfAnimals; i++)
            {
                LbxDisplay.Items.Add(animals[i].Name + "    " + animals[i].Age);
            }
        }
    }
}

public class Person
{
    public string Name;
    public int Age;
}

