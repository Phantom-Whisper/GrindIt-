using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindIt.NutritionLib
{
    public class Cup
    {
        public Cup(int value)
        {
            CupSize = value;
        }
        private int cupSize;
        
        public int CupSize
        {
            get
            {
                return cupSize;
            }
            set
            {
                cupSize = value;
            }
        }
    }
}
