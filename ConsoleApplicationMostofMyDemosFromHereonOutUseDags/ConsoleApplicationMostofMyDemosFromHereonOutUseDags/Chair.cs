using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funrature
{
    public class Chair
    {
        public int Height;
        public int NumLegs;
        public bool HasBack;
        public bool HeightAdjustable;

        public Chair()
        {
            this.NumLegs = 3;
            this.Height = 1;
        }
        /// <summary>
        /// Raise the seat
        /// </summary>
        public void RaiseHeight()
        {
            if (HeightAdjustable)
            {
                this.Height = this.Height +2;
            }
        }
        /// <summary>
        /// raise the seat by certian number of tiomes
        /// </summary>
        /// <param name="RaiseAmount">number of times to raise the seat</param>
        public void RaiseHeight(int RaiseAmount)
        {
            if (HeightAdjustable)
            {
                for (int i = 0; i < RaiseAmount; i++)
                {
                    this.RaiseHeight();
                }
            }
        }

        public void LowerHeight()
        {
            if (HeightAdjustable & this.Height > 1)
            {
                this.Height--;
            }
        }

        public string About()
        {
            string about = string.Format("Hello I'm a {0} I have {1} legs im {2} tall",
                this, this.NumLegs, this.Height);
            return about;
        }
    }
}
