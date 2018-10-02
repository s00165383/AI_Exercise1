using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Person Paul = new Person("Paul",Gender.Male);
            Person Fred = new Person("Fred", Gender.Male);
            Person Bill = new Person("Bill", Gender.Male);
            Person Mary = new Person("Mary", Gender.Female);
            Person Victoria = new Person("Victoria", Gender.Female);
            Person Jemima = new Person("Jemima", Gender.Female);
            //Console.WriteLine(Paul.Name);
            Paul.Children.Add(Fred);
            Fred.Parents.Add(Paul);
            Paul.Children.Add(Jemima);
            Jemima.Parents.Add(Paul);
            Mary.Children.Add(Fred);
            Fred.Parents.Add(Mary);
            Paul.Children.Add(Mary);
            Mary.Parents.Add(Paul);


            foreach (Person person in Fred.Parents.ToList())
            {
                Console.WriteLine("{0} is Fred's Parent",person.Name);
            }



        }
    }
}
