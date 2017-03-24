using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVVM.Models;

namespace SimpleMVVM.ModelViews
{
    internal class DisplayPersonPageViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }

        public DisplayPersonPageViewModel(Person person)
        {
            Name = person.Name;
            Phone = person.Phone;
            Email = person.Email;
            Gender = person.Gender;
        }

        #region Mock Web Service Api

        public static Person FetchPerson()
        {
            var person = new Person
            {
                Name = "Devlin Duldulao",
                Phone = "0997 0921 675",
                Email = "devlin@xamarinforms.com",
                Hometown = "Q.C.",
                Gender = true
            };

            return person;
        }

        #endregion Mock Web Service Api

        #region Method_Style_With_Overloading

        //        public void DisplayPerson(string name)
        //        {
        //            Name = name;
        //        }
        //        public void DisplayPerson(string name, string phone)
        //        {
        //            Name = name;
        //            Phone = phone;
        //        }
        //        public void DisplayPerson(string name, string phone, string email)
        //        {
        //            Name = name;
        //            Phone = phone;
        //            Email = email;
        //        }

        #endregion Method_Style

        #region Constructor_Style_With_Overloading

        //        public DisplayPersonPageViewModel(string name)
        //        {
        //            Name = name;
        //        }
        //        public DisplayPersonPageViewModel(string name, string phone)
        //        {
        //            Name = name;
        //            Phone = phone;
        //        }
        //        public DisplayPersonPageViewModel(string name, string phone, string email)
        //        {
        //            Name = name;
        //            Phone = phone;
        //            Email = email;

        #endregion Constructor_Style
    }
}