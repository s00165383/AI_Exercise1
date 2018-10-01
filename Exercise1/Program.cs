using System;
using System.Collections.Generic;

namespace Exercise1
{
    public enum Gender { Male, Female }

    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<Person> Parents { get; set; }
        public virtual ICollection<Person> Children { get; set; }
        public Person(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;         
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var Paul = new Person("Paul",Gender.Male);
            var Fred = new Person("Fred", Gender.Male);
            var Bill = new Person("Bill", Gender.Male);
            var Mary = new Person("Mary", Gender.Female);
            var Victoria = new Person("Victoria", Gender.Female);
            var Jemima = new Person("Jemima", Gender.Female);
            Console.WriteLine(Paul.Name);
            Paul.Children.Add(Fred);
            Fred.Parents.Add(Paul);
            Paul.Children.Add(Jemima);
            Jemima.Parents.Add(Paul);
            Mary.Children.Add(Fred);
            Fred.Parents.Add(Mary);
            Paul.Children.Add(Mary);
            Mary.Parents.Add(Paul);


        }
    }
}
