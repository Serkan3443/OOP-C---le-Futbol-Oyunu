using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FUTBOLOYUNU_OOP
{
    public class Futbolcu
    {
        public Random RastgeleSayi=new Random();
        public string AdSoyad { get; set; }
        public int FormaNo { get; set; }
        public int Hiz { get; set; }
        public int Dayaniklilik { get; set; }
        public int Pas { get; set; }
        public int Sut { get; set; }
        public int Yetenek { get; set; }
        public int Kararlilik { get; set; }
        public int DogalForm { get; set; }
        public int Sans { get; set; }
        public Futbolcu(string AdSoyad, int FormaNo)//Bunlar Kurucu fonksiyondur
        {
             Hiz= RastgeleSayi.Next(50, 100);
             Dayaniklilik= RastgeleSayi.Next(50, 100);
             Pas= RastgeleSayi.Next(50, 100);
             Sut= RastgeleSayi.Next(50, 100);
             Yetenek= RastgeleSayi.Next(50, 100);
             Kararlilik= RastgeleSayi.Next(50, 100);
             DogalForm= RastgeleSayi.Next(50, 100);
             Sans= RastgeleSayi.Next(50, 100);
             

        }
        public Futbolcu()
        {
            //bunu yazdım çünkü defans,ortasaha ve forvet kurucu fonskiyonları hata vermesin diye
        }
        public virtual Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if(PasSkor>60)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }
        public virtual Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 01 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            if(GolSkor>70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Defans:Futbolcu 
    {
        Random RastgeleSayi= new Random();
        public int PozisyonAlma { get; set; }
        public int Kafa { get; set; }
        public int Sicrama { get; set; }
        public Defans(string AdSoyad, int FormaNo)//Bunlar Kurucu fonksiyondur
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(50, 90);
            Dayaniklilik = RastgeleSayi.Next(50, 90);
            Pas = RastgeleSayi.Next(50, 90);
            Sut = RastgeleSayi.Next(50, 90);
            Yetenek = RastgeleSayi.Next(50, 90);
            Kararlilik = RastgeleSayi.Next(50, 90);
            DogalForm = RastgeleSayi.Next(50, 90);
            Sans = RastgeleSayi.Next(50, 90);

            PozisyonAlma = RastgeleSayi.Next(50, 90);
            Kafa = RastgeleSayi.Next(50, 90);
            Sicrama = RastgeleSayi.Next(50, 90);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 01 + DogalForm * 0.1 + Kafa * 0.1 +Sicrama * 0.1 + Sans * 0.1);
            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class OrtaSaha:Futbolcu 
    {
        Random RastgeleSayi=new Random();
        public int UzunTop { get; set; }
        public int İlkDokunus { get; set; }
        public int Uretkenlik { get; set; }
        public int TopSurme { get; set; }
        public int OzelYetenek { get; set; }
        public OrtaSaha(string AdSoyad, int FormaNo)//Bunlar Kurucu fonksiyondur
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(60, 100);
            Dayaniklilik = RastgeleSayi.Next(06, 100);
            Pas = RastgeleSayi.Next(60, 100);
            Sut = RastgeleSayi.Next(60, 100);
            Yetenek = RastgeleSayi.Next(60, 100);
            Kararlilik = RastgeleSayi.Next(60, 100);
            DogalForm = RastgeleSayi.Next(60, 100);
            Sans = RastgeleSayi.Next(60, 100);

            UzunTop = RastgeleSayi.Next(60, 100);
            İlkDokunus = RastgeleSayi.Next(60, 100);
            Uretkenlik = RastgeleSayi.Next(60, 100);
            TopSurme = RastgeleSayi.Next(60, 100);
            OzelYetenek = RastgeleSayi.Next(60, 100);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 +OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + + TopSurme *0.1 + Sans * 0.2);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + İlkDokunus * 0.1 + Kararlilik * 01 + DogalForm * 0.1 + Sans * 0.1);
            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }  
    public class Forvet:Futbolcu
    {
        Random RastgeleSayi=new Random();
        public int Bitiriclik { get; set; }
        public int İlkDokunma { get; set; }
        public int Kafa { get; set; }
        public int OzelYetenek { get; set; }
        public int Sogukkanlilik { get; set; }
        public Forvet(string AdSoyad, int FormaNo)//Bunlar Kurucu fonksiyondur
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;
            Hiz = RastgeleSayi.Next(70, 100);
            Dayaniklilik = RastgeleSayi.Next(70, 100);
            Pas = RastgeleSayi.Next(70, 100);
            Sut = RastgeleSayi.Next(70, 100);
            Yetenek = RastgeleSayi.Next(70, 100);
            Kararlilik = RastgeleSayi.Next(70, 100);
            DogalForm = RastgeleSayi.Next(70, 100);
            Sans = RastgeleSayi.Next(70, 100);

            Bitiriclik = RastgeleSayi.Next(70, 100);
            İlkDokunma = RastgeleSayi.Next(70, 100);
            Kafa = RastgeleSayi.Next(70, 100);
            OzelYetenek = RastgeleSayi.Next(70, 100);
            Sogukkanlilik = RastgeleSayi.Next(70, 100);
        }
        public override Boolean PasVer()
        {
            int PasSkor = Convert.ToInt32(Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1);
            if (PasSkor > 60)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public override Boolean GolVurusu()
        {
            int GolSkor = Convert.ToInt32(Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + İlkDokunma * 0.1 + Bitiriclik * 0.1 + Sogukkanlilik * 0.1 +Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.2);
            if (GolSkor > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
