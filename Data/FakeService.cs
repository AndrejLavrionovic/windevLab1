using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data {
    public class Person {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }
    }

    public class FakeService {
        public static String Name = "Fake Data Service.";

        public static List<Person> GetPeople() {
            Debug.WriteLine("GET for people.");
            return new List<Person>()
                {
                    new Person() { Name="Chris Cole", Age=10, Address="186 Papazoglo Str.", PhoneNumber="0863011481", EmailAddress="chris.cole@gmail.com" },
                    new Person() { Name="Kelly Kale", Age=32, Address="156 Paprazoglo Str.", PhoneNumber="0863011482", EmailAddress="kelly.kale@gmail.com" },
                    new Person() { Name="Dylan Durbin", Age=18, Address="8 Mamazoglo Str.", PhoneNumber="0863011441", EmailAddress="dylan.durban@gmail.com" }
                };
        }

        public static void Write(Person person) {
            Debug.WriteLine("INSERT person with name " + person.Name);
        }

        public static void Delete(Person person) {
            Debug.WriteLine("DELETE person with name " + person.Name);
        }
    }
}
