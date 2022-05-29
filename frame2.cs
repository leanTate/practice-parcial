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
                listPersons.Add($"{name},{lastname},{age}");
                lista1.DataSource = null;
                lista1.DataSource = listPersons;
            }
        }
        public void UpdateMother(string Mother) {

            MessageBox.Show("se actualizo la madre");
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
