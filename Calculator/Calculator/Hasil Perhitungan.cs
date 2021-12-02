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
   
    public partial class Hasil_Perhitungan : Form
    {
        private List<Kalkulator> listDariHasil = new List<Kalkulator>();
        public Hasil_Perhitungan()
        {
            InitializeComponent();
            initialisasilsv();
        }
        private void initialisasilsv()
        {
            lsv.View = View.Details;

            lsv.Columns.Add("", 10, HorizontalAlignment.Left);
            lsv.Columns.Add("", 200, HorizontalAlignment.Left);
        }
        private void Frmcalc_OnCalculated(Kalkulator calcu)
        {
            listDariHasil.Add(calcu);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(calcu.Hasilnya);

            lsv.Items.Add(item);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
                OperasiCalculator Hasil_Perhitungan = new OperasiCalculator ("Calculator");
                Hasil_Perhitungan.OnCalc += Frmcalc_OnCalculated;
                Hasil_Perhitungan.ShowDialog();
            
        }
    }
}
