/**********************************************************
**                SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                  2019-2020 BAHAR DÖNEMİ
**             
**             ÖDEV NUMARASI......: Ödev 1
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
            //değişkenleri tanımlama:
            string tcno = " ", adsoyad = " ", cinsiyet = " ", mezuniyet = " ", diller = " ", uzmanlık = " ";
            tcno = textBox2.Text;
            adsoyad = textBox1.Text;
            //cinsiyet:
            if(radioButton3.Checked== true)
            {
                cinsiyet = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                cinsiyet = radioButton4.Text;
            }
            //mezuniyet:
            if(radioButton1.Checked== true)
            {
                mezuniyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                mezuniyet = radioButton2.Text;
            }
            //diller:
            if (checkBox1.Checked == true)
            {
                diller = diller + "," + checkBox1.Text;

            }
            if (checkBox2.Checked == true)
            {
                diller = diller + "," + checkBox2.Text;

            }
            if (checkBox3.Checked == true)
            {
                diller = diller + "," + checkBox3.Text;

            }
            if (checkBox4.Checked == true)
            {
                diller = diller + "," + checkBox4.Text;

            }
            if (checkBox5.Checked == true)
            {
                diller = diller + "," + checkBox5.Text;

            }
            if (checkBox6.Checked == true)
            {
                diller = diller + "," + checkBox6.Text;

            }
            diller = diller.Substring(2); // diller değişkeninin başındaki virgülü atar.

            //uzmanlık:
            if (checkBox7.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox7.Text;

            }
            if (checkBox8.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox8.Text;

            }
            if (checkBox9.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox9.Text;

            }
            if (checkBox10.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox10.Text;

            }
            if (checkBox11.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox11.Text;

            }
            if (checkBox12.Checked == true)
            {
                uzmanlık = uzmanlık + "," + checkBox12.Text;

            }
            uzmanlık = uzmanlık.Substring(2); // uzmanlık değişkeninin başındaki virgülü atar.

            //listbox'a verileri aktarma:

            listBox1.Items.Add("TC NO: " + tcno + " | " + "ADI SOYADI: " + adsoyad + " | " + "CİNSİYETİ: " + cinsiyet + " | " + "DİLLER: " + diller + " | " + "UZMANLIK: " + uzmanlık);

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
