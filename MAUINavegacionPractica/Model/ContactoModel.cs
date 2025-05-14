using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINavegacionPractica.Model
{
    public class ContactoModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }


        public ContactoModel()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Age = 0;
            Mail = string.Empty;            
        }

        public ContactoModel(string name, string surname, int age, string mail)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Mail = mail;            
        }

    }
}
