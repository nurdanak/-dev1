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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e) //Form1den veri al Butonu
        {
            for (int i = 0; i < Form1.liste; i++)
            {
                listBox1.Items.Add(Form1.elemanlar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Ara Butonu
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.SelectionMode = SelectionMode.MultiSimple;
                    listBox1.SetSelected(i, true);
                }
              
            }
        }

        private void button3_Click(object sender, EventArgs e) // Aşağı Aktar Butonu
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
             
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e) // Seçimi Kaldır.
        {
            listBox1.ClearSelected();
        }

        private void button6_Click(object sender, EventArgs e) // Yukarı Aktar Butonu
        {
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {

                listBox1.Items.Add(listBox2.SelectedItems[i]);

                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }
        
        private void button5_Click(object sender, EventArgs e) // seçili olanı sil.
        {
            
            listBox2.Items.Remove(listBox2.SelectedItem);
           
        }

        public static int a;

        public static string[] items = new string[100];

        private void button7_Click(object sender, EventArgs e) // mesaj at butonu (form3' ü açar)
        {
            Form3 f3 = new Form3();
            f3.Show();
            //listbox2 deki verileri say
            a = listBox2.Items.Count;
            //listbox2 deki verileri yukarıda tanımladığım dizide tutuyorum.
            for (int i = 0; i < a; i++)
            {
                items[i] = Convert.ToString(listBox2.Items[i]);

            }
           
        }
    }
}
