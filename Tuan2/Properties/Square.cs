using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
   public class Square
    {
        public double mSide;
    }
    public class Test
    {
        static void Main ()
        {
            Square obj = new Square();
            obj.mSide = 3;
        }
        private double mSide;
        public double Side
        {
            get { };
            set { };
        }
        public int Side
        {
            get
            {
                return mSide;
            }
            set
            {
                if (mSide < 0) return;
                mSide = value;
            }
        }
    }
}
