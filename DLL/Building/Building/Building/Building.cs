using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Building
    {
        private static int number;
        private int height;
        private int floors;
        private int apartments;
        private int entrance;

        public Building(int height, int floors, int apartments, int entrance)
        {
            number++;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrance = entrance;
        }
        public int GetNumber()
        {
            return number;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetFloors()
        {
            return floors;
        }
        public int GetApartments()
        {
            return apartments;
        }
        public int GetEntrance()
        {
            return entrance;
        }

        public double HeightOfFloors(int floors, int height)
        {
            return (double)height / floors;
        }
        public double ApartmentsInEntrance(int apartments, int entrance)
        {
            return (double)apartments / entrance;
        }
        public double ApartmentsOnTheFloor(int apartments, int floors)
        {
            return (double)(apartments / floors);
        }
        public string ShowInfo()
        {
            return $"Номер дом - {number}, высота - {height}, этажи - {floors}, квартиры - {apartments}, подъезды - {entrance}";
        }
    }
}
