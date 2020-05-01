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
        Person[] animals = new Person[1];
        int numOfAnimals;
        public FrmClass()
        {
            InitializeComponent();
        }

        private void FrmClass_Load(object sender, EventArgs e)
        {
            numOfAnimals = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            animals[numOfAnimals] = new Person(TxtName.Text, Convert.ToInt32(TxtAge.Text));
            numOfAnimals += 1;
            TxtName.Text = "";
            TxtAge.Text = "";
            BtnDisplay.PerformClick();
            Array.Resize(ref animals, numOfAnimals + 1);
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
    private string name;
    private int age;
    private string city;

 
    public string Name 
    {
        get { return name; }
        set {name = value.ToUpper(); }
    }

    public int Age 
    {
        get { return age; }
        set { age = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value.ToUpper(); }
    }

    public Person(string aName, int aAge)
    {
        Name = aName.ToUpper();
        Age = aAge;
    }


}
