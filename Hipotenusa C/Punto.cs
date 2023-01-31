using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenusa_C
{
    public class Punto
    {

        private double Xpunto1;
        private double Ypunto1;
        private double Xpunto2;
        private double Ypunto2;

        public double Xpropiedad1 { get => Xpunto1; set => Xpunto1 = value; }
        public double Ypropiedad1 { get => Ypunto1; set => Ypunto1 = value; }
        public double Xpropiedad2 { get => Xpunto2; set => Xpunto2 = value; }
        public double Ypropiedad2 { get => Ypunto2; set => Ypunto2 = value; }

        public void Puntos(double X1, double Y1, double X2, double Y2) {
            Xpunto1 = X1;
            Ypunto1 = Y1;
            Xpunto2 = X2;
            Ypunto2 = Y2;
   }


        public double Operacion (double X1, double Y1, double X2, double Y2) {
            double distancia;
            distancia = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)));
                return distancia;
         }
    }
}
