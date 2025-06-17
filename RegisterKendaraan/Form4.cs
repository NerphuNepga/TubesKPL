using KonversiHarga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKPL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegisterKendaraan
{
    public partial class Form4 : Form
    {
        private int idx;
        private string metodePembayaran;
        private Form2 form2;
        private Form3 form3;
        List<ACuciKendaraan> listKendaraan = Form1.GetList();
        public Form4(Form2 form2, Form3 form3)
        {
            this.form3 = form3;
            this.form2 = form2;
            InitializeComponent();
        }

        public void GetDataKendaraan(int index)
        {
            idx = index;
            isiNama.Text = listKendaraan[index].GetNamaPemilik();
            isiJenis.Text = listKendaraan[index].GetJenisKendaraan();
            isiHarga.Text = Konversi.KonversiHarga(form3.GetTotal(), listKendaraan[index].GetJenisKendaraan().ToLower()).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metodePembayaran = "cash";
            nominal.Text = "Nominal: ";
            nominal.Show();
            isiNominal.Show();
            isiNominal.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(isiNominal.Text))
            {
                MessageBox.Show("Input tidak boleh kosong.");
                return;
            }
            if (!Regex.IsMatch(isiNominal.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Input Harus Angka");
            }
            else
            {
                switch (metodePembayaran)
                {
                    case "kartu kredit":
                        KartuKreditCreator kartuCreator = new KartuKreditCreator(isiNominal.Text);
                        string hasilKartu = kartuCreator.ProsesPembayaranUtama(int.Parse(isiHarga.Text));
                        MessageBox.Show(hasilKartu);
                        break;

                    case "transfer":
                        TransferCreator transferCreator = new TransferCreator(isiNominal.Text);
                        string hasilTransfer = transferCreator.ProsesPembayaranUtama(int.Parse(isiHarga.Text));
                        MessageBox.Show(hasilTransfer);
                        break;

                    case "cash":
                        CashCreator cashCreator = new CashCreator(int.Parse(isiNominal.Text));
                        if (int.Parse(isiNominal.Text) < int.Parse(isiHarga.Text))
                        {
                            MessageBox.Show("Duit Kurang");
                        }
                        else
                        {
                            string hasilCash = cashCreator.ProsesPembayaranUtama(int.Parse(isiHarga.Text));
                            MessageBox.Show(hasilCash);
                        }
                        break;
                    default:
                        throw new ArgumentException("Metode pembayaran tidak didukung.");
                }
                listKendaraan.RemoveAt(idx);
                form2.ReloadTable();
                this.Hide();
            }
        }

        private void kreditPic_Click(object sender, EventArgs e)
        {
            metodePembayaran = "kartu kredit";
            nominal.Text = "No.Kartu: ";
            nominal.Show();
            isiNominal.Show();
            isiNominal.Enabled = true;
        }

        private void transferPic_Click(object sender, EventArgs e)
        {
            metodePembayaran = "transfer";
            nominal.Text = "No. Rek: ";
            nominal.Show();
            isiNominal.Show();
            isiNominal.Enabled = true;
        }
    }
}
