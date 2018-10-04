using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterVerbruik
{
    public partial class Form1 : Form
    {
        //
        //Vars
        //
        
        
        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //

        private double Tarief00(double In)
        {
            if (Tarief01(In) < Tarief02(In)) return Tarief01(In);
            else return Tarief02(In);
        }
        private double Tarief01(double In)
        {
            double betaal = 100 + (In * 0.25);
            return betaal;
        }
        private double Tarief02(double In)
        {
            double betaal = 75 + (In * 0.38);
            return betaal;
        }

        private void Betaal()
        {
            if (rdb00.Checked) lblOut.Text = "Te betalen bedrag: €" + Tarief00(double.Parse(txbIn.Text));
            if (rdb01.Checked) lblOut.Text = "Te betalen bedrag: €" + Tarief01(double.Parse(txbIn.Text));
            if (rdb02.Checked) lblOut.Text = "Te betalen bedrag: €" + Tarief02(double.Parse(txbIn.Text));
        }

        //
        //Events
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Betaal();
        }

    }
}
