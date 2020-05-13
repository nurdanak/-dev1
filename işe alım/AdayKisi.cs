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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace işe_alım
{
     abstract class AdayKisi
    {
        private string tcno;
        private string adsoyad;
        public string AdSoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }
        public string TcNo
        {
            get { return tcno; }
            set { tcno = value; }
        }
        
        public abstract string Mezuniyet { get; set; }
        public abstract string Diller { get; set; }
        public  abstract string Uzmanlik { get; set; }

    }

    class Kadin : AdayKisi
    {
        private string cinsiyet;
        public  string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        private string mezuniyet;
        public override string Mezuniyet
        {
            get { return mezuniyet; }
            set { mezuniyet = value; }
        }

        private string diller;
        public override string Diller
        {
            get { return diller; }
            set { diller = value; }
        }

        private string uzmanlik;
        public override string Uzmanlik
        {
            get { return uzmanlik; }
            set { uzmanlik = value; }
        }
    }

    class Erkek : AdayKisi
    {
        private string cinsiyet;
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        private string mezuniyet;
        public override string Mezuniyet
        {
            get { return mezuniyet; }
            set { mezuniyet = value; }
        }

        private string diller;
        public override string Diller
        {
            get { return diller; }
            set { diller = value; }
        }

        private string uzmanlik;
        public override string Uzmanlik
        {
            get { return uzmanlik; }
            set { uzmanlik = value; }
        }
    }



}
