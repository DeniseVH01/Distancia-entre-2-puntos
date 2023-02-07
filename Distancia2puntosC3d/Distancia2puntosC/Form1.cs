using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia2puntosC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double X1, Y1,Z1, X2, Y2,Z2;
            X1 = Convert.ToDouble(TXTx1.Text);
           Y1 = Convert.ToDouble(TXTy1.Text);
           Z1 = Convert.ToDouble(TXTz1.Text);
            X2 = Convert.ToDouble(TXTx2.Text);
            Y2 = Convert.ToDouble(TXTy2.Text);
            Z2 = Convert.ToDouble(TXTz2.Text);
            PuntoXYZ PuntoA = new PuntoXYZ(X1,Y1,Z1 );
            PuntoXYZ PuntoB = new PuntoXYZ(X2,Y2,Z2);

            TXTresultado.Text= Math.Round(PuntoB.CalcularDistancia(PuntoA), 4).ToString();

        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXTx1.Clear();
            TXTy1.Clear();
            TXTz1.Clear();
            TXTx2.Clear();
            TXTy2.Clear();
            TXTz2.Clear();
            TXTresultado.Clear();

        }
    }
}
