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

        public void LoadCSV() {
            FileStream FPersons = new FileStream("Persons.csv", FileMode.Open, FileAccess.Read);
            StreamReader SRPersons = new StreamReader(FPersons);
            string line = "";
            while ((line = SRPersons.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                string name = fields[0];
                string lastname = fields[1];
                string age = fields[2];
                string mother = fields[3];
                //MessageBox.Show($"se agrego:{name},{lastname},{age}");
                listPersons.Add($"{name};{lastname};{age};{mother}");
                lista1.DataSource = null;
                lista1.DataSource = listPersons;
            }
            FPersons.Close();
            SRPersons.Close();
        }
        public frame2()
        {
            InitializeComponent();
            LoadCSV();
        }
        public void UpdateMother(string mother) {
            string selectedItem = lista1.Items[lista1.SelectedIndex].ToString();//recordar slecciona el item
            string[] fields = selectedItem.Split(';');
            string name = fields[0];
            string lastname = fields[1];
            string changes;
            string[] arrayChanges;
            FileStream FS = new FileStream("Persons.csv", FileMode.Open,FileAccess.Read);
            FileStream FSCopy = new FileStream("SalidaCopy.csv", FileMode.Create);
            StreamReader SR = new StreamReader(FS);
            StreamWriter SW = new StreamWriter(FSCopy);
            while ((changes = SR.ReadLine())!=null)
            {
                arrayChanges = changes.Split(',');
                mother = TxtMadre.Text;
                if (name == arrayChanges[0])
                {
                    changes = $"{arrayChanges[0]},{arrayChanges[1]},{arrayChanges[2]},{TxtMadre.Text},{arrayChanges[4]}";
                }

                MessageBox.Show(changes);
                SW.WriteLine(changes);
            }
            SR.Close();
            SW.Close();
            FS.Close();
            FSCopy.Close();
            File.Delete("Persons.csv");
            File.Move("SalidaCopy.csv", "Persons.csv");
            MessageBox.Show("se actualizo la madre");
            lista1.DataSource = null;
            listPersons.Clear();
            LoadCSV();
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
