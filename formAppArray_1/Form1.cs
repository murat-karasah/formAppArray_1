using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formAppArray_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Pull_Click(object sender, EventArgs e)
        {
            cmb1.Items.Clear();
            listbx1.Items.Clear();

            string[] gunler = { "Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};
            string[] aylar = { "Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};
            foreach (string gun in gunler) {
                cmb1.Items.Add(gun);
            }

            listbx1.Items.AddRange(aylar);
            foreach (Control ctr in Controls)
            {
                ctr.BackColor = Color.CornflowerBlue;
                ctr.ForeColor = Color.White;
            }
        }

    }
}
