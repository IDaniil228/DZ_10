using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_1_
{
    public enum Hobbies { футбол, баскетбол, хоккей } 
    internal class Person
    {
        private string name;
        private Hobbies hobby;
        public event EventHandler even;
        public Person(string name, Hobbies hobby)
        {
            this.name = name;
            this.hobby = hobby;
        }
        public string Name
        {
            get { return name; }
        }
        public Hobbies Hobby
        {
            get { return hobby; }
        }
        /// <summary>
        /// Реакция на событие
        /// </summary>
        public void reactionToEvent()
        {
            if (even != null)
            {
                even(this, new EventArgs());
            }
        }
    }
}
