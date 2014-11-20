using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationInClass4
{
    class Chair
    {
        public int Height;
        public int NumLegs;
        public bool HasBack;
        public bool HeightAjustable;

        public void RaiseHeight()
        {
            this.Height++;
        }

        public void LowerHeight()
        {
            this.Height--;
        }
    }
}
