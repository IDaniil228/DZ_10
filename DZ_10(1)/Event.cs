using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_10_1_
{
    internal class Event
    {
        private string title;
        private DateTime date;
        private int numbOfStudent;
        private int group;
        List<Student> stud = new List<Student>();

        public Event(string title, DateTime date, int numb)
        {
            this.title = title;
            this.date = date;
            numbOfStudent = numb;
        }
        public Event(string title, DateTime date, int group, int numb)
        {
            this.group = group;
            this.title = title;
            this.date = date;
            numbOfStudent = numb;
        }
        public int Group
        {
            get { return group; }
        }
        public int NumbOfStudent
        {
            get { return numbOfStudent; }
        }
        public List<Student> Stud
        {
            get { return  stud; }
        }
        /// <summary>
        /// Выбирает студентов для мероприятия
        /// </summary>
        /// <param name="a"></param>
        public void SetStudents(List<Student> a)
        {
            if (group == 0)
            {
                foreach (Student student in a)
                {
                    if (stud.Count == numbOfStudent)
                    {
                        break;
                    }
                    if (student.Counter == 3)
                    {
                        stud.Add(student);
                        student.Counter = 0;
                    }
                }
                if (stud.Count == numbOfStudent)
                {
                    return;
                }
                else
                {
                    Random rnd = new Random();
                    Thread.Sleep(50);
                    while (stud.Count != numbOfStudent)
                    {
                        Student student = a[rnd.Next(a.Count)];
                        if (!stud.Contains(student))
                        {
                            stud.Add(student);
                            student.Counter = 0;
                        }
                    }
                }
            }
            else 
            {
                foreach (Student student in a)
                {
                    if (stud.Count == numbOfStudent)
                    {
                        break;
                    }
                    if (student.Counter == 3 && student.Group == group)
                    {
                        stud.Add(student);
                        student.Counter = 0;
                    }
                }
                if (stud.Count == numbOfStudent)
                {
                    return;
                }
                else
                {
                    Random rnd = new Random();
                    Thread.Sleep(50);
                    while (stud.Count != numbOfStudent)
                    {
                        Student student = a[rnd.Next(a.Count)];
                        if (!stud.Contains(student) && student.Group == group)
                        {
                            stud.Add(student);
                            student.Counter = 0;
                        }
                    }
                }
            }
            
            
        }
        /// <summary>
        /// Показывает студентов
        /// </summary>
        public void ShowStud()
        {
            foreach (Student a in stud)
            {
                Console.WriteLine($"{a.Name},{a.Group}");
            }
        }
        /// <summary>
        /// Записывает в файл
        /// </summary>
        public void RecordToFile()
        {
            using (StreamWriter writer = new StreamWriter("Events.txt", true))
            {
                writer.Write($"{date.ToShortDateString()}; ");
                writer.Write($"{title}; ");
                foreach (Student a in stud)
                {
                    writer.Write($"{a.Name}-{a.Group} ");
                }
                writer.WriteLine();
            }
        }

    }
}
