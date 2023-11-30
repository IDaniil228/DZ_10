using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_1_
{
    internal class Student
    {
        string name;
        int group;
        int counter = 0;

        public Student(string name, int group) 
        {
            this.name = name;
            this.group = group;
        }
        public string Name
        {
            get { return name; }
        }
        public int Group
        {
            get { return group; }
        }
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        /// <summary>
        /// Занимает место на мероприятие 
        /// </summary>
        /// <param name="e"></param>
        public void TakePlace(Event e)
        {
            if (e.Stud.Count < e.NumbOfStudent - 1 && (e.Group == 0 || e.Group == group))
            {
                e.Stud.Add(this);
            }
        }

    }
}
