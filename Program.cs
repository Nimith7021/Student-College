using InheritancePerson.Models;

namespace InheritancePerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Sunshine Street", new DateTime(1998,3,17,10,10,0));
            Student student = new Student
                (100, "Solitude Avenue",new DateTime(2002,12,12,12,30,41), "Electronics");
            Professor professor = new Professor(1000, "John Park Hills"
                ,new DateTime(1979,5,25,9,40,55), 45000.500);

            PrintPersonDetails(person);
            PrintPersonDetails(student);
            PrintPersonDetails(professor);

            static void PrintPersonDetails(Person person)
            {
                Console.WriteLine($"==============Role : {person.GetType().Name}==============");
                Console.WriteLine(person.PrintDetails());
            }
        }
    }
}
