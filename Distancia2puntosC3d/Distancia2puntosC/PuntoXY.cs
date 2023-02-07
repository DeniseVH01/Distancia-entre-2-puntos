using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia2puntosC
{
    class PuntoXY:Punto_X 
    {
        protected double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public PuntoXY():base()
        {
            y = 0;
        }
        public PuntoXY(double X, double Y):base (X)
        {
            this.y = Y;
        }

        public double  CalcularDistancia(PuntoXY a)
        {
            return Math.Sqrt(Math.Pow((x - a.X), 2) + Math.Pow((y - a.Y), 2));
        }

        public override string ToString()
        {
            return x + "," + y;
        }
    }
   
}
   
