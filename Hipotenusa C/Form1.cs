using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hipotenusa_C
{
    public partial class Form1 : Form
    {
        Punto formulario = new Punto();

        public Form1()
        {
            InitializeComponent();
        }



        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        double X1, Y1, X2, Y2;
                        X1 = Convert.ToDouble(TXTx1.Text);
                        Y1 = Convert.ToDouble(TXTy1.Text);
                        X2 = Convert.ToDouble(TXTx2.Text);
                        Y2 = Convert.ToDouble(TXTy2.Text);


                        TXTresultado.Text = Convert.ToString(Math.Round(formulario.Operacion(X1, Y1, X2, Y2), 4));


                    }

                }
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXTx1.Clear();
            TXTy1.Clear();
            TXTx2.Clear();
            TXTy2.Clear();
            TXTresultado.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXTresultado.Enabled = false; 
        }
    }
}