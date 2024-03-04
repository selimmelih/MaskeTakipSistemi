using Business.Concrete;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;
using System.Configuration;
using Business.Abstract;
using System;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            IApplicantService applicantService = new PersonManager(); // Örnek bir IApplicantService nesnesi oluşturun
            PttManager pttManager = new PttManager(applicantService); // PttManager sınıfını oluştururken bağımlılığı enjekte edin  
            Program program = new Program();
            program.AddPerson();

            //PttManager pttManager = new PttManager(new PersonManager());

            //Degiskenler();
            //static void SelamVer(string isim = "isimsiz")
            //{
            //    //kod 
            //    // kod
            //    //  kod

            //    Console.WriteLine("Merhaba " + isim);
            //}
            //SelamVer("selim");
            //SelamVer("melih");
            //SelamVer("deniz");
            //SelamVer("o");
            //SelamVer("bu");
            //SelamVer();


            // Diziler / Arrays

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Selim";
            //ogrenciler[1] = "Melih";
            //ogrenciler[2] = "Turhan";
            //ogrenciler = new string[4];
            //ogrenciler[3] = "Ahaha";


            //for (var i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            //sehirler2 = sehirler1; //aynı referansa gider
            //sehirler1[0] = "Adana";
            //Console.WriteLine(sehirler2[0]);
            // MyList diye sınıf yap bu alttakini nasıl yazailbiir. Collection yap
            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "Kastamonu" };
            yeniSehirler1.Add("İzmir");

            //foreach (var sehir in yeniSehirler1)
            //{
            //    Console.WriteLine(sehir + " yeni");
            //}

            //pttManager.GiveMask(person1);


            //static int Topla(int sayi1 = 5, int sayi2 = 10)
            //{
            //    int sonuc = sayi1 + sayi2;
            //    Console.WriteLine("Toplam: " + sonuc);
            //    return sonuc;
            //}
            //Topla(3, 654);
            //Topla();
            //Topla(50);
        }
        public void AddPerson()
        {
            IApplicantService applicantService = new PersonManager(); // Örnek bir IApplicantService nesnesi oluşturun
            PttManager pttManager = new PttManager(applicantService); // PttManager sınıfını oluştururken bağımlılığı enjekte edin  
            PersonManager personManager = new PersonManager();
            bool varMi = true;
            Console.WriteLine("İsim Giriniz: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Soyisim Giriniz: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("TC No Giriniz: ");
            long tcNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Doğum Tarihi Giriniz: ");
            int dogumYili = Convert.ToInt32(Console.ReadLine());
            using (var _context = new PersonContext())
            {
                var person1 = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    NationalIdentity = tcNo,
                    DateOfBirthYear = dogumYili,
                    //HasMask = varMi
                };
                if(personManager.CheckPerson(person1)==true)
                {
                    person1.HasMask = true;
                }
                else
                {
                    person1.HasMask = false;
                }
                //ISupplierService supplierService = new ISupplierService(person1);
                //supplierService
                pttManager.GiveMask(person1);
                _context.People.Add(person1);
                _context.SaveChanges();
                Console.WriteLine("Eklendi.");
            }
        }
    }



    //static void Degiskenler()
    //{
    //    // See https://aka.ms/new-console-template for more information
    //    Console.WriteLine("Hello, World!");


    //    string mesaj = "merhaba";
    //    double tutar = 1005.600;
    //    int sayi = 100;
    //    bool girisYapildiMi = false;


    //    string ad = "SelimMelih";
    //    string soyad = "Turhan";
    //    int dogumYili = 2000;
    //    long tcNo = 12345678910;

    //    Console.WriteLine(tutar);
    //    Console.WriteLine(tutar * 1.18);
    //    Console.WriteLine(girisYapildiMi);
    //    Console.WriteLine(mesaj); Console.WriteLine(mesaj); Console.WriteLine(mesaj); Console.WriteLine(mesaj); Console.WriteLine(mesaj);
    //}
    }