using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels {
    public class PersonViewModel : NotificationBase<Person> {
        public PersonViewModel(Person person = null) : base(person) { }
        public String Name
        {
            get { return This.Name; }
            set { SetProperty(This.Name, value, () => This.Name = value); }
        }
        public int Age
        {
            get { return This.Age; }
            set { SetProperty(This.Age, value, () => This.Age = value); }
        }
        public String Address
        {
            get { return This.Address; }
            set { SetProperty(This.Address, value, () => This.Address = value); }
        }
        public String PhoneNumber
        {
            get { return This.PhoneNumber; }
            set { SetProperty(This.PhoneNumber, value, () => This.PhoneNumber = value); }
        }
        public String EmailAddress
        {
            get { return This.EmailAddress; }
            set { SetProperty(This.EmailAddress, value, () => This.EmailAddress = value); }
        }
    }
}
