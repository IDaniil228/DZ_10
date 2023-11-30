using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_1_
{
    internal class Activity
    {
        string title;
        Hobbies typeOfHobbies;
        public Activity(string title, Hobbies typeOfHobbies)
        {
            this.title = title;
            this.typeOfHobbies = typeOfHobbies;
        }
        /// <summary>
        /// Начинает мероприятие
        /// </summary>
        /// <param name="a"></param>
        public void Happen(List<Person> a)
        {
            foreach (Person person in a) 
            {
                if (person.Hobby == typeOfHobbies)
                {
                    person.reactionToEvent();
                }
            }
        }
    }
}
