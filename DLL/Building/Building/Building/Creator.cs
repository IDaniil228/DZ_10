using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    public class Creator
    {
        public static Hashtable builds = new Hashtable(9999);

        private Creator() { }
        public static void CreateBuild(int height, int floors, int apartments, int entrance)
        {
            Building building = new Building(height, floors, apartments, entrance);
            builds.Add(building.GetNumber(), building);
        }
        public static void CreateBuild()
        {
            Building building = new Building(5, 5, 5, 5);
            builds.Add(building.GetNumber(), building);
        }
        public static void showBuild()
        {
            for (int i = 0; i < builds.Count; i++)
            {
                if (builds.ContainsKey(i))
                {
                    Building b = builds[i] as Building;
                    Console.WriteLine(b.ShowInfo());
                }
            }
        }
         public void DeleteBuilding(int numb)
        { 
            builds.Remove(numb);
        }

    }
}
