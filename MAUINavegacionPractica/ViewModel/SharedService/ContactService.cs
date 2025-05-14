using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MAUINavegacionPractica.Model;
using System.Threading.Tasks;

namespace MAUINavegacionPractica.ViewModel.SharedService
{
    public class ContactService
    {

        public ObservableCollection<ContactoModel> Contactos { get; } = new();

        public void AddContact(ContactoModel contact)
        {
            Contactos.Add(contact);
        }

    }
}
