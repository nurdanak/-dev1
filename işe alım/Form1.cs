/**********************************************************
**                SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                  2019-2020 BAHAR DÖNEMİ
**             
**             ÖDEV NUMARASI......: Ödev 2
**             ÖĞRENCİ ADI........: Nurdan AKINCI
**             ÖĞRENCİ NUMARASI...: b191200044
**         DERSİN ALINDIĞI GRUP...: A
**********************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace işe_alım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // KAYDET BUTONU:
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(radioButton3.Checked== true)//kadın
            {
                Kadin yenikadin = new Kadin();
                yenikadin.Cinsiyet = radioButton3.Text;
                yenikadin.TcNo = textBox2.Text;
                yenikadin.AdSoyad = textBox1.Text;
                /* MEZUNIYET */
                if (radioButton1.Checked == true)
                {
                    yenikadin.Mezuniyet = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    yenikadin.Mezuniyet = radioButton2.Text;
                }
                /* DILLER */
                if (checkBox1.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox1.Text;

                }
                if (checkBox2.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox2.Text;

                }
                if (checkBox3.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox3.Text;

                }
                if (checkBox4.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox4.Text;

                }
                if (checkBox5.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox5.Text;

                }
                if (checkBox6.Checked == true)
                {
                    yenikadin.Diller = yenikadin.Diller + "," + checkBox6.Text;

                }
                yenikadin.Diller = yenikadin.Diller.Substring(1); // diller değişkeninin başındaki virgülü atar.

                /* UZMANLIK */
                if (checkBox7.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox7.Text;

                }
                if (checkBox8.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox8.Text;

                }
                if (checkBox9.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox9.Text;

                }
                if (checkBox10.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox10.Text;

                }
                if (checkBox11.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox11.Text;

                }
                if (checkBox12.Checked == true)
                {
                    yenikadin.Uzmanlik = yenikadin.Uzmanlik + "," + checkBox12.Text;

                }
                yenikadin.Uzmanlik = yenikadin.Uzmanlik.Substring(1); // uzmanlık değişkeninin başındaki virgülü atar.

                //listbox'a verileri aktarma:
                listBox1.Items.Add("TC NO: " + yenikadin.TcNo + " | " + "ADI SOYADI: " + yenikadin.AdSoyad + " | " + "CİNSİYETİ: " + yenikadin.Cinsiyet + " | " + "DİLLER: " + yenikadin.Diller + " | " + "UZMANLIK: " + yenikadin.Uzmanlik);

            }

            /* ------------------------------------ */

            else if (radioButton4.Checked == true)//erkek
            {
                Erkek yenierkek = new Erkek();
                yenierkek.Cinsiyet = radioButton3.Text;
                yenierkek.TcNo = textBox2.Text;
                yenierkek.AdSoyad = textBox1.Text;
                /* MEZUNIYET */
                if (radioButton1.Checked == true)
                {
                    yenierkek.Mezuniyet = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    yenierkek.Mezuniyet = radioButton2.Text;
                }
                /* DILLER */
                if (checkBox1.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox1.Text;

                }
                if (checkBox2.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox2.Text;

                }
                if (checkBox3.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox3.Text;

                }
                if (checkBox4.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox4.Text;

                }
                if (checkBox5.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox5.Text;

                }
                if (checkBox6.Checked == true)
                {
                    yenierkek.Diller = yenierkek.Diller + "," + checkBox6.Text;

                }
                yenierkek.Diller = yenierkek.Diller.Substring(1); // diller değişkeninin başındaki virgülü atar.

                /* UZMANLIK */
                if (checkBox7.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox7.Text;

                }
                if (checkBox8.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox8.Text;

                }
                if (checkBox9.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox9.Text;

                }
                if (checkBox10.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox10.Text;

                }
                if (checkBox11.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox11.Text;

                }
                if (checkBox12.Checked == true)
                {
                    yenierkek.Uzmanlik = yenierkek.Uzmanlik + "," + checkBox12.Text;

                }
                yenierkek.Uzmanlik = yenierkek.Uzmanlik.Substring(1); // uzmanlık değişkeninin başındaki virgülü atar.

                //listbox'a verileri aktarma:
                listBox1.Items.Add("TC NO: " + yenierkek.TcNo + " | " + "ADI SOYADI: " + yenierkek.AdSoyad + " | " + "CİNSİYETİ: " + yenierkek.Cinsiyet + " | " + "DİLLER: " + yenierkek.Diller + " | " + "UZMANLIK: " + yenierkek.Uzmanlik);

            }
            
        }

        // SİL BUTONU:
        private void button2_Click(object sender, EventArgs e)
        {
            // listboxdaki seçili kısmı siler.
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // TÜMÜNÜ SİL BUTONU:
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // YENİ KAYIT BUTONU:
        private void button4_Click(object sender, EventArgs e)
        {
            // Bütün bilgileri siler.
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked    = false;
            checkBox2.Checked    = false;
            checkBox3.Checked    = false;
            checkBox4.Checked    = false;
            checkBox5.Checked    = false;
            checkBox6.Checked    = false;
            checkBox7.Checked    = false;
            checkBox8.Checked    = false;
            checkBox9.Checked    = false;
            checkBox10.Checked   = false;
            checkBox11.Checked   = false;
            checkBox12.Checked   = false;

        }
        
        // Form2deki listbox a veri aktarabilmek için string tipinde bir dizi oluşturuyorum.

        public static int liste;
        
        public static string[] elemanlar = new string[100];

        private void veriaktar()  // veriaktar() metodu ile listboxdaki verileri diziye aktarıyorum.
        {
            liste = listBox1.Items.Count;
            for (int i = 0; i < liste; i++)
            {
                elemanlar[i] = Convert.ToString(listBox1.Items[i]);

            }
        }

        private void button5_Click(object sender, EventArgs e) // form2 yi aç.
        {
            veriaktar(); // metodu form2 açılmadan çalıştırıyorum.
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e) // Başvuran Kişi Sayısı
        {
            liste = listBox1.Items.Count;
            MessageBox.Show("İşe Başvuran Kişi Sayısı:\n" + Convert.ToString(liste));
        }

        
        
    }
}
