using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Helicopter : AerialVehicle
    {
        public int NumRotors;
        public bool HasTailRotor;

        public Helicopter() : this(2, true)
        {
            
        }

        public Helicopter(int NumberOfRotors, bool HasTailRotor )
        {
            this.MaxAltitude = 8000;
            this.NumRotors = NumberOfRotors;
            this.HasTailRotor = HasTailRotor;
        }

        public override string About()
        {
            return base.About() + $" {this.NumRotors} : rotors and {this.HasTailTRotorString()}.";
        }

        private string HasTailTRotorString()
        {
            if (this.HasTailRotor)
                return "has tail rotor";
            return "has no tail rotor";

        }
    }
}
