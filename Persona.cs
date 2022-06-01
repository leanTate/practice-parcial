using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace arbol_genealogico
{
    public class Persona
    {
        string name;
        string lastname;
        int age;
        string mother;
        string father;

        public Persona(string Name,string Lastname,int Age) {
            this.name = Name;
            this.lastname = Lastname;
            this.age = Age;
            this.mother = "m";
            this.father = "f";
            SavePersona(this.name,this.lastname,this.age,this.mother,this.father);
            MessageBox.Show($"se creo={this.name},{this.lastname}");
        }
        private void SavePersona(string Name, string Lastname, int Age,string mother,string father){
            FileStream FPersons = new FileStream("Persons.csv", FileMode.Append);
            StreamWriter Wsalida = new StreamWriter(FPersons);
            var register = Name+","+Lastname+","+Age.ToString()+","+mother+","+father;
            Wsalida.WriteLine(register);
            Wsalida.Close();
            FPersons.Close();
        }    
    }
}
