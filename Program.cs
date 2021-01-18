using System;
using Main;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteriManager = new MusteriManager();
            
            //ekleme
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Ali";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Ayşe";

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            //listeleme
            musteriManager.List();

            //güncelleme
            musteri1.Name = "Fatma";
            musteriManager.Update(musteri1);

            //listeleme
            musteriManager.List();

            //silme
            musteriManager.Delete(musteri2);

            //listeleme
            musteriManager.List();



        }
    }
}
