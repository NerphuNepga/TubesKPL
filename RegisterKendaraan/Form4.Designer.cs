namespace RegisterKendaraan
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            cashPic = new PictureBox();
            kreditPic = new PictureBox();
            labelCash = new Label();
            labelKredit = new Label();
            labelTrasnfer = new Label();
            button1 = new Button();
            nominal = new Label();
            isiNominal = new TextBox();
            isiNama = new Label();
            transferPic = new PictureBox();
            isiJenis = new Label();
            isiHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kreditPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transferPic).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-58, -78);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(917, 607);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(307, 44);
            label2.TabIndex = 13;
            label2.Text = "Nama Pemilik: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(364, 44);
            label1.TabIndex = 14;
            label1.Text = "Jenis Kendaraan: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(277, 44);
            label3.TabIndex = 15;
            label3.Text = "Harga Total: ";
            // 
            // cashPic
            // 
            cashPic.BackgroundImageLayout = ImageLayout.Center;
            cashPic.Image = (Image)resources.GetObject("cashPic.Image");
            cashPic.Location = new Point(12, 197);
            cashPic.Name = "cashPic";
            cashPic.Size = new Size(120, 103);
            cashPic.SizeMode = PictureBoxSizeMode.StretchImage;
            cashPic.TabIndex = 16;
            cashPic.TabStop = false;
            cashPic.Click += pictureBox2_Click;
            // 
            // kreditPic
            // 
            kreditPic.BackgroundImageLayout = ImageLayout.Center;
            kreditPic.Image = (Image)resources.GetObject("kreditPic.Image");
            kreditPic.Location = new Point(169, 197);
            kreditPic.Name = "kreditPic";
            kreditPic.Size = new Size(120, 103);
            kreditPic.SizeMode = PictureBoxSizeMode.StretchImage;
            kreditPic.TabIndex = 17;
            kreditPic.TabStop = false;
            kreditPic.Click += kreditPic_Click;
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCash.Location = new Point(40, 303);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(66, 27);
            labelCash.TabIndex = 19;
            labelCash.Text = "Cash";
            // 
            // labelKredit
            // 
            labelKredit.AutoSize = true;
            labelKredit.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelKredit.Location = new Point(186, 303);
            labelKredit.Name = "labelKredit";
            labelKredit.Size = new Size(88, 27);
            labelKredit.TabIndex = 20;
            labelKredit.Text = "Kredit";
            labelKredit.Click += label5_Click;
            // 
            // labelTrasnfer
            // 
            labelTrasnfer.AutoSize = true;
            labelTrasnfer.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTrasnfer.Location = new Point(332, 303);
            labelTrasnfer.Name = "labelTrasnfer";
            labelTrasnfer.Size = new Size(114, 27);
            labelTrasnfer.TabIndex = 21;
            labelTrasnfer.Text = "Transfer";
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 466);
            button1.Name = "button1";
            button1.Size = new Size(823, 46);
            button1.TabIndex = 22;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nominal
            // 
            nominal.AutoSize = true;
            nominal.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nominal.Location = new Point(12, 344);
            nominal.Name = "nominal";
            nominal.Size = new Size(198, 44);
            nominal.TabIndex = 23;
            nominal.Text = "Nominal: ";
            nominal.Visible = false;
            nominal.Click += label4_Click;
            // 
            // isiNominal
            // 
            isiNominal.Enabled = false;
            isiNominal.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiNominal.HideSelection = false;
            isiNominal.Location = new Point(216, 342);
            isiNominal.Name = "isiNominal";
            isiNominal.Size = new Size(607, 50);
            isiNominal.TabIndex = 27;
            // 
            // isiNama
            // 
            isiNama.AutoSize = true;
            isiNama.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiNama.Location = new Point(325, 9);
            isiNama.Name = "isiNama";
            isiNama.Size = new Size(0, 44);
            isiNama.TabIndex = 28;
            // 
            // transferPic
            // 
            transferPic.BackgroundImageLayout = ImageLayout.Center;
            transferPic.Image = (Image)resources.GetObject("transferPic.Image");
            transferPic.Location = new Point(326, 197);
            transferPic.Name = "transferPic";
            transferPic.Size = new Size(120, 103);
            transferPic.SizeMode = PictureBoxSizeMode.StretchImage;
            transferPic.TabIndex = 18;
            transferPic.TabStop = false;
            transferPic.Click += transferPic_Click;
            // 
            // isiJenis
            // 
            isiJenis.AutoSize = true;
            isiJenis.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiJenis.Location = new Point(382, 67);
            isiJenis.Name = "isiJenis";
            isiJenis.Size = new Size(0, 44);
            isiJenis.TabIndex = 29;
            // 
            // isiHarga
            // 
            isiHarga.AutoSize = true;
            isiHarga.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiHarga.Location = new Point(295, 126);
            isiHarga.Name = "isiHarga";
            isiHarga.Size = new Size(0, 44);
            isiHarga.TabIndex = 30;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 524);
            Controls.Add(isiHarga);
            Controls.Add(isiJenis);
            Controls.Add(isiNama);
            Controls.Add(isiNominal);
            Controls.Add(nominal);
            Controls.Add(button1);
            Controls.Add(labelTrasnfer);
            Controls.Add(labelKredit);
            Controls.Add(labelCash);
            Controls.Add(transferPic);
            Controls.Add(kreditPic);
            Controls.Add(cashPic);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)kreditPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)transferPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox cashPic;
        private PictureBox kreditPic;
        private Label labelCash;
        private Label labelKredit;
        private Label labelTrasnfer;
        private Button button1;
        private Label nominal;
        private TextBox isiNominal;
        private Label isiNama;
        private PictureBox transferPic;
        private Label isiJenis;
        private Label isiHarga;
    }
}