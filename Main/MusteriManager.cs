using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
{
    public class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void Add(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("\nEklendi " + musteri.Name);
        }
        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("\nSilindi ");
        }
        public void Update(Musteri musteri)
        {
            var _musteri = musteriler.FirstOrDefault(x => x.Id == musteri.Id);
            if (_musteri != null) _musteri.Name = musteri.Name;
            Console.WriteLine("\nGüncellendi " + musteri.Name);
        }
        public void List()
        {
            Console.WriteLine("\nListelendi");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("-- "+ musteri.Name);
            }
        }
    }
}
