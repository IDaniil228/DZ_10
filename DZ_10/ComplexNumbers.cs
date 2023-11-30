using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10
{
    internal class ComplexNumbers
    {
        private int Re { get; set; }
        private int Im { get; set; }

        public ComplexNumbers(int Re, int Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b) 
        {
            int temp = a.Re + b.Re;
            int temp_1 = a.Im + b.Im;
            return new ComplexNumbers(temp, temp_1);
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            int temp = a.Re - b.Re;
            int temp_1 = a.Im - b.Im;
            return new ComplexNumbers(temp, temp_1);
        }

        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            int temp = a.Re * b.Re - a.Im * b.Im;
            int temp_1 = a.Im * b.Re + a.Re * b.Im;
            return new ComplexNumbers(temp, temp_1);
        }

        public static bool operator ==(ComplexNumbers a, ComplexNumbers b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(ComplexNumbers a, ComplexNumbers b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexNumbers numb)
            {
                if (Re == numb.Re && Im == numb.Im)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override string ToString()
        {
            if (Im >= 0)
            {
                return $"{Re} + {Im}i";
            }
            else 
            {
                return $"{Re} - {Im * -1}i";
            }
        }


    }
}
