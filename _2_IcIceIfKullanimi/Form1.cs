using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_IcIceIfKullanimi
{
    public partial class Form1 : Form
    {
        // SORU : Bir öğrenci için 2 vize 1 final notu giriliyor. 
        //Eğer final 50 den küçükse öğrenci, vizelerinin ne olduğuna bakılmaksızın direk kalıyor.
        //Eğer finali 50 den yüksekse, bu durumda öğrencinin vizelerinni ortalamasının %60 ı ile, finalin %40 ı toplanıyor.
        //elde edilen puan 50 den büyükse geçiyor, küçükse kalıyor.
        public Form1()
        {
            InitializeComponent();
        }

        int vize1, vize2, final;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double puan;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize1 = 0; vize2 = 0; final = 0;
            puan = 0.0;
            #region Uzun Yol

            if (txtVize1.Text == "")
            {
                MessageBox.Show("VİZE 1 GİRİNİZ");
            }
            else if (txtVize2.Text == "")
            {
                MessageBox.Show("VİZE 2 GİRİNİZ");
            }
            else if (txtFinal.Text == "")

            {
                MessageBox.Show("FİNAL GİRİNİZ");
            }



            //if (txtVize1.Text == "")
            //{
            //    MessageBox.Show("VİZE 1 GİRİNİZ");
            //}
            //if (txtVize2.Text == "")
            //{
            //    MessageBox.Show("VİZE 2 GİRİNİZ");
            //}
            //if (txtFinal.Text == "")
            //{
            //    MessageBox.Show("FİNAL GİRİNİZ");
            //}
            #endregion

            if (txtVize1.Text == "" || txtVize2.Text == string.Empty || txtFinal.Text == "")
            {
                MessageBox.Show("Lütfen boş bırakmayınız");
            }
            else
            {
                vize1 = int.Parse(txtVize1.Text);
                vize2 = int.Parse(txtVize2.Text);
                final = int.Parse(txtFinal.Text);

                if (final < 50)
                {
                    lblBilgileriniz.Text = "ORTALAMA HESAPLANMADI. KALDINIZ";
                }
                else
                {
                    puan = ((vize1 + vize2) / 2) * 0.6 + final * 0.4;
                    if (puan > 50)
                    {
                        lblBilgileriniz.Text = "ORTALAMANIZ : " + puan + "\nGEÇTİNİZ";
                    }
                    else
                    {
                        lblBilgileriniz.Text = "ORTALAMANIZ : " + puan + "\nKALDINIZ";
                    }
                }

            }


        }
    }
}
