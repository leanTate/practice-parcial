using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol_genealogico
{
    public partial class frame2 : Form
    {
        List<string> listPersons = new List<string>();
        public frame2()
        {
            InitializeComponent();
            FileStream FPersons = new FileStream("Persons.csv", FileMode.Open, FileAccess.Read);
            StreamReader SRPersons = new StreamReader(FPersons);
            string line = "";
            while ((line = SRPersons.ReadLine()) != null){
                string[] fields = line.Split(';');
                string name = fields[0];
                string lastname = fields[1];
                string age = fields[2];
                //MessageBox.Show($"se agrego:{name},{lastname},{age}");
                listPersons.Add($"{name};{lastname};{age}");
                lista1.DataSource = null;
                lista1.DataSource = listPersons;
            }
            FPersons.Close();
            SRPersons.Close();
        }
        public void UpdateMother(string mother) {
            string selectedItem = lista1.Items[lista1.SelectedIndex].ToString();//recordar slecciona el item
            string[] fields = selectedItem.Split(',');
            string name = fields[0];
            string lastname = fields[1];

            FileStream FPersons = new FileStream("Persons.csv", FileMode.Open,FileAccess.ReadWrite);
            StreamReader SRPersons = new StreamReader(FPersons);
            StreamWriter SWPersons = new StreamWriter(FPersons);    
            int i=0;
            string line;
            while ((line = SRPersons.ReadLine()) != null) {
                i++;
                string[] fields2 = line.Split(';');
                string nameList = fields2[0];
                string lastnameList = fields2[1];
                string ageList = fields2[2];
                if (name == nameList && lastname == lastnameList) {
                    line = fields2[0] + ";" + fields2[1] +";"+ fields2[2] +";" +mother;
                    
                    File.WriteAllLines("Personas.csv", listPersons);
                    File.Delete("Persons.csv");
                    File.Move("Personas.csv","Persons.csv");
                    
                }
            }
                MessageBox.Show("se actualizo la madre");
                SWPersons.Close();
                FPersons.Close();
                SRPersons.Close();
        }
        public void UpdateFather(string Father)
        {

            MessageBox.Show("se actualizo el padre");
        }        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMother(TxtMadre.Text);
            UpdateFather(txtPadre.Text);
        }
    }
}
