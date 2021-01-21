using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(01,"Adana");
            sehirler.Add(02, "Adıyaman");
            sehirler.Add(03, "Afyon");
            sehirler.Add(04, "Ağrı");
            sehirler.Add(05, "Amasya");
            sehirler.Add(06, "Ankara");
            sehirler.Add(07, "Antalya");
            sehirler.Add(08, "Artvin");
            sehirler.Add(09, "Aydın");
            sehirler.Add(10, "Balıkesir");
            sehirler.Add(11, "Bilecik");
            sehirler.Add(12, "Bingöl");
            sehirler.Add(13, "Bitlis");
            sehirler.Add(14, "Bolu");
            sehirler.Add(15, "Burdur");
            sehirler.Add(16, "Bursa");
            sehirler.Add(17, "Çanakkale");
            sehirler.Add(18, "Çankırı");
            sehirler.Add(19, "Çorum");
            sehirler.Add(20, "Denizli");
            sehirler.Add(21, "Diyarbakır");
            sehirler.Add(22, "Edirne");
            sehirler.Add(23, "Elazığ");
            sehirler.Add(24, "Erzincan");
            sehirler.Add(25, "Erzurum");
            sehirler.Add(26, "Eskişehir");
            sehirler.Add(27, "Gaziantep");
            sehirler.Add(28, "Giresun");
            sehirler.Add(29, "Gümüşhane");
            sehirler.Add(30, "Hakkari");
            sehirler.Add(31, "Hatay");
            sehirler.Add(32, "Isparta");
            sehirler.Add(33, "Mersin");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(35, "Izmir");
            sehirler.Add(36, "Kars");
            sehirler.Add(37, "Kastamonu");
            sehirler.Add(38, "Kayseri");
            sehirler.Add(39, "Kırklareli");
            sehirler.Add(40, "Kırşehir");
            sehirler.Add(41, "Kocaeli");
            sehirler.Add(42, "Konya");
            sehirler.Add(43, "Kütahya");
            sehirler.Add(44, "Malatya");
            sehirler.Add(45, "Manisa");
            sehirler.Add(46, "K.Maraş");
            sehirler.Add(47, "Mardin");
            sehirler.Add(48, "Muğla");
            sehirler.Add(49, "Muş");
            sehirler.Add(50, "Nevşehir");
            sehirler.Add(51, "Niğde");
            sehirler.Add(52, "Ordu");
            sehirler.Add(53, "Rize");
            sehirler.Add(54, "Sakarya");
            sehirler.Add(55, "Samsun");
            sehirler.Add(56, "Siirt");
            sehirler.Add(57, "Sinop");
            sehirler.Add(58, "Sivas");
            sehirler.Add(59, "Tekirdağ");
            sehirler.Add(60, "Tokat");
            sehirler.Add(61, "Trabzon");
            sehirler.Add(62, "Tunceli");
            sehirler.Add(63, "Şanlıurfa");
            sehirler.Add(64, "Uşak");
            sehirler.Add(65, "Van");
            sehirler.Add(66, "Yozgat");
            sehirler.Add(67, "Zonguldak");
            sehirler.Add(68, "Aksaray");
            sehirler.Add(69, "Bayburt");
            sehirler.Add(70, "Karaman");
            sehirler.Add(71, "Kırıkkale");
            sehirler.Add(72, "Batman");
            sehirler.Add(73, "Şırnak");
            sehirler.Add(74, "Bartın");
            sehirler.Add(75, "Ardahan");
            sehirler.Add(76, "Iğdır");
            sehirler.Add(77, "Yalova");
            sehirler.Add(78, "Karabük");
            sehirler.Add(79, "Kilis");
            sehirler.Add(80, "Osmaniye");
            sehirler.Add(81, "Düzce");

            foreach (var plaka in sehirler.Keys)
            {
                Console.WriteLine(plaka);
            }

            foreach (var sehir in sehirler.Values)
            {
                Console.WriteLine(sehir);
            }

            //Console.WriteLine(sehirler.Length);

        }
    }
}
