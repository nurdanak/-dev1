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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e) // İşe Alınanların Bilgilerini Al Butonu
        {
            for (int i = 0; i < Form2.a; i++)
            {
                listBox1.Items.Add(Form2.items[i]);
            }
        }

        public static int say; // İşe Alınanların Sayısını Tutan say değişkeni tanımladım.

        
        private void btn_uygula_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Gönder":
                    MessageBox.Show("Mesajınız iletilmiştir!\n\nGönderdiğiniz mesaj:\n\n"+textBox1.Text);
                    say++;
                    say_label.Text = Convert.ToString(say);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    textBox1.Clear();
                    break;
                case "Mesajı Sil":
                    textBox1.Clear();
                    break;
                case "Taslağa Kaydet":
                    listBox2.Items.Add(textBox1.Text);
                    break;
            }
        }



        private void sil_btn_Click(object sender, EventArgs e) // seçili olanı sil butonu
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btn_taşı_Click(object sender, EventArgs e) // mesaj kutusuna taşı butonu
        {
            
                textBox1.Text = Convert.ToString(listBox2.SelectedItem);

                listBox2.Items.Remove(listBox2.SelectedItem);

        }

       
    }
}
