﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TubesKPL;

namespace RegisterKendaraan
{
    public partial class Form2 : Form
    {
        private Form3 frm3;
        private Form4 frm4;
        List<ACuciKendaraan> ListKendaraan = Form1.GetList();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < ListKendaraan.Count(); i++)
            {
                string[] data = { ListKendaraan[i].GetNamaPemilik(), ListKendaraan[i].GetJenisKendaraan(), ListKendaraan[i].GetState().ToString() };
                dataGridView1.Rows.Add(data);
            }
            btnAksi.UseColumnTextForButtonValue = true;
        }

        public void ReloadTable()
        {
            dataGridView1.Rows.Clear();
            List<ACuciKendaraan> ListKendaraan = Form1.GetList();

            foreach (var item in ListKendaraan)
            {
                if (item.GetState().ToString() == "Keluar")
                {
                    btnAksi.Text = "Bayar";
                }

                else
                {
                    btnAksi.Text = "Kelola";
                }
                    dataGridView1.Rows.Add(item.GetNamaPemilik(), item.GetJenisKendaraan(), item.GetState().ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnAksi"].Index && e.RowIndex >= 0)
            {



                if (ListKendaraan[e.RowIndex].GetState().ToString() == "Keluar")
                {
                    frm4 = new Form4(this, frm3);
                    frm4.GetDataKendaraan(e.RowIndex);
                    frm4.Show();
                }
                else
                {
                    if (frm3 == null || frm3.IsDisposed)
                    {
                        frm3 = new Form3(this);
                    }
                    frm3.GetDataKendaraan(e.RowIndex);
                    frm3.Show();
                    frm3.BringToFront();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(this);
            frm.Show();
        }
    }
}
