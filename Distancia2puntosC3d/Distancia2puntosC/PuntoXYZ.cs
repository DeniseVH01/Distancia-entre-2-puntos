using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia2puntosC
{
    class PuntoXYZ:PuntoXY 
    {
        protected double z;
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public PuntoXYZ() : base()
        {
            z = 0;
        }
        public PuntoXYZ(double X, double Y,double Z) : base(X,Y)
        {
            this.z = Z;
        }

        public double CalcularDistancia(PuntoXYZ a)
        {
            return Math.Sqrt(Math.Pow((x - a.X), 2) + Math.Pow((y - a.Y), 2) + Math.Pow((z - a.Z), 2));
        }
        

        public override string ToString()
        {
            return x + " ," + y +" , "+z;
        }
    }
}
