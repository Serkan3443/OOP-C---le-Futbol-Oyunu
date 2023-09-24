namespace FUTBOLOYUNU_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Futbolcu> takim = new List<Futbolcu>();
            takim.Add(new Futbolcu("Kaleci",1));
            takim.Add(new Futbolcu("Defans",2));
            takim.Add(new Futbolcu("Defans",3));
            takim.Add(new Futbolcu("Defans",4));
            takim.Add(new Futbolcu("Defans",5));
            takim.Add(new Futbolcu("OrtaSaha",6));
            takim.Add(new Futbolcu("OrtaSaha",7));
            takim.Add(new Futbolcu("OrtaSaha",8));
            takim.Add(new Futbolcu("OrtaSaha",9));
            takim.Add(new Futbolcu("Forvet",10));
            takim.Add(new Futbolcu("Forvet",11));
            Random rastgele=new Random();
            int formaNo;
            int paskontrol=12;
            Boolean GolOlabilir = true;
            formaNo = rastgele.Next(1, 12);
            for (int i =1; i<=5; i++)
            {
                while(paskontrol==formaNo)
                {
                    formaNo = rastgele.Next(1, 12);
                }
                paskontrol = formaNo;
                if (!takim[formaNo-1].PasVer())
                {
                    Console.WriteLine(formaNo + "Numaralı oyuncunun pası başarısız");
                    GolOlabilir = false;
                    break;

                }
                else
                {
                    Console.WriteLine(formaNo + "Numaralı oyuncunun pası tam isabet ");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine(formaNo + "Numaralı oyuncu kaleci ile karşı karşıya");
            System.Threading.Thread.Sleep(1000);
            if (GolOlabilir=true)
            {
                if (takim[formaNo].GolVurusu())
                {
                    Console.WriteLine("GOOOOOOOOOOLLLLLLL\n" + formaNo + "Numaralı oyuncu Harika bir Gol attı, Koçum benim ");
                }

                else
                {
                    Console.WriteLine("Son anda kaleci kornere çeldi  ");
                }
            }
            Console.ReadLine();

           
            
        }
    }
}