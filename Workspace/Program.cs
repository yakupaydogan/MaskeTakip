using Business.Concrete;
using Entities.Concrete;

namespace Workspace
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Ayşe");
            SelamVer(isim: "Yakup");
            SelamVer(isim: "Engin");
            SelamVer();

            int sonuc = Topla(5, 7);

            // Diziler / Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Yakup";
            ogrenciler[2] = "Furkan";
            //ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa", "Diyarbakır", "Adana" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İzmir", "İstanbul" };
            yeniSehirler1.Add("Adana");
            foreach (string s in yeniSehirler1)
            {
                Console.WriteLine(s);
            }

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1984;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.Read();
        }


        //resharper 
        public static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        public static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }


        private static void Degiskenler()
        {
            string mesaj = "Merahaba";
            double tutar = 10000; // db'den gelir.
            int sayi = 100;

            string ad = "Yakup";
            string soyad = "Aydoğan";
            int dogumYili = 2004;
            long tcNo = 1234567890;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }



        //pascal casing
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }
    }
}





//Notlar:
//Classları çıplak bırakma interface ekle. Bağımlılıgını ortadan kaldırır.
//SOLID
//single responsibility: her katman her method her class her if blogu 1 işi yapar
//entities: varlık nesnelerini tutar
//bussiness: iş kurallarını tutar (if blokları)

//bussines altındaki abstract soyut; concrete somut nesneleri tutar

//bir sınıf bir sınıfı new liyorsa, değişikliklerde direnç gözlenir. 
//interface (abstractdaki) classlar için tanımlanmalı. İçinde sadece imzalar çağırılabilir.
//sadece imza koymak bağımlılığı çözmez, 