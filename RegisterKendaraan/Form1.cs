using TubesKPL;

namespace RegisterKendaraan
{
    public partial class Form1 : Form
    {
        public static List<ACuciKendaraan> ListKendaraan = new List<ACuciKendaraan>();
        private Form2 form2;
        public Form1(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACuciKendaraan aCuci = new ACuciKendaraan(textBox1.Text, CekButton());
            ListKendaraan.Add(aCuci);
            form2.ReloadTable();
            this.Hide();
        }
        public static List<ACuciKendaraan> GetList()
        {
            return ListKendaraan;
        }
        private string CekButton()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                return radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                return radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                return radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                return radioButton5.Text;
            }
            return "Tidak Ada";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
