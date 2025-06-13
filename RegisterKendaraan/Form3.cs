using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKPL;
using static System.Windows.Forms.DataFormats;

namespace RegisterKendaraan
{
    public partial class Form3 : Form

    {
        private int idx;
        private Form2 form2;
        public Form3(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();

        }

        public void GetDataKendaraan(int index)
        {
            idx = index;
            List<ACuciKendaraan> ListKendaraan = Form1.GetList();
            label1.Text = ListKendaraan[index].GetNamaKendaraan();
            label4.Text = ListKendaraan[index].GetJenisKendaraan();
            label7.Text = ListKendaraan[index].GetState().ToString();
            
        }

        public void UbahSateKendaraan(int index) { 
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ACuciKendaraan> ListKendaraan = Form1.GetList();
            ProsesCuci proses = new ProsesCuci();
            string pro = proses.ProsesInput(ListKendaraan[idx], textBox1.Text);
            MessageBox.Show(pro);
            form2.ReloadTable();
            this.Hide();
        }
    }
}
