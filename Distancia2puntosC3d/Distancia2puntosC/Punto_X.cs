using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia2puntosC
{
    class Punto_X
    {
        protected double  x;
        public double X
        {
            get{ return x; }
            set { x = value; }
        }

        public Punto_X()
        {
            x = 0;
            
        }
        public Punto_X(double X)
        {
            this.x  = X;
          
        }

     

            public double CalcularDistancia(Punto_X a)
         {
           return Math.Abs(x - a.X);
       }
        public override string ToString()
        {
        return x + " ";
        }
        }
    }





