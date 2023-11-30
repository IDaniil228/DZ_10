using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = new StreamReader("Students.txt");
            while (!reader.EndOfStream)
            {
                string s = reader.ReadLine();
                string[] param = s.Split();
                Student student = new Student(param[0], Convert.ToInt32(param[1]));
                students.Add(student);
            }
            Event event_1 = new Event("title_1", new DateTime(2024, 01, 01), 2);
            students[0].TakePlace(event_1);
            students[3].TakePlace(event_1);
            event_1.SetStudents(students);
            event_1.RecordToFile();
            Event event_2 = new Event("title_2", new DateTime(2024, 09, 12), 1);
            event_2.SetStudents(students);
            event_2.RecordToFile();
            Event event_3 = new Event("title_3", new DateTime(2024, 05, 19), 3);
            event_3.SetStudents(students);
            event_3.RecordToFile();
            Event event_4 = new Event("title_4", new DateTime(2024, 01, 20), 4);
            event_4.SetStudents(students);
            event_4.RecordToFile();
            Event event_5 = new Event("title_5", new DateTime(2024, 03, 12), 1, 2);
            students[2].TakePlace(event_5);
            students[6].TakePlace(event_5);
            event_5.SetStudents(students);
            event_5.RecordToFile();
            Event event_6 = new Event("title_5", new DateTime(2024, 03, 12), 2, 2);
            event_6.SetStudents(students);
            event_6.RecordToFile();

            List<Person> people = new List<Person>();
            Person person_1 = new Person("Ваня", Hobbies.баскетбол);
            Person person_2 = new Person("Петя", Hobbies.футбол);
            Person person_3 = new Person("Маша", Hobbies.хоккей);
            people.Add(person_1);
            people.Add(person_2);
            people.Add(person_3);
            person_1.even += Reaction;
            person_2.even += Reaction;
            person_3.even += Reaction;
            Activity activity_1 = new Activity("Матч по футболу", Hobbies.футбол);
            activity_1.Happen(people);
            Activity activity_2 = new Activity("Матч по баскетболу", Hobbies.баскетбол);
            activity_2.Happen(people);
            Activity activity_3 = new Activity("Матч по хоккею", Hobbies.хоккей);
            activity_3.Happen(people);
            Console.ReadKey();

            
            void Reaction(object a, EventArgs w)
            {
                Person person = a as Person;
                if (person != null)
                {
                    if (person.Hobby == Hobbies.баскетбол)
                    {
                        Console.WriteLine($"{person.Name} пойдет смотреть баскетбол");
                    }
                    else if (person.Hobby == Hobbies.футбол)
                    {
                        Console.WriteLine($"{person.Name} пойдет смотреть футбол");
                    }
                    else if (person.Hobby == Hobbies.хоккей)
                    {
                        Console.WriteLine($"{person.Name} пойдет смотреть хоккей");
                    }
                }
            }


        }
    }
}
