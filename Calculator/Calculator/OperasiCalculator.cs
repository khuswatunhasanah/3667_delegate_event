using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class OperasiCalculator : Form
    {
        public delegate void EventHandler(Kalkulator calcu);
        public event EventHandler OnCalc;

        private Kalkulator calcu;
        public OperasiCalculator()
        {
            InitializeComponent();
        }
        public OperasiCalculator (string title) : this()
        {
            this.Text = title;
        }

        private void OperasiCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calcu = new Kalkulator();
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);


            if (cb.Text == "Penjumlahan")
                calcu.Hasilnya = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);

            if (cb.Text == "Pengurangan")
                calcu.Hasilnya = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);

            if (cb.Text == "Perkalian")
                calcu.Hasilnya = string.Format("Hasil Perkalian {0} x {1} = {2}", a, b, a * b);

            if (cb.Text == "Pembagian")
                calcu.Hasilnya = string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, a / b);




            OnCalc(calcu);
            tb1.Clear();
            tb2.Clear();
            tb1.Focus();
            
        }
    }
}
